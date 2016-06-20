using ShareX.HelpersLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
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

        private void button1_Click(object sender, EventArgs e)
        {
            startDownload();
        }

        private void startDownload()
        {
            panelStart.Visible = false;
            labelProgress.Text = "Finding latest download...";

            GitHubUpdateChecker checker = null;
            BackgroundWorker bw = new BackgroundWorker();

            bw.DoWork += (sender, e) =>
            {
                checker = new GitHubUpdateChecker("ShareX", "ShareX");
                checker.GetLatestDownloadURL(false, false, false);
            };

            bw.RunWorkerCompleted += (sender, e) =>
            {
                if (checker != null && !string.IsNullOrEmpty(checker.DownloadURL))
                {
                    labelProgress.Text = "Beginning download...";
                    progressBar1.Style = ProgressBarStyle.Continuous;

                    string downloadPath = Path.Combine(Path.GetTempPath(), checker.Filename);
                    FileStream fileStream = new FileStream(downloadPath, FileMode.Create, FileAccess.Write, FileShare.Read);
                    FileDownloader fileDownloader = new FileDownloader(checker.DownloadURL, fileStream, null, "application/octet-stream");

                    fileDownloader.ProgressChanged += (sender2, e2) =>
                    {
                        progressBar1.Value = (int)Math.Round(fileDownloader.DownloadPercentage);
                        labelProgress.Text = string.Format(CultureInfo.CurrentCulture, "Progress: {0:0.0}%\r\nDownload speed: {1:0.0} KB/s\r\nFile size: {2:n0} / {3:n0} KB",
                            fileDownloader.DownloadPercentage, fileDownloader.DownloadSpeed / 1024, fileDownloader.DownloadedSize / 1024, fileDownloader.FileSize / 1024);
                    };

                    fileDownloader.DownloadCompleted += (sender2, e2) =>
                    {
                        if (File.Exists(downloadPath))
                        {
                            Process.Start(downloadPath);
                            Environment.Exit(0);
                        }
                    };

                    fileDownloader.StartDownload();
                }
                else
                {
                    labelProgress.Text = "Unable to find latest build.";
                    panelStart.Visible = true;
                }
            };

            bw.RunWorkerAsync();
        }
    }
}