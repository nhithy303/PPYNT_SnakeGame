using PPYNT_SnakeGame.ColorSnake;
using PPYNT_SnakeGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace PPYNT_SnakeGame
{
    public partial class FrmSnakeClassic : Form
    {
        private List<Shape> Snake = new List<Shape>();
        private Shape food = new Shape();
        private Shape food1 = new Shape();
        private Powerup powerup = new Powerup() { X = -10, Y = -10 };
        string message;
        private string deathCause = "Game Over";
        bool flag = false;
        public static TextureBrush test = new TextureBrush(Resources.BigFood);
        private static Image background = Resources.grassBackground_01;
        //sounds
        System.Media.SoundPlayer crunch = new System.Media.SoundPlayer(Resources.crunch);
        System.Media.SoundPlayer die = new System.Media.SoundPlayer(Resources.The_Game_Over_1);
        System.Media.SoundPlayer extraPoints = new System.Media.SoundPlayer(Resources.powerup);
        readonly private Map maps;
        readonly Setting settings;
        //private SettingsForm settings;
        private Settings setup = new Settings();
        string filename;
        public FrmSnakeClassic()
        {
            InitializeComponent();
            //Default settings
            filename = "Result.txt";
            Result.readFile(filename);
            if (Result.TopScore.Count > 0)
            {
                lblHighestScore.Text = Result.TopScore[0].ToString();
            }
            else
            {
                lblHighestScore.Text = "0";
            }

            settings = new Setting();
            maps = new Map();
            //for starting the timer and setting the timer interval for tick
            GameTimer.Interval = 1000 / Settings.Speed;
            GameTimer.Tick += UpdateScreen;
            GameTimer.Start();
            StartGame();            
        }
        public static void changeBackground(Image i)
        {
            background = i;
           
          // .BackgroundImage = background;
        }
        private void StartGame()
        {
           status_l.Visible = false;
            Settings.IsGameOver = false;
            //Default settings
            setup.resetGame();
            flag = false;
            Snake.Clear();
            Shape head = new Shape { X = 0, Y = 0 };
            //default start for game
            Snake.Add(head);
            score_l.Text = Settings.Score.ToString();
            CreateFood();      
        }
        private void UpdateScreen(object sender, EventArgs e)
        {
           // highscoreLBL.Text = Highscore.GetHighScore(Settings.player1Name).ToString();

            //Check for Game Over
            if (Settings.IsGameOver)
            {
                //Check if Enter is pressed
                if (GameInput.PressedKey(Keys.Enter))
                {
                    StartGame();
                    status_l.Visible = false;
                }
            }
            else
            {            
                //if (GameInput.PressedKey(Keys.Space))
                //{
                //    Settings.IsGamePaused = !Settings.IsGamePaused;
                //    pausedLBL.Visible = !pausedLBL.Visible;
                //}
                if (GameInput.PressedKey(Keys.K))
                {
                    //do nothing
                }

                //move when unpaused
                if (!Settings.IsGamePaused)
                {
                    if ((GameInput.PressedKey(Keys.Right) || (GameInput.PressedKey(Keys.D))) &&( Settings.InGameDirection != Direction.Left))
                    {
                        Settings.InGameDirection = Direction.Right;
                    }
                    else if ((GameInput.PressedKey(Keys.Left) || (GameInput.PressedKey(Keys.A))) &&( Settings.InGameDirection != Direction.Right))
                    {
                        Settings.InGameDirection = Direction.Left;
                    }
                    else if ((GameInput.PressedKey(Keys.Up) || (GameInput.PressedKey(Keys.W))) && (Settings.InGameDirection != Direction.Down))
                    {
                        Settings.InGameDirection = Direction.Up;
                    }
                    else if ((GameInput.PressedKey(Keys.Down) || (GameInput.PressedKey(Keys.S))) &&( Settings.InGameDirection != Direction.Up))
                    {
                        Settings.InGameDirection = Direction.Down;
                    }
                    MoveSnake(Snake);
                }
            }


            canvas.Invalidate();
        }
        private void MoveSnake(List<Shape> snake)
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move the head
                if (i == 0)
                {
                    switch (Settings.InGameDirection)
                    {
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        default:
                            //do nothing
                            break;
                    }
                    //Canvas.Size: {Width = 717 Height = 590}
                    //Maximum X ,Y coordinates
                    int MaxX = canvas.Size.Width / Settings.Width; // 44
                    int MaxY = canvas.Size.Height / Settings.Height; // 36

                    //Finding whether there is collision of snake with the screen border
                    if (Snake[i].X >= MaxX || Snake[i].Y >= MaxY || Snake[i].X < 0 || Snake[i].Y < 0)
                    {
                        deathCause = "You touched the wall";
                        flag = true;
                        status_l.Visible = false;
                        die.Play();
                        GameOver();
                    }

                    // snake snake collision
                    for (int k = 1; k < Snake.Count; k++)
                    {
                        if (Snake[i].X == Snake[k].X && Snake[i].Y == Snake[k].Y)
                        {
                            deathCause = "You ate yourself";
                            status_l.Visible = false;
                            flag = true;
                            die.Play();
                            GameOver();                    
                        }
                    }

                    //eat food
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        crunch.Play();
                        EatFood();
                    }

                    if (Snake[0].X == powerup.X && snake[0].Y == powerup.Y)
                    {
                        eatPowerup("extraPoints");
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        //food spawn on canvas
        private void CreateFood()
        {
            int MaxX = canvas.Size.Width / Settings.Width;
            int MaxY = canvas.Size.Height / Settings.Height;
            Random rand = new Random();

            int x = rand.Next(0, MaxX);
            int y = rand.Next(0, MaxY);

            food = new Shape { X = x, Y = y };
            MaxX = canvas.Size.Width / Settings.Width;
            MaxY = canvas.Size.Height / Settings.Height;
            rand = new Random();
        }
        private void createPowerup()
        {
            var chance = Settings.powerupSpawnRate;
            var rng = new Random().Next(0, 100);
            if (rng < chance * 100)
            {
                int MaxX = canvas.Size.Width / Settings.Width;
                int MaxY = canvas.Size.Height / Settings.Height;
                Random rand = new Random();

                int x = rand.Next(0, MaxX);
                int y = rand.Next(0, MaxY);

                powerup = new Powerup { X = x, Y = y };
            }
        }

        private void GameOver()
        {
            Settings.IsGameOver = true;
            string score = Settings.Score.ToString(); 
            if (Result.addScore(int.Parse(score)))
            {
                Result.updateFile(filename);
            }
            // show another form to show result and current high score list?
           // MessageBox.Show("Highest score is " + Result.TopScore[0].ToString());
            lblHighestScore.Text = Result.TopScore[0].ToString();
        }

        private void EatFood()
        {
            //For adding circle to snake's body on eating the food
            Shape snake = new Shape
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y,
                //testing


            };
            Snake.Add(snake);
            //for updating the score
            Settings.Score += Settings.Points;
            score_l.Text = Settings.Score.ToString();
            // highscoreLBL.Text = Highscore.GetHighScore(Settings.player1Name).ToString();
            CreateFood();
            createPowerup();
        }
        private void eatPowerup(string p)
        {
            if (p == "extraPoints")
            {
                extraPoints.Play();
                Settings.Score += 3;
                score_l.Text = Settings.Score.ToString();
             //   highscoreLBL.Text = Highscore.GetHighScore(Settings.player1Name).ToString();
            }
            if (p == "shortenSnake")
            {
                //TODO
            }
            powerup.X = -100;
            powerup.Y = -100;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            canvas.BackgroundImage = background;
            Graphics draw = e.Graphics;
                //Draw snake's body 
            for (int i = 0; i < Snake.Count; i++)
            {
                //TODO: Add image implementation or different rendering methods
                Brush SnakeColour;
                if (i == 0) { SnakeColour = Settings.headColor; }
                else { SnakeColour = Settings.bodyColor; }
                //For drawing the snake
                if (Settings.snakeShape == "circle") { draw.FillEllipse(SnakeColour, new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height, Settings.Width, Settings.Height)); }
                else if (Settings.snakeShape == "square") { draw.FillRectangle(SnakeColour, new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height, Settings.Width, Settings.Height)); }
                //For drawing the food
                if (Settings.foodShape == "circle") { draw.FillEllipse(Settings.foodColor, new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height)); }
                else if (Settings.foodShape == "square") { draw.FillRectangle(Settings.foodColor, new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height)); }
                //draw powerup
                draw.FillRectangle(test, new Rectangle(powerup.X * Settings.Width, powerup.Y * Settings.Height, Settings.Width, Settings.Height));
            }     
            if (Settings.IsGameOver && flag == true)
            {
                message = deathCause + "\n\nYour Score is: " + Settings.Score + "\nHighe Score " + lblHighestScore.Text + "\nPress ENTER to try again";
                status_l.Text = message;
                status_l.Visible = true;
            }
        }

        private void FrmSnakeClassic_KeyDown(object sender, KeyEventArgs e)
        {
            GameInput.ChangeState(e.KeyCode, true);
        }

        private void FrmSnakeClassic_KeyUp(object sender, KeyEventArgs e)
        {
            GameInput.ChangeState(e.KeyCode, false);
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Settings.IsGamePaused = true;
            settings.ShowDialog();
        }
        private void ChangeMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.IsGamePaused = true;
            maps.ShowDialog();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pauseToolStripMenuItem.Text == "Pause Ctrl + Space")
            {
                Settings.IsGamePaused = true;
                pauseToolStripMenuItem.Text = "Resume Ctrl + Space";
                pauseToolStripMenuItem.Image = Resources.Play;
            }
            else
            {
                Settings.IsGamePaused = false;
                pauseToolStripMenuItem.Text = "Pause Ctrl + Space";
                pauseToolStripMenuItem.Image = Resources.Pause;
            } 
        }

        private void newGameCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
            pauseToolStripMenuItem.Text = "Pause Ctrl + Space";
            pauseToolStripMenuItem.Image = Resources.Pause;
        }

        private void FrmSnakeClassic_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.IsGamePaused = true;
            DialogResult result = MessageBox.Show("Are you sure quit game Snake Classic", "Quit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Settings.IsGameOver = true;
                GameOver();
                GameTimer.Dispose();
                this.Close();
            }
        }
    }
}
