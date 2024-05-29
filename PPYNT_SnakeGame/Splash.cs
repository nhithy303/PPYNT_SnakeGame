using PPYNT_SnakeGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPYNT_SnakeGame
{
    public partial class Splash : Form
    {
        SoundPlayer player = new SoundPlayer(Resources.nhac);
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }
        int startP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 2;
            MyProgress.Value = startP;
            lblPercent.Text = startP.ToString() + "%";
            if (MyProgress.Value == 100)
            {
                startP = 0;
                FrmMenu menu = new FrmMenu();
                menu.Show();
                this.Hide();
                timer1.Stop();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            player.PlayLooping();
        }
    }
}
