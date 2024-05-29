using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPYNT_SnakeGame.ColorSnake
{
    internal class RandomColor
    {
        public static Color getRandomColor()
        {
            Random rnd = new Random();
            int index = rnd.Next(4);
            return getColor(index);
        }
        public static Color getColor(int index)
        {
            if (index == 0) return Color.Red;
            if (index == 1) return Color.Green;
            if (index == 2) return Color.Blue;
            if (index == 3) return Color.Yellow;
            return Color.Black;
        }
    }
}
