using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        delegate void SetTextCallback(string text, int value);
        
        public TotalVerses()
        {
            InitializeComponent();
        }

        private void TotalVerses_Load(object sender, EventArgs e)
        {
            bibleDetails = new BibleDetails();
            bibleDetails.VersionUpdate += delegate (string message, int count, int max) { BibleDetails_VersionUpdate(message, count, max); };
            bibleDetails.BookUpdate += delegate(string message, int count, int max) { BibleDetails_BookUpdate(message, count, max); };
            bibleDetails.ChapterUpdate += delegate (string message, int count, int max) { BibleDetails_ChapterUpdate(message, count, max); };
            bibleDetails.Completed += delegate () { BibleDetails_Completed(); };
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ((BibleDetails)e.Argument).ProcessDetails();
        }

        private void BibleDetails_Completed()
        {
            if (wResults.InvokeRequired)
            {
                //This techniques is from answer by @sinperX1
                BeginInvoke((MethodInvoker)(() => { BibleDetails_Completed(); }));
                return;
            }
            else
            {
                wResults.DocumentText = bibleDetails.TableofContentsXml;
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
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerAsync(bibleDetails);
        }
    }
}
