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
            this.pbShareXHeader = new System.Windows.Forms.PictureBox();
            this.pbPuushHeader = new System.Windows.Forms.PictureBox();
            this.pStart = new System.Windows.Forms.Panel();
            this.pDownload = new System.Windows.Forms.Panel();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbShareXHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPuushHeader)).BeginInit();
            this.pStart.SuspendLayout();
            this.pDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(6, 144);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(375, 108);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Location = new System.Drawing.Point(108, 36);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(173, 60);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbShareXHeader
            // 
            this.pbShareXHeader.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbShareXHeader.Image = global::puush_installer.Properties.Resources.ShareX_1024;
            this.pbShareXHeader.Location = new System.Drawing.Point(0, 264);
            this.pbShareXHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbShareXHeader.Name = "pbShareXHeader";
            this.pbShareXHeader.Size = new System.Drawing.Size(387, 106);
            this.pbShareXHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShareXHeader.TabIndex = 3;
            this.pbShareXHeader.TabStop = false;
            // 
            // pbPuushHeader
            // 
            this.pbPuushHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbPuushHeader.Image = global::puush_installer.Properties.Resources.puush_header;
            this.pbPuushHeader.InitialImage = global::puush_installer.Properties.Resources.puush_header;
            this.pbPuushHeader.Location = new System.Drawing.Point(0, 0);
            this.pbPuushHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPuushHeader.Name = "pbPuushHeader";
            this.pbPuushHeader.Size = new System.Drawing.Size(387, 132);
            this.pbPuushHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPuushHeader.TabIndex = 0;
            this.pbPuushHeader.TabStop = false;
            // 
            // pStart
            // 
            this.pStart.Controls.Add(this.btnStart);
            this.pStart.Location = new System.Drawing.Point(0, 372);
            this.pStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pStart.Name = "pStart";
            this.pStart.Size = new System.Drawing.Size(387, 126);
            this.pStart.TabIndex = 4;
            // 
            // pDownload
            // 
            this.pDownload.Controls.Add(this.lblProgress);
            this.pDownload.Controls.Add(this.pbProgress);
            this.pDownload.Location = new System.Drawing.Point(0, 374);
            this.pDownload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pDownload.Name = "pDownload";
            this.pDownload.Size = new System.Drawing.Size(387, 122);
            this.pDownload.TabIndex = 5;
            // 
            // lblProgress
            // 
            this.lblProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProgress.Location = new System.Drawing.Point(0, 62);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(387, 60);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(9, 24);
            this.pbProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbProgress.MarqueeAnimationSpeed = 50;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(365, 34);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbProgress.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 498);
            this.Controls.Add(this.pbShareXHeader);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbPuushHeader);
            this.Controls.Add(this.pStart);
            this.Controls.Add(this.pDownload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "puush install";
            ((System.ComponentModel.ISupportInitialize)(this.pbShareXHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPuushHeader)).EndInit();
            this.pStart.ResumeLayout(false);
            this.pDownload.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPuushHeader;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbShareXHeader;
        private System.Windows.Forms.Panel pStart;
        private System.Windows.Forms.Panel pDownload;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar pbProgress;
    }
}

