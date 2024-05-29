using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using PPYNT_SnakeGame.Properties;
using PPYNT_SnakeGame.ColorSnake;

namespace PPYNT_SnakeGame
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void btnInfoProject_Click(object sender, EventArgs e)
        {
            InfoProject info = new InfoProject();
            info.ShowDialog();
        }

        private void btnSnakeClassic_Click(object sender, EventArgs e)
        {
            UseSnakeClassic useSnakeClassic = new UseSnakeClassic();
            Result.TopScore.Clear();
            useSnakeClassic.ShowDialog();
        }
        SoundPlayer player = new SoundPlayer(Resources.nhac);
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            player.PlayLooping();
        }
        private void btnColorSnake_Click(object sender, EventArgs e)
        {
            UseColorSnake useColorSnake = new UseColorSnake();
            useColorSnake.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Are you sure Quit Game?", "Quit Game.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.No)
            {
                
            }
            else Application.Exit();
        }
    }
}
