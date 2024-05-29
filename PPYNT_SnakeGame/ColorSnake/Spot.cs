using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPYNT_SnakeGame.ColorSnake
{
    internal class Spot
    {
        int x;
        int y;
        Color pColor;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Color PColor
        {
            get { return pColor; }
            set { pColor = value; }
        }
        public Spot()
        {
            x = 0; y = 0; pColor = Color.Black;
        }
        public Spot(int x, int y, Color pColor)
        {
            this.x = x; this.y = y; this.pColor = pColor;
        }
    }
}
