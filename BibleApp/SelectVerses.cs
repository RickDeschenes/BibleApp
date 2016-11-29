using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace AnotherBibleApp
{
    public partial class SelectVerses : Form
    {
        private string _version;
        private string _testament;
        private string _book;
        private int _chapter;
        private int _start;
        private int _stop;

        internal BibleBooks Books;

        private const string key = "key=adbcd6d6ae712cfe5e1657757b010c4c";

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

        internal SelectVerses()
        {
            InitializeComponent();
        }

        List<string> Versions = new List<string>(new string[] { "Not loaded." } );
        List<string> Bibles = new List<string>( new string[] { "Not loaded." } );
        List<Books> books = new List<Books>();
        List<string> Chapters = new List<string>(new string[] { "Not loaded." });
        List<int> Verses = new List<int>(new int[] { -1 });

        private void selectVerses_Load(object sender, EventArgs e)
        {
            XmlDocument bibles = new XmlDocument();

            string xml = ReadXml("https://api.biblia.com/v1/bible/find.xml?" + key);

            bibles.LoadXml(xml);

            XmlNodeList nds = bibles.SelectNodes("//bibles");

            Bibles = new List<string>();
            foreach (XmlNode nd in nds)
            {
                Bibles.Add(nd.SelectSingleNode("abbreviatedTitle").InnerText);
            }
            cVersion.DataSource = Bibles;
        }

        private void cVersion_SelectedValueChanged(object sender, EventArgs e)
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
            cVerses.DataSource = Books.lVerses;
        }

        private void cBooks_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cChapter_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cStart_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cVerses_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadPassage(string book, string passage)
        {
            string query = "https://api.biblia.com/v1/bible/content/LEB.html?style=fullyFormatted&passage=" + passage + key;
            webBrowser1.DocumentText = ReadXml(query); // "<html><body>" + ReadXml(query) + "</body></html>";
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
    }
}
