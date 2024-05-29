using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPYNT_SnakeGame.ColorSnake
{
    internal class Food
    {
        List<Spot> red;
        List<Spot> green;
        List<Spot> blue;
        List<Spot> yellow;
        public List<Spot> Red
        {
            get { return red; }
            set { red = value; }
        }
        public List<Spot> Green
        {
            get { return green; }
            set { green = value; }
        }
        public List<Spot> Blue
        {
            get { return blue; }
            set { blue = value; }
        }
        public List<Spot> Yellow
        {
            get { return yellow; }
            set { yellow = value; }
        }
        public Food()
        {
            red = new List<Spot>();
            green = new List<Spot>();
            blue = new List<Spot>();
            yellow = new List<Spot>();
        }
        public void generate(int width, int height)
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                red.Add(new Spot(rnd.Next(width + 1), rnd.Next(height + 1), Color.Red));
                green.Add(new Spot(rnd.Next(width + 1), rnd.Next(height + 1), Color.Green));
                blue.Add(new Spot(rnd.Next(width + 1), rnd.Next(height + 1), Color.Blue));
                yellow.Add(new Spot(rnd.Next(width + 1), rnd.Next(height + 1), Color.Yellow));
            }
        }
        public bool runOutOf1Color()
        {
            return red.Count == 0 || green.Count == 0 || blue.Count == 0 || yellow.Count == 0;
        }
        public string findSpot(Spot s) // format: "Color,index"
        {
            int index = -1;
            index = red.FindIndex(t => t.X == s.X && t.Y == s.Y);
            if (index >= 0)
            {
                return "Red," + index.ToString();
            }
            index = green.FindIndex(t => t.X == s.X && t.Y == s.Y);
            if (index >= 0)
            {
                return "Green," + index.ToString();
            }
            index = blue.FindIndex(t => t.X == s.X && t.Y == s.Y);
            if (index >= 0)
            {
                return "Blue," + index.ToString();
            }
            index = yellow.FindIndex(t => t.X == s.X && t.Y == s.Y);
            if (index >= 0)
            {
                return "Yellow," + index.ToString();
            }
            return "";
        }
        public void foodIsEaten(string s) // format: "Color,index"
        {
            string foodColor = s.Substring(0, s.IndexOf(','));
            int index = int.Parse(s.Substring(s.IndexOf(',') + 1));
            switch (foodColor)
            {
                case "Red":
                    red.RemoveAt(index); break;
                case "Green":
                    green.RemoveAt(index); break;
                case "Blue":
                    blue.RemoveAt(index); break;
                case "Yellow":
                    yellow.RemoveAt(index); break;
            }
        }
    }
}
