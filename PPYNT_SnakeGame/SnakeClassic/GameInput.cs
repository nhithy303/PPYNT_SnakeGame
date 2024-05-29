using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPYNT_SnakeGame
{
    internal class GameInput
    {
        private static Hashtable KeyTable = new Hashtable();

        public static void ChangeState(Keys key, bool state)
        {
            KeyTable[key] = state;
        }

        public static bool PressedKey(Keys key)
        {
            return (KeyTable[key] == null) ? false : (bool)KeyTable[key];
        }
    }
}
