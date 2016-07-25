namespace puush_installer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.pbPuushHeader = new System.Windows.Forms.PictureBox();
            this.pbShareXHeader = new System.Windows.Forms.PictureBox();
            this.lblProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPuushHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShareXHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(0, 140);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblInfo.Size = new System.Drawing.Size(387, 104);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(8, 408);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(368, 32);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(8, 408);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(368, 32);
            this.pbProgress.TabIndex = 0;
            this.pbProgress.Visible = false;
            // 
            // pbPuushHeader
            // 
            this.pbPuushHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbPuushHeader.Image = global::puush_installer.Properties.Resources.puush_header;
            this.pbPuushHeader.Location = new System.Drawing.Point(0, 0);
            this.pbPuushHeader.Name = "pbPuushHeader";
            this.pbPuushHeader.Size = new System.Drawing.Size(387, 132);
            this.pbPuushHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPuushHeader.TabIndex = 0;
            this.pbPuushHeader.TabStop = false;
            // 
            // pbShareXHeader
            // 
            this.pbShareXHeader.Image = global::puush_installer.Properties.Resources.ShareX_header;
            this.pbShareXHeader.Location = new System.Drawing.Point(0, 248);
            this.pbShareXHeader.Name = "pbShareXHeader";
            this.pbShareXHeader.Size = new System.Drawing.Size(387, 152);
            this.pbShareXHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShareXHeader.TabIndex = 3;
            this.pbShareXHeader.TabStop = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(16, 416);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 16);
            this.lblProgress.TabIndex = 4;
            this.lblProgress.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbPuushHeader);
            this.Controls.Add(this.pbShareXHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "puush install";
            ((System.ComponentModel.ISupportInitialize)(this.pbPuushHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShareXHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPuushHeader;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbShareXHeader;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lblProgress;
    }
}

