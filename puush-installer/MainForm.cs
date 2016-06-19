using osu_common.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace puush_installer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelStart.Hide();
            startDownload();
        }

        private void startDownload()
        {
            labelProgress.Text = @"Beginning download...";

            string url = @"https://github.com/ShareX/ShareX/releases/download/v11.0.1/ShareX-11.0.1-setup.exe";
            FileWebRequest req = new FileWebRequest(@"sharex.exe", url);
            req.DownloadProgress += downloadProgress;
            req.Finished += downloadFInished;
            req.Perform();
        }

        private void downloadFInished(WebRequest request, Exception e)
        {
            Process.Start(@"sharex.exe");
            Environment.Exit(0);
        }

        private void downloadProgress(WebRequest request, long current, long total)
        {
            Invoke((MethodInvoker)delegate
            {
                int percent = (int)((float)current / total * 100);
                labelProgress.Text = $@"Downloading ({percent}% complete)";
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Value = percent;
            });
        }
    }
}
