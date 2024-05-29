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
    public partial class UseColorSnake : Form
    {
        public UseColorSnake()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            FrmColorSnake frmColorSnake = new FrmColorSnake();
            this.Close();
            frmColorSnake.ShowDialog();   
        }
    }
}
