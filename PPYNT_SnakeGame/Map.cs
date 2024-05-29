using PPYNT_SnakeGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPYNT_SnakeGame
{
    public partial class Map : Form
    {
        private readonly string[] maps = { "Grass", "Desert", "Gray", "White" , "Tree", "Sky"};
        private readonly Bitmap[] images = { Resources.grassBackground_01,Resources.sandBackground_01, Resources.Gray_BackGround, Resources.White_BackGround, Resources.Tree, Resources.Sky};
        private int index = 0;
        public Map()
        {
            InitializeComponent();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            FrmSnakeClassic.changeBackground(previewBox.BackgroundImage);
            GameInput.ChangeState(Keys.U, true);
            MessageBox.Show("Background has been updated, close this window to apply changes");
            this.Hide();
        }

        private void prevBTN_Click(object sender, EventArgs e)
        {
            bool atStart = index == 0;
            index = (atStart) ? maps.Length - 1 : index - 1;
            previewBox.BackgroundImage = images[index];
            lblMap.Text = "Map: " + maps[index];
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            bool atEnd = index == maps.Length - 1;
            index = (atEnd) ? index = 0 : index + 1;
            previewBox.BackgroundImage = images[index];
            lblMap.Text = "Map: " + maps[index];
        }
    }
}
