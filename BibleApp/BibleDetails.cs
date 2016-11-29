using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AnotherBibleApp
{
    public delegate void MyDelegate(string Message, int Count, int Max);
    public delegate void MyCompleted();

    public class BibleDetails
    {
        public event MyDelegate VersionUpdate;
        public event MyDelegate BookUpdate;
        public event MyDelegate ChapterUpdate;

        public event MyCompleted Completed;

        private BibleBooks[] Bibles;
        private BibleBooks Books;
        private mVersion _versions;
        private mVersion[] Versions;

        private const string key = "key=adbcd6d6ae712cfe5e1657757b010c4c";

        private List<string> lVersions;
        private List<string> lBooks;
        private List<string> lChapters;

        public string TableofContentsXml { get; internal set; }
        public string TableofContentsJson { get; internal set; }

        public BibleDetails()
        {
        }

        internal void ProcessDetails()
        {
            LoadBibles();
            LoadAllBibles();
            LoadTableofContentsXml();
            LoadTableofContentsJson();
        }

        private void LoadTableofContentsXml()
        {
            mVersions versions = new mVersions();
            versions.Vesions = Versions;
            TableofContentsXml = SerializeObject(versions);
        }

        private void LoadTableofContentsJson()
        {
            mVersions versions = new mVersions();
            versions.Vesions = Versions;
            TableofContentsJson = Serialize<mVersions>(versions);
        }

        private void LoadAllBibles()
        {
            int v = 0;
            Versions = new mVersion[lVersions.Count];
            foreach (string version in lVersions)
            {
                //raise an event
                VersionUpdate("Processing " + version + ": version " + v + " of " + lVersions.Count, v, lVersions.Count);
                _versions = new mVersion();
                Bibles[v] = LoadBooks(version);
                _versions.name = version;
                Versions[v] = _versions;
                Debug.Write(Versions[v].Books);
                v += 1;
            }
            Completed();
        }

        private void LoadChapters(string Version, BibleBooks bible)
        {
            int b = 0;
            foreach (string book in bible.lBooks)
            {
                int c = 0;
                //raise an event
                BookUpdate("Processing " + book + ": book " + b + " of " + bible.lBooks.Count, b, bible.lBooks.Count);

                bible.LoadBibleBooks(book);
                mChapters[] Chapters = new mChapters[bible.lChapters.Count];

                //return entire book
                string bk = book;
                if (bk.StartsWith("Song of Solomon"))
                    bk = book.Replace("Song of Solomon", "song");
                else if (bk.StartsWith("Wisdom of Solomon"))
                    bk = book.Replace("Wisdom of Solomon", "wisdom");
                string getbook = "https://api.biblia.com/v1/bible/content/" + Version + ".txt?style=oneVersePerLineFullReference&passage=" + bk.Replace(" ", "") + "&" + key;
                List<string> contents = ReadXml(getbook).Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList<string>();

                //split it up
                c = 0;
                foreach (string chapter in bible.lChapters)
                {
                    //Count the new lines
                    int verses = contents.FindAll(s => s.StartsWith(chapter + ":")).Count;
                    //Debug.Print("Found {0} verses", verses.Length);
                    Chapters[c] = new mChapters();
                    Chapters[c].Chapter = c;
                    Chapters[c].Verses = verses;
                    c += 1;

                    //raise an event
                    ChapterUpdate("Processing " + chapter + ": chapter " + c + " of " + bible.lChapters.Count, c, bible.lChapters.Count);

                }

                _versions.Books[b] = new mBooks();
                _versions.Books[b].Name = book;
                _versions.Books[b].Chapters = Chapters;

                b += 1;
            }
        }

        private BibleBooks LoadBooks(string version)
        {
            string quary = "http://api.biblia.com/v1/bible/contents/" + version.Replace(" ", "%20") + ".html.json?" + key;
            XmlDocument bibles = new XmlDocument();
            
            string xml = ReadXml(quary);

            Books = BibleBooks.Deserialize<BibleBooks>(xml);

            Books.LoadBibleBooks("Genesis");

            lBooks = Books.lBooks;
            lChapters = Books.lChapters;
            _versions.name = version;
            _versions.Books = new mBooks[Books.lBooks.Count];
            LoadChapters(version, Books);
            
            return Books;
        }

        private void LoadBibles()
        {
            XmlDocument xDoc = new XmlDocument();

            string xml = ReadXml("https://api.biblia.com/v1/bible/find.xml?" + key);

            xDoc.LoadXml(xml);

            XmlNodeList nds = xDoc.SelectNodes("//bibles");

            List<string> bibles = new List<string>();
            foreach (XmlNode nd in nds)
            {
                bibles.Add(nd.SelectSingleNode("bible").InnerText);
            }
            Bibles = new BibleBooks[bibles.Count];
            lVersions = bibles;
        }

        private int LoadPassage(string book, string passage)
        {
            string query = "https://api.biblia.com/v1/bible/content/LEB.html?style=fullyFormatted&passage=" + passage + key;
            string results = ReadXml(query); // "<html><body>" + ReadXml(query) + "</body></html>";

            return 0;
        }

        private string ReadXml(string webquery)
        {
            string results = "";
            WebRequest request = WebRequest.Create(webquery);
            Stream dataStream;
            WebResponse response;
            StreamReader reader;

            try
            {
                response = request.GetResponse();
                dataStream = response.GetResponseStream();
                reader = new StreamReader(dataStream);
                results = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Debug.Print("Error processing " + webquery + ". Error: " + ex);
            }

            return results;
        }

        private int GetTrailingIntegers(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == Char.Parse("-")) { }
                else if (input[i] < 48 || input[i] > 57)
                    break;

                sb.Append(input[i]);
            }

            int result;
            int.TryParse(String.Concat(sb.ToString().ToCharArray().Reverse()), out result);
            return result;
        }

        private float GetTrailingRational(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == Char.Parse(".") || input[i] == Char.Parse("-")) { }
                else if (input[i] < 48 || input[i] > 57)
                    break;

                sb.Append(input[i]);
            }

            float result;
            float.TryParse(String.Concat(sb.ToString().ToCharArray().Reverse()), out result);
            return result;
        }

        public static mVersions DeserializeObject<mVersions>(string xml)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(xml)))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(mVersions));
                return (mVersions)serializer.Deserialize(ms);
            }
        }

        public static string SerializeObject<mVersions>(mVersions obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, obj);
                return textWriter.ToString();
            }
        }

        public static mVersions Deserialize<mVersions>(string json)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(mVersions));
                return (mVersions)serializer.ReadObject(ms);
            }
        }

        public static string Serialize<mVersions>(mVersions obj)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            using (MemoryStream ms = new MemoryStream())
            {
                serializer.WriteObject(ms, obj);
                return Encoding.Default.GetString(ms.ToArray());
            }
        }
    }

    // Define a class to hold custom event info
    public class ProgressStatusArgs : EventArgs
    {
        public ProgressStatusArgs(string s, int i)
        {
            message = s;
            count = i;
        }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    internal class mVersions
    {
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal mVersion[] Vesions { get; set; }
}

    [System.Runtime.Serialization.DataContractAttribute()]
    internal class mVersion
    {
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string name { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal mBooks[] Books { get; set; }
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    internal class mBooks
    {
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string Name { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal mChapters[] Chapters { get; set; }
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    internal class mChapters
    {
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal int Chapter { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal int Verses { get; set; }
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    internal class mVerses
    {
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal int Verse { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string Contents { get; set; }
    }
}
