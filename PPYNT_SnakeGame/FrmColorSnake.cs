using PPYNT_SnakeGame.ColorSnake;
using PPYNT_SnakeGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPYNT_SnakeGame
{
    public partial class FrmColorSnake : Form
    {
        Snake snake;
        Food normalFood;
        Spot colorChangingFood;
        int score;
        int width;
        int height;
        int size;
        bool lose1, lose2;
        string filename;
        System.Media.SoundPlayer crunch = new System.Media.SoundPlayer(Resources.crunch);
        System.Media.SoundPlayer die = new System.Media.SoundPlayer(Resources.The_Game_Over_1);
        System.Media.SoundPlayer extraPoints = new System.Media.SoundPlayer(Resources.powerup);
        public FrmColorSnake()
        {
            InitializeComponent();
            size = 15;
            width = pbPlay.Size.Width / size;
            if (pbPlay.Size.Width % size != 0) width--;
            height = pbPlay.Size.Height / size;
            if (pbPlay.Size.Height % size != 0) height--;
            lose1 = false; lose2 = false;
            filename = "Result.txt";
            Result.readFile(filename);
            lblRScore.Text = "0";
            if (Result.TopScore.Count > 0)
            {
                lblRHighestScore.Text = Result.TopScore[0].ToString();
            }
            else
            {
                lblRHighestScore.Text = "0";
            }
        }
        private bool coincideWColorChangingFood(Spot s)
        {
            return s.X >= colorChangingFood.X && s.X <= colorChangingFood.X + 1
                && s.Y >= colorChangingFood.Y && s.Y <= colorChangingFood.Y + 1;
        }

        private bool foodCoincident()
        {
            for (int i = 0; i < normalFood.Red.Count; i++)
            {
                if (coincideWColorChangingFood(normalFood.Red[i]))
                {
                    return true;
                }
            }
            for (int i = 0; i < normalFood.Green.Count; i++)
            {
                if (coincideWColorChangingFood(normalFood.Green[i]))
                {
                    return true;
                }
            }
            for (int i = 0; i < normalFood.Blue.Count; i++)
            {
                if (coincideWColorChangingFood(normalFood.Blue[i]))
                {
                    return true;
                }
            }
            for (int i = 0; i < normalFood.Yellow.Count; i++)
            {
                if (coincideWColorChangingFood(normalFood.Yellow[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private void pbPlay_Paint(object sender, PaintEventArgs e)
        {
            // draw snake's head
            e.Graphics.FillEllipse(new SolidBrush(snake.SColor),
               new Rectangle(snake.Body[0].X * size, snake.Body[0].Y * size, size, size));
            // draw snake's body
            for (int i = 1; i < snake.Body.Count; i++)
            {
                e.Graphics.FillRectangle(new SolidBrush(snake.SColor),
                    new Rectangle(snake.Body[i].X * size, snake.Body[i].Y * size, size, size));
            }
            // draw normal food
            for (int i = 0; i < normalFood.Red.Count; i++)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.Red),
                    new Rectangle(normalFood.Red[i].X * size, normalFood.Red[i].Y * size, size, size));
            }
            for (int i = 0; i < normalFood.Green.Count; i++)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.Green),
                    new Rectangle(normalFood.Green[i].X * size, normalFood.Green[i].Y * size, size, size));
            }
            for (int i = 0; i < normalFood.Blue.Count; i++)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.Blue),
                    new Rectangle(normalFood.Blue[i].X * size, normalFood.Blue[i].Y * size, size, size));
            }
            for (int i = 0; i < normalFood.Yellow.Count; i++)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.Yellow),
                    new Rectangle(normalFood.Yellow[i].X * size, normalFood.Yellow[i].Y * size, size, size));
            }
            // draw color changing food
            e.Graphics.FillEllipse(new SolidBrush(colorChangingFood.PColor),
                new Rectangle(colorChangingFood.X * size, colorChangingFood.Y * size,
                size * 2, size * 2));
        }

        private void timerSnake_Tick(object sender, EventArgs e)
        {
            // snake moving
            lose1 = !snake.move(width, height);
            // snake eating food
            lose2 = !snake.eatFood(normalFood, ref score);
            if (!lose2)
            {
                extraPoints.Play();
                updateScore();
            }
            if (normalFood.runOutOf1Color())
            {
                normalFood.generate(width, height);
            }
            // snake changing color
            if (coincideWColorChangingFood(snake.Body[0]))
            {
                if (snake.SColor == colorChangingFood.PColor)
                {
                    crunch.Play();
                    score += 3;
                    updateScore();
                }
                snake.changeColor(colorChangingFood.PColor);
                Random rnd = new Random();
                do
                {
                    colorChangingFood = new Spot(rnd.Next(width - 1),
                        rnd.Next(height - 1), RandomColor.getRandomColor());
                } while (foodCoincident());
            }
            pbPlay.Invalidate();
            // game over
            if (lose1 || lose2)
            {
                die.Play();
                gameOver();
            }
        }
        private void gameOver()
        {
            timerSnake.Stop();
            MessageBox.Show("Game over!");
            if (Result.addScore(score))
            {
                Result.updateFile(filename);
            }
            // show another form to show result and current high score list?
            MessageBox.Show("Highest score is " + Result.TopScore[0].ToString());
            lblRHighestScore.Text = Result.TopScore[0].ToString();
        }

        private void FrmColorSnake_KeyDown(object sender, KeyEventArgs e)
        {
            snake.changeDirection(e.KeyCode);
        }
        
        private void newGame()
        {
            score = 0;
            List<Spot> body = new List<Spot>
            {
                new Spot(10, 10, Color.Black),
                new Spot(11, 10, Color.Black),
                new Spot(12, 10, Color.Black)
            };
            snake = new Snake(body, Color.Black, "left");
            normalFood = new Food();
            normalFood.generate(width, height);
            Random rnd = new Random();
            do
            {
                colorChangingFood = new Spot(rnd.Next(width - 1),
                    rnd.Next(height - 1), RandomColor.getRandomColor());
            } while (foodCoincident());
            timerSnake.Enabled = true;
        }

        private void FrmColorSnake_Load(object sender, EventArgs e)
        {
            newGame();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pauseToolStripMenuItem.Text == "Pause Ctrl + Space")
            {
                timerSnake.Enabled = false;
                pauseToolStripMenuItem.Text = "Resume Ctrl + Space";
                pauseToolStripMenuItem.Image = Resources.Play;
            }
            else
            {
                timerSnake.Enabled = true;
                pauseToolStripMenuItem.Text = "Pause Ctrl + Space";
                pauseToolStripMenuItem.Image = Resources.Pause;
            }  
        }
        private void closeCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerSnake.Stop();
            DialogResult result = MessageBox.Show("Are you sure quit game Color Snake?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                gameOver();
                this.Close();
            }
        }

        private void updateScore()
        {
            lblRScore.Text = score.ToString();
        }
    }
}
