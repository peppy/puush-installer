using puush_installer.Helpers;
using ShareX.HelpersLib;
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

        BackgroundWorker bw = new BackgroundWorker();

        private void startDownload()
        {
            GitHubUpdateChecker checker = new GitHubUpdateChecker(@"ShareX", @"ShareX");

            bw.DoWork += delegate
            {
                Invoke((MethodInvoker)delegate
                {
                    labelProgress.Text = @"Finding latest download...";
                });

                string url = checker.GetLatestDownloadURL();

                Invoke((MethodInvoker)delegate
                {
                    labelProgress.Text = @"Beginning download...";
                });

                FileWebRequest req = new FileWebRequest(@"sharex.exe", url);
                req.DownloadProgress += downloadProgress;
                req.BlockingPerform();

                Invoke((MethodInvoker)delegate
                {
                    Process.Start(@"sharex.exe");
                    Environment.Exit(0);
                });
            };

            bw.RunWorkerAsync();
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
