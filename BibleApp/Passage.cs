using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using mshtml;

namespace AnotherBibleApp
{
    public partial class Passage : UserControl
    {
        private string _version;
        private string _testament;
        private string _book;
        private int _chapter;
        private int _start;
        private int _stop;

        private const string key = "key=adbcd6d6ae712cfe5e1657757b010c4c";

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private string Version
        {
            get { return _version; }
            set { _version = value; }
        }
        private string Testament
        {
            get { return _testament; }
            set { _testament = value; }
        }
        private string Book
        {
            get { return _book; }
            set { _book = value; }
        }
        private int Chapter
        {
            get { return _chapter; }
            set { _chapter = value; }
        }
        private int Start
        {
            get { return _start; }
            set { _start = value; }
        }
        private int Stop
        {
            get { return _stop; }
            set { _stop = value; }
        }

        internal BibleBooks Books;

        internal Passage(string version, string book, int chapter, int start, int stop)
        {
            InitializeComponent();
        }

        public Passage()
        {
            InitializeComponent();
            LoadBibles();
            LoadBook();
        }

        private void LoadBook()
        {
            cBooks.DataSource = null;
            cChapter.DataSource = null;
            if (cVersion.SelectedIndex < 0)
                return;

            string book = cVersion.Text + ".html.json?";

            XmlDocument bibles = new XmlDocument();

            string xml = ReadXml("http://api.biblia.com/v1/bible/contents/" + book + key);

            Books = BibleBooks.Deserialize<BibleBooks>(xml);

            Books.LoadBibleBooks("Genesis");

            cBooks.DataSource = Books.lBooks;
            cChapter.DataSource = Books.lChapters;
            cStop.DataSource = Books.lVerses;
        }

        private void LoadBibles()
        {
            XmlDocument bibles = new XmlDocument();

            string xml = ReadXml("https://api.biblia.com/v1/bible/find.xml?" + key);

            bibles.LoadXml(xml);

            XmlNodeList nds = bibles.SelectNodes("//bibles");

            List<string> Bibles = new List<string>();
            foreach (XmlNode nd in nds)
            {
                Bibles.Add(nd.SelectSingleNode("abbreviatedTitle").InnerText);
            }
            cVersion.DataSource = Bibles;
        }

        private void cVersion_SelectedValueChanged(object sender, EventArgs e)
        {
            bLoad.Enabled = true;
            wbPassage.DocumentText = "";
        }

        private void cBooks_SelectedValueChanged(object sender, EventArgs e)
        {
            bLoad.Enabled = true;
            wbPassage.DocumentText = "";
        }

        private void cChapter_SelectedValueChanged(object sender, EventArgs e)
        {
            bLoad.Enabled = true;
            wbPassage.DocumentText = "";
        }

        private void cStart_SelectedValueChanged(object sender, EventArgs e)
        {
            bLoad.Enabled = true;
            wbPassage.DocumentText = "";
        }

        private void cVerses_SelectedValueChanged(object sender, EventArgs e)
        {
            bLoad.Enabled = true;
            wbPassage.DocumentText = "";
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            wbPassage.DocumentText = Books.LoadPasage(cVersion.Text, cBooks.Text, cChapter.Text, cStart.Text, cStop.Text);
            bLoad.Enabled = false;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            pSearch.Visible = true;
        }

        private void bFind_Click(object sender, EventArgs e)
        {
            string[] words = tSearch.Text.Split(";".ToCharArray());
            HighLightWord(words);
        }

        private void tSearch_TextChanged(object sender, EventArgs e)
        {
            lSearch.Text = tSearch.Text;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            pSearch.Visible = false;
        }

        private void LoadPassage(string book, string passage)
        {
            string query = "https://api.biblia.com/v1/bible/content/LEB.html?style=fullyFormatted&passage=" + passage + key;
            wbPassage.DocumentText = ReadXml(query); // "<html><body>" + ReadXml(query) + "</body></html>";
        }

        private string ReadXml(string webquery)
        {
            string results = "";
            WebRequest request = WebRequest.Create(webquery);
            Stream dataStream;
            WebResponse response;
            StreamReader reader;

            response = request.GetResponse();
            dataStream = response.GetResponseStream();
            reader = new StreamReader(dataStream);
            results = reader.ReadToEnd();

            return results;
        }

        private void HighLightWord(string[] words)
        {
            HTMLDocument doc2 = wbPassage.Document.DomDocument as HTMLDocument;
            StringBuilder html = new StringBuilder(doc2.body.outerHTML);
            
            foreach (String key in words)
            {
                String substitution = "<span style='background-color: rgb(255, 255, 0);'>" + key + "</span>";
                html.Replace(key, substitution);
            }

            doc2.body.innerHTML = html.ToString();
        }
    }
}
