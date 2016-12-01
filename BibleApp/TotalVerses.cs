using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotherBibleApp
{
    public partial class TotalVerses : Form
    {
        private BibleDetails bibleDetails;
        private List<string> versions = new List<string>();

        delegate void SetTextCallback(string text, int value);

        public TotalVerses()
        {
            InitializeComponent();
        }

        private void TotalVerses_Load(object sender, EventArgs e)
        {
            bibleDetails = new BibleDetails();
            bibleDetails.VersionUpdate += delegate (string message, int count, int max) { BibleDetails_VersionUpdate(message, count, max); };
            bibleDetails.BookUpdate += delegate (string message, int count, int max) { BibleDetails_BookUpdate(message, count, max); };
            bibleDetails.ChapterUpdate += delegate (string message, int count, int max) { BibleDetails_ChapterUpdate(message, count, max); };
            bibleDetails.Completed += delegate () { BibleDetails_Completed(); };
            foreach (string c in bibleDetails.lVersions)
                cVersions.Items.Add(c);
            cVersions.SelectedValue = 4;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ((BibleDetails)e.Argument).ProcessDetails();
        }

        private void BibleDetails_Completed()
        {
            if (rResults.InvokeRequired)
            {
                //This techniques is from answer by @sinperX1
                BeginInvoke((MethodInvoker)(() => { BibleDetails_Completed(); }));
                return;
            }
            else
            {
                rResults.Text = bibleDetails.TableofContentsTxt;
                pChapters.Value = 0;
                lChapters.Text = "Process completed";
                pBooks.Value = 0;
                lBooks.Text = "Process completed";
                pVersions.Value = 0;
                lVersions.Text = "Process completed";
            }
        }

        private void BibleDetails_ChapterUpdate(string message, int count, int max)
        {
            if (pChapters.InvokeRequired)
            {
                //This techniques is from answer by @sinperX1
                BeginInvoke((MethodInvoker)(() => { BibleDetails_ChapterUpdate(message, count, max); }));
                return;
            }
            else
            {
                pChapters.Maximum = max;
                pChapters.Value = count;
                lChapters.Text = message;
            }
        }

        private void BibleDetails_BookUpdate(string message, int count, int max)
        {
            if (pBooks.InvokeRequired)
            {
                //This techniques is from answer by @sinperX1
                BeginInvoke((MethodInvoker)(() => { BibleDetails_BookUpdate(message, count, max); }));
                return;
            }
            else
            {
                pBooks.Maximum = max;
                pBooks.Value = count;
                lBooks.Text = message;
            }
        }

        private void BibleDetails_VersionUpdate(string message, int count, int max)
        {
            if (pVersions.InvokeRequired)
            {
                //This techniques is from answer by @sinperX1
                BeginInvoke((MethodInvoker)(() => { BibleDetails_VersionUpdate(message, count, max); }));
                return;
            }
            else
            {
                pVersions.Maximum = max;
                pVersions.Value = count;
                lVersions.Text = message;
            }
        }

        private void bProcess_Click(object sender, EventArgs e)
        {
            pChapters.Maximum = 80;
            bibleDetails.Path = QualifiedPath(tPath.Text);
            bibleDetails.lProcess = versions;
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerAsync(bibleDetails);
        }

        private string QualifiedPath(string text)
        {
            string results = text;
            if (text.Length < 3)
                return results;
            if (text.LastIndexOf("\\") != text.Length - 1)
                    text+="\\";

            return results;
        }

        private void cVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            bProcess.Enabled = (cVersions.CheckedItems.Count > 0) && (Directory.Exists(tPath.Text));
            versions.Clear();
            foreach (string c in cVersions.CheckedItems)
                versions.Add(c);
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fb = new FolderBrowserDialog())
            {
                if (fb.ShowDialog() == DialogResult.OK)
                {
                    tPath.Text = fb.SelectedPath;
                }
            }
        }

        private void tPath_TextChanged(object sender, EventArgs e)
        {
            bProcess.Enabled = (cVersions.CheckedItems.Count > 0) && (Directory.Exists(tPath.Text));
        }
    }
}
