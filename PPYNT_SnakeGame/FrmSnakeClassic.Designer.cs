namespace PPYNT_SnakeGame
{
    partial class FrmSnakeClassic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSnakeClassic));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.score_l = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHighestScore = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.pausedLBL = new System.Windows.Forms.Label();
            this.status_l = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // score_l
            // 
            this.score_l.AutoSize = true;
            this.score_l.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.score_l.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.score_l.Location = new System.Drawing.Point(91, 30);
            this.score_l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score_l.Name = "score_l";
            this.score_l.Size = new System.Drawing.Size(31, 33);
            this.score_l.TabIndex = 2;
            this.score_l.Text = "  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(18)))), ((int)(((byte)(137)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(776, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Snake Game";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameCtrlNToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.ChangeMapToolStripMenuItem,
            this.pauseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 34);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameCtrlNToolStripMenuItem
            // 
            this.newGameCtrlNToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.newGameCtrlNToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.newGameCtrlNToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newGameCtrlNToolStripMenuItem.Image")));
            this.newGameCtrlNToolStripMenuItem.Name = "newGameCtrlNToolStripMenuItem";
            this.newGameCtrlNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameCtrlNToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.newGameCtrlNToolStripMenuItem.Text = "New Game Ctrl + N";
            this.newGameCtrlNToolStripMenuItem.Click += new System.EventHandler(this.newGameCtrlNToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.OliveDrab;
            this.closeToolStripMenuItem.Image = global::PPYNT_SnakeGame.Properties.Resources.Quit;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.closeToolStripMenuItem.ShowShortcutKeys = false;
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.closeToolStripMenuItem.Text = "Close Ctrl + C";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.settingToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.settingToolStripMenuItem.Image = global::PPYNT_SnakeGame.Properties.Resources.Setting;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.settingToolStripMenuItem.ShowShortcutKeys = false;
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.settingToolStripMenuItem.Text = "Setting Ctrl + S";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // ChangeMapToolStripMenuItem
            // 
            this.ChangeMapToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChangeMapToolStripMenuItem.ForeColor = System.Drawing.Color.Olive;
            this.ChangeMapToolStripMenuItem.Image = global::PPYNT_SnakeGame.Properties.Resources.ChangeMap;
            this.ChangeMapToolStripMenuItem.Name = "ChangeMapToolStripMenuItem";
            this.ChangeMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.ChangeMapToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.ChangeMapToolStripMenuItem.Text = "Change Map  Ctrl + M";
            this.ChangeMapToolStripMenuItem.Click += new System.EventHandler(this.ChangeMapToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pauseToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.pauseToolStripMenuItem.Image = global::PPYNT_SnakeGame.Properties.Resources.Pause;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(221, 30);
            this.pauseToolStripMenuItem.Text = "Pause Ctrl + Space";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblHighestScore);
            this.groupBox1.Controls.Add(this.score_l);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(728, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 138);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(10, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Highest Score:";
            // 
            // lblHighestScore
            // 
            this.lblHighestScore.AutoSize = true;
            this.lblHighestScore.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lblHighestScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHighestScore.Location = new System.Drawing.Point(166, 87);
            this.lblHighestScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighestScore.Name = "lblHighestScore";
            this.lblHighestScore.Size = new System.Drawing.Size(31, 33);
            this.lblHighestScore.TabIndex = 2;
            this.lblHighestScore.Text = "  ";
            // 
            // canvas
            // 
            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.canvas.BackgroundImage = global::PPYNT_SnakeGame.Properties.Resources.grassBackground_01;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Cursor = System.Windows.Forms.Cursors.Default;
            this.canvas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.canvas.InitialImage = null;
            this.canvas.Location = new System.Drawing.Point(4, 50);
            this.canvas.Margin = new System.Windows.Forms.Padding(4);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(717, 590);
            this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.canvas.TabIndex = 13;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // pausedLBL
            // 
            this.pausedLBL.AutoSize = true;
            this.pausedLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pausedLBL.Font = new System.Drawing.Font("Lucida Sans", 15.75F);
            this.pausedLBL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pausedLBL.Location = new System.Drawing.Point(243, 346);
            this.pausedLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pausedLBL.Name = "pausedLBL";
            this.pausedLBL.Size = new System.Drawing.Size(106, 32);
            this.pausedLBL.TabIndex = 14;
            this.pausedLBL.Text = "Paused";
            this.pausedLBL.Visible = false;
            // 
            // status_l
            // 
            this.status_l.AutoSize = true;
            this.status_l.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.status_l.Font = new System.Drawing.Font("Lucida Sans", 15.75F);
            this.status_l.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.status_l.Location = new System.Drawing.Point(46, 215);
            this.status_l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status_l.Name = "status_l";
            this.status_l.Size = new System.Drawing.Size(95, 32);
            this.status_l.TabIndex = 13;
            this.status_l.Text = "Status";
            this.status_l.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPYNT_SnakeGame.Properties.Resources.SnakeOrange;
            this.pictureBox1.Location = new System.Drawing.Point(769, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PPYNT_SnakeGame.Properties.Resources.SnakeGreen;
            this.pictureBox2.Location = new System.Drawing.Point(848, 519);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // FrmSnakeClassic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1050, 661);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pausedLBL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.status_l);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmSnakeClassic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Classic";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSnakeClassic_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmSnakeClassic_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox canvas;
        public System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label score_l;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHighestScore;
        private System.Windows.Forms.Label pausedLBL;
        private System.Windows.Forms.Label status_l;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}