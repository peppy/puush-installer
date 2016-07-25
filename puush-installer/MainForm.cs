using puush_installer.ShareX.HelpersLib;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace puush_installer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartDownload();
        }

        private void StartDownload()
        {
            pbProgress.Visible = false;
            btnStart.Visible = false;
            lblProgress.Text = "Finding latest download...";
            lblProgress.Visible = true;

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
                    lblProgress.Text = "Beginning download...";

                    string downloadPath = checker.Filename;
                    FileStream fileStream = new FileStream(downloadPath, FileMode.Create, FileAccess.Write, FileShare.Read);
                    FileDownloader fileDownloader = new FileDownloader(checker.DownloadURL, fileStream, null, "application/octet-stream");

                    fileDownloader.ExceptionThrowed += (sender2, e2) =>
                    {
                        ResetControls();

                        MessageBox.Show("Error:\r\n\r\n" + fileDownloader.LastException, "puush install", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };

                    fileDownloader.DownloadStarted += (sender2, e2) =>
                    {
                        lblProgress.Visible = false;
                        pbProgress.Visible = true;
                    };

                    fileDownloader.ProgressChanged += (sender2, e2) =>
                    {
                        int percentage = (int)Math.Round(fileDownloader.DownloadPercentage);
                        pbProgress.Value = percentage;
                    };

                    fileDownloader.DownloadCompleted += (sender2, e2) =>
                    {
                        if (File.Exists(downloadPath))
                        {
                            Process.Start(downloadPath, "-puush");
                            Environment.Exit(0);
                        }
                    };

                    fileDownloader.StartDownload();
                }
                else
                {
                    ResetControls();

                    MessageBox.Show("Unable to find latest ShareX build.", "puush install", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            bw.RunWorkerAsync();
        }

        private void ResetControls()
        {
            btnStart.Visible = true;
            pbProgress.Visible = false;
            lblProgress.Visible = false;
        }
    }
}