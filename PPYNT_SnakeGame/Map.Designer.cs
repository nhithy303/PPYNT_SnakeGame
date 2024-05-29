namespace PPYNT_SnakeGame
{
    partial class Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.updateBTN = new System.Windows.Forms.Button();
            this.nextBTN = new System.Windows.Forms.Button();
            this.prevBTN = new System.Windows.Forms.Button();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.lblMap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.Honeydew;
            this.updateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.updateBTN.Location = new System.Drawing.Point(335, 567);
            this.updateBTN.Margin = new System.Windows.Forms.Padding(4);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(158, 54);
            this.updateBTN.TabIndex = 10;
            this.updateBTN.Text = "&Update";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // nextBTN
            // 
            this.nextBTN.BackColor = System.Drawing.Color.Honeydew;
            this.nextBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nextBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBTN.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nextBTN.Location = new System.Drawing.Point(477, 508);
            this.nextBTN.Margin = new System.Windows.Forms.Padding(4);
            this.nextBTN.Name = "nextBTN";
            this.nextBTN.Size = new System.Drawing.Size(168, 51);
            this.nextBTN.TabIndex = 9;
            this.nextBTN.Text = "&Next ►";
            this.nextBTN.UseVisualStyleBackColor = false;
            this.nextBTN.Click += new System.EventHandler(this.nextBTN_Click);
            // 
            // prevBTN
            // 
            this.prevBTN.BackColor = System.Drawing.Color.Honeydew;
            this.prevBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.prevBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevBTN.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.prevBTN.Location = new System.Drawing.Point(211, 508);
            this.prevBTN.Margin = new System.Windows.Forms.Padding(4);
            this.prevBTN.Name = "prevBTN";
            this.prevBTN.Size = new System.Drawing.Size(175, 51);
            this.prevBTN.TabIndex = 8;
            this.prevBTN.Text = "◄&Previous";
            this.prevBTN.UseVisualStyleBackColor = false;
            this.prevBTN.Click += new System.EventHandler(this.prevBTN_Click);
            // 
            // previewBox
            // 
            this.previewBox.BackgroundImage = global::PPYNT_SnakeGame.Properties.Resources.grassBackground_01;
            this.previewBox.Location = new System.Drawing.Point(13, 8);
            this.previewBox.Margin = new System.Windows.Forms.Padding(4);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(632, 492);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewBox.TabIndex = 6;
            this.previewBox.TabStop = false;
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMap.Location = new System.Drawing.Point(12, 553);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(168, 37);
            this.lblMap.TabIndex = 11;
            this.lblMap.Text = "Map: Grass";
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(658, 630);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.nextBTN);
            this.Controls.Add(this.prevBTN);
            this.Controls.Add(this.previewBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button nextBTN;
        private System.Windows.Forms.Button prevBTN;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Label lblMap;
    }
}