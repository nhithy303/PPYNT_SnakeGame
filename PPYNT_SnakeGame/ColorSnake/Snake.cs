using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPYNT_SnakeGame.ColorSnake
{
    internal class Snake
    {
        List<Spot> body;
        Color sColor;
        string direction;
        public List<Spot> Body
        {
            get { return body; }
            set { body = value; }
        }
        public Color SColor
        {
            get { return sColor; }
            set { sColor = value; }
        }
        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }
        public Snake(List<Spot> body, Color sColor, string direction)
        {
            this.body = new List<Spot>(body);
            this.sColor = sColor;
            this.direction = direction;
        }
        public void changeDirection(Keys key)
        {
            if ((key == Keys.W || key == Keys.Up) && direction != "down")
            {
                direction = "up";
            }
            else if ((key == Keys.S || key == Keys.Down) && direction != "up")
            {
                direction = "down";
            }
            else if ((key == Keys.A || key == Keys.Left) && direction != "right")
            {
                direction = "left";
            }
            else if ((key == Keys.D || key == Keys.Right) && direction != "left")
            {
                direction = "right";
            }
        }

        public bool move(int width, int height)
        {
            // snake's body
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
            }
            // snake's head
            switch (direction)
            {
                case "up":
                    body[0].Y--;
                    break;
                case "down":
                    body[0].Y++;
                    break;
                case "left":
                    body[0].X--;
                    break;
                case "right":
                    body[0].X++;
                    break;
            }
            if (body[0].X < 0)
            {
                body[0].X = width;
            }
            if (body[0].X > width)
            {
                body[0].X = 0;
            }
            if (body[0].Y < 0)
            {
                body[0].Y = height;
            }
            if (body[0].Y > height)
            {
                body[0].Y = 0;
            }
            // snake biting itself
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0].X == body[i].X && body[0].Y == body[i].Y)
                {
                    return false;
                }
            }
            return true;
        }
        public bool eatFood(Food normalfood, ref int score)
        {

            string found = normalfood.findSpot(body[0]);
            if (found != "")
            {
                string foodColor = found.Substring(0, found.IndexOf(','));
                string snakeColor;
                if (sColor == Color.Red)
                {
                    snakeColor = "Red";
                }
                else if (sColor == Color.Green)
                {
                    snakeColor = "Green";
                }
                else if (sColor == Color.Blue)
                {
                    snakeColor = "Blue";
                }
                else if (sColor == Color.Yellow)
                {
                    snakeColor = "Yellow";
                }
                else
                {
                    snakeColor = "Black";
                }
                if (foodColor == snakeColor)
                {
                    body.Add(new Spot(body.Last().X, body.Last().Y, sColor));
                    // delete food
                    normalfood.foodIsEaten(found);
                    score++;
                    return true;
                }
                return false;
            }
            return true;
        }
        public void changeColor(Color newColor)
        {
            sColor = newColor;
        }
    }
}

