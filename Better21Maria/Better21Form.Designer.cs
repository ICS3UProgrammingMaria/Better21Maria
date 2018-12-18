namespace Better21Maria
{
    partial class frmBetter21
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
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStay = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.lblPTitle = new System.Windows.Forms.Label();
            this.lblDTitle = new System.Windows.Forms.Label();
            this.lblPlayerValue = new System.Windows.Forms.Label();
            this.lblDealerValue = new System.Windows.Forms.Label();
            this.picCardp1 = new System.Windows.Forms.PictureBox();
            this.picCardp3 = new System.Windows.Forms.PictureBox();
            this.picCardp2 = new System.Windows.Forms.PictureBox();
            this.picCardd3 = new System.Windows.Forms.PictureBox();
            this.picCardd1 = new System.Windows.Forms.PictureBox();
            this.picCardd2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCardp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardd2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Monotxt_IV50", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(491, 237);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 37);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnStay
            // 
            this.btnStay.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(675, 360);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(90, 49);
            this.btnStay.TabIndex = 2;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(319, 360);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(90, 49);
            this.btnHit.TabIndex = 3;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            // 
            // lblPTitle
            // 
            this.lblPTitle.AutoSize = true;
            this.lblPTitle.BackColor = System.Drawing.Color.ForestGreen;
            this.lblPTitle.Font = new System.Drawing.Font("Monotxt_IV50", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPTitle.Location = new System.Drawing.Point(312, 96);
            this.lblPTitle.Name = "lblPTitle";
            this.lblPTitle.Size = new System.Drawing.Size(108, 26);
            this.lblPTitle.TabIndex = 4;
            this.lblPTitle.Text = "Player";
            // 
            // lblDTitle
            // 
            this.lblDTitle.AutoSize = true;
            this.lblDTitle.BackColor = System.Drawing.Color.ForestGreen;
            this.lblDTitle.Font = new System.Drawing.Font("Monotxt_IV50", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDTitle.Location = new System.Drawing.Point(665, 96);
            this.lblDTitle.Name = "lblDTitle";
            this.lblDTitle.Size = new System.Drawing.Size(108, 26);
            this.lblDTitle.TabIndex = 5;
            this.lblDTitle.Text = "Dealer";
            // 
            // lblPlayerValue
            // 
            this.lblPlayerValue.AutoSize = true;
            this.lblPlayerValue.Location = new System.Drawing.Point(332, 436);
            this.lblPlayerValue.Name = "lblPlayerValue";
            this.lblPlayerValue.Size = new System.Drawing.Size(66, 13);
            this.lblPlayerValue.TabIndex = 6;
            this.lblPlayerValue.Text = "Player Value";
            // 
            // lblDealerValue
            // 
            this.lblDealerValue.AutoSize = true;
            this.lblDealerValue.Location = new System.Drawing.Point(685, 436);
            this.lblDealerValue.Name = "lblDealerValue";
            this.lblDealerValue.Size = new System.Drawing.Size(68, 13);
            this.lblDealerValue.TabIndex = 7;
            this.lblDealerValue.Text = "Dealer Value";
            // 
            // picCardp1
            // 
            this.picCardp1.Location = new System.Drawing.Point(239, 128);
            this.picCardp1.Name = "picCardp1";
            this.picCardp1.Size = new System.Drawing.Size(87, 101);
            this.picCardp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCardp1.TabIndex = 8;
            this.picCardp1.TabStop = false;
            // 
            // picCardp3
            // 
            this.picCardp3.Location = new System.Drawing.Point(319, 237);
            this.picCardp3.Name = "picCardp3";
            this.picCardp3.Size = new System.Drawing.Size(87, 101);
            this.picCardp3.TabIndex = 9;
            this.picCardp3.TabStop = false;
            // 
            // picCardp2
            // 
            this.picCardp2.Location = new System.Drawing.Point(407, 128);
            this.picCardp2.Name = "picCardp2";
            this.picCardp2.Size = new System.Drawing.Size(87, 101);
            this.picCardp2.TabIndex = 10;
            this.picCardp2.TabStop = false;
            // 
            // picCardd3
            // 
            this.picCardd3.Location = new System.Drawing.Point(752, 237);
            this.picCardd3.Name = "picCardd3";
            this.picCardd3.Size = new System.Drawing.Size(87, 103);
            this.picCardd3.TabIndex = 13;
            this.picCardd3.TabStop = false;
            // 
            // picCardd1
            // 
            this.picCardd1.Location = new System.Drawing.Point(675, 128);
            this.picCardd1.Name = "picCardd1";
            this.picCardd1.Size = new System.Drawing.Size(87, 101);
            this.picCardd1.TabIndex = 12;
            this.picCardd1.TabStop = false;
            // 
            // picCardd2
            // 
            this.picCardd2.Location = new System.Drawing.Point(598, 237);
            this.picCardd2.Name = "picCardd2";
            this.picCardd2.Size = new System.Drawing.Size(87, 103);
            this.picCardd2.TabIndex = 11;
            this.picCardd2.TabStop = false;
            // 
            // frmBetter21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Better21Maria.Properties.Resources.live_casino9;
            this.ClientSize = new System.Drawing.Size(968, 521);
            this.Controls.Add(this.picCardd3);
            this.Controls.Add(this.picCardd1);
            this.Controls.Add(this.picCardd2);
            this.Controls.Add(this.picCardp2);
            this.Controls.Add(this.picCardp3);
            this.Controls.Add(this.picCardp1);
            this.Controls.Add(this.lblDealerValue);
            this.Controls.Add(this.lblPlayerValue);
            this.Controls.Add(this.lblDTitle);
            this.Controls.Add(this.lblPTitle);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBetter21";
            this.Text = "Better 21";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCardp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardd2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Label lblPTitle;
        private System.Windows.Forms.Label lblDTitle;
        private System.Windows.Forms.Label lblPlayerValue;
        private System.Windows.Forms.Label lblDealerValue;
        private System.Windows.Forms.PictureBox picCardp1;
        private System.Windows.Forms.PictureBox picCardp3;
        private System.Windows.Forms.PictureBox picCardp2;
        private System.Windows.Forms.PictureBox picCardd3;
        private System.Windows.Forms.PictureBox picCardd1;
        private System.Windows.Forms.PictureBox picCardd2;
    }
}

