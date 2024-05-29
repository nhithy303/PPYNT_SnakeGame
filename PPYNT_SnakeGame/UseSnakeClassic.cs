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
    public partial class UseSnakeClassic : Form
    {
        public UseSnakeClassic()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            FrmSnakeClassic frmSnakeClassic = new FrmSnakeClassic();
            this.Close();
            frmSnakeClassic.ShowDialog();
        }
    }
}
