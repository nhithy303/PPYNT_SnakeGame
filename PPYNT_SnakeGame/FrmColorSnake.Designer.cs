namespace PPYNT_SnakeGame
{
    partial class FrmColorSnake
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColorSnake));
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.lblRHighestScore = new System.Windows.Forms.Label();
            this.lblRScore = new System.Windows.Forms.Label();
            this.lblHighestScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblColorSnake = new System.Windows.Forms.Label();
            this.timerSnake = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlay
            // 
            this.pbPlay.BackColor = System.Drawing.Color.RosyBrown;
            this.pbPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlay.Location = new System.Drawing.Point(0, 42);
            this.pbPlay.Margin = new System.Windows.Forms.Padding(5);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(779, 627);
            this.pbPlay.TabIndex = 19;
            this.pbPlay.TabStop = false;
            this.pbPlay.Paint += new System.Windows.Forms.PaintEventHandler(this.pbPlay_Paint);
            // 
            // lblRHighestScore
            // 
            this.lblRHighestScore.AutoSize = true;
            this.lblRHighestScore.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRHighestScore.Location = new System.Drawing.Point(179, 84);
            this.lblRHighestScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRHighestScore.Name = "lblRHighestScore";
            this.lblRHighestScore.Size = new System.Drawing.Size(23, 26);
            this.lblRHighestScore.TabIndex = 18;
            this.lblRHighestScore.Text = "0";
            this.lblRHighestScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRScore
            // 
            this.lblRScore.AutoSize = true;
            this.lblRScore.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRScore.Location = new System.Drawing.Point(179, 47);
            this.lblRScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRScore.Name = "lblRScore";
            this.lblRScore.Size = new System.Drawing.Size(23, 26);
            this.lblRScore.TabIndex = 16;
            this.lblRScore.Text = "0";
            this.lblRScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHighestScore
            // 
            this.lblHighestScore.AutoSize = true;
            this.lblHighestScore.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHighestScore.Location = new System.Drawing.Point(16, 84);
            this.lblHighestScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighestScore.Name = "lblHighestScore";
            this.lblHighestScore.Size = new System.Drawing.Size(142, 26);
            this.lblHighestScore.TabIndex = 17;
            this.lblHighestScore.Text = "Highest score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblScore.Location = new System.Drawing.Point(16, 47);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(71, 26);
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "Score:";
            // 
            // lblColorSnake
            // 
            this.lblColorSnake.AutoSize = true;
            this.lblColorSnake.BackColor = System.Drawing.Color.Transparent;
            this.lblColorSnake.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorSnake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblColorSnake.Location = new System.Drawing.Point(781, 41);
            this.lblColorSnake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColorSnake.Name = "lblColorSnake";
            this.lblColorSnake.Size = new System.Drawing.Size(341, 152);
            this.lblColorSnake.TabIndex = 10;
            this.lblColorSnake.Text = "Color\n      Snake";
            // 
            // timerSnake
            // 
            this.timerSnake.Interval = 50;
            this.timerSnake.Tick += new System.EventHandler(this.timerSnake_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.closeCtrlCToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1123, 41);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.newGameToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.newGameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newGameToolStripMenuItem.Image")));
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(271, 37);
            this.newGameToolStripMenuItem.Text = "&New Game Ctrl + N";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pauseToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.pauseToolStripMenuItem.Image = global::PPYNT_SnakeGame.Properties.Resources.Pause;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(261, 37);
            this.pauseToolStripMenuItem.Text = "&Pause Ctrl + Space";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // closeCtrlCToolStripMenuItem
            // 
            this.closeCtrlCToolStripMenuItem.Image = global::PPYNT_SnakeGame.Properties.Resources.Quit;
            this.closeCtrlCToolStripMenuItem.Name = "closeCtrlCToolStripMenuItem";
            this.closeCtrlCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.closeCtrlCToolStripMenuItem.Size = new System.Drawing.Size(213, 37);
            this.closeCtrlCToolStripMenuItem.Text = "Close Ctrl + C";
            this.closeCtrlCToolStripMenuItem.Click += new System.EventHandler(this.closeCtrlCToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(this.lblHighestScore);
            this.groupBox1.Controls.Add(this.lblRHighestScore);
            this.groupBox1.Controls.Add(this.lblRScore);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(815, 204);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(296, 140);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPYNT_SnakeGame.Properties.Resources.SnakeOrange;
            this.pictureBox1.Location = new System.Drawing.Point(986, 546);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PPYNT_SnakeGame.Properties.Resources.SnakeGreen;
            this.pictureBox2.Location = new System.Drawing.Point(794, 388);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // FrmColorSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1123, 676);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbPlay);
            this.Controls.Add(this.lblColorSnake);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmColorSnake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Snake";
            this.Load += new System.EventHandler(this.FrmColorSnake_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmColorSnake_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.Label lblRHighestScore;
        private System.Windows.Forms.Label lblRScore;
        private System.Windows.Forms.Label lblHighestScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblColorSnake;
        private System.Windows.Forms.Timer timerSnake;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem closeCtrlCToolStripMenuItem;
    }
}