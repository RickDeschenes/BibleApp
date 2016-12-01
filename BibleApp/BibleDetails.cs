using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace AnotherBibleApp
{
    internal delegate void MyDelegate(string Message, int Count, int Max);
    internal delegate void MyCompleted();

    public class BibleDetails
    {
        internal event MyDelegate VersionUpdate;
        internal event MyDelegate BookUpdate;
        internal event MyDelegate ChapterUpdate;

        internal event MyCompleted Completed;

        private BibleBooks[] Bibles;
        private BibleBooks Books;
        public mVersion _versions;
        public mVersion[] Versions;

        private const string key = "key=adbcd6d6ae712cfe5e1657757b010c4c";

        internal List<string> lVersions;
        private List<string> lBooks;
        private List<string> lChapters;
        internal List<string> lProcess;

        internal string TableofContentsTxt { get; private set; }
        internal string TableofContentsXml { get; private set; }
        internal string TableofContentsJson { get; private set; }
        public object Path { get; internal set; }

        internal BibleDetails()
        {
            LoadBibles();
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

        internal void ProcessDetails()
        {
            LoadAllBibles();
            LoadTableofContentsXml();
            LoadTableofContentsDelimited();
            LoadTableofContentsJson();
            Completed();
        }

        private void LoadTableofContentsDelimited()
        {
            StringBuilder sb = new StringBuilder();

            XmlDocument xdoc = new XmlDocument();

            xdoc.LoadXml(TableofContentsXml);
            xdoc.Save(Path + "TableofContents.xml");
            // Top level mVersions
            foreach (XmlNode tp in xdoc.ChildNodes)
            {
                // Named level Version
                foreach (XmlNode v in tp.ChildNodes)
                {
                    string version = "";
                    int books = 0;
                    int vchapters = 0;
                    int vverses = 0;
                    //mVersion level
                    foreach (XmlNode mv in v.ChildNodes)
                    {
                        int bchapters = 0;
                        //Named levels (Name, Books)
                        foreach (XmlNode cn in mv.ChildNodes)
                        {
                            //TODO: we need to make a look up for full name, Image, ect.
                            if (cn.Name == "Name")
                                version = cn.InnerText;
                            else
                            {
                                //mBooks
                                foreach (XmlNode b in cn.ChildNodes)
                                {
                                    string book = "";
                                    int chapters = 0;
                                    int verses = 0;
                                    int bverses = 0;
                                    //mBooks
                                    foreach (XmlNode mb in b.ChildNodes)
                                    {
                                        if (mb.Name == "Name")
                                            book = mb.InnerText;
                                        else
                                        {
                                            //Chapters
                                            foreach (XmlNode c in mb.ChildNodes)
                                            {
                                                string chapter = "";
                                                //mChapters
                                                foreach (XmlNode mc in c.ChildNodes)
                                                {
                                                    if (mc.Name == "Chapter")
                                                    {
                                                        chapter = mc.InnerText;
                                                    }
                                                    else
                                                    {
                                                        string output = string.Format("{0}:{1}:{2}:{3}", version, book, chapter, mc.InnerText);
                                                        if (mc.InnerText == "0")
                                                            Debug.Print(output);
                                                        sb.AppendLine(output);
                                                        verses = int.Parse(mc.InnerText);
                                                        bverses += verses;
                                                    }
                                                }
                                                chapters += 1;
                                            }
                                        }
                                    }
                                    sb.AppendLine(string.Format("{0}:{1}: Chapters {2}: Verses {3}", version, book, chapters, bverses));
                                    bchapters += chapters;
                                    vverses += bverses;
                                    books += 1;
                                }
                            }
                        }
                        vchapters += bchapters;
                    }
                    sb.AppendLine(string.Format("{0}: Books {1}: Chapters {2}: Verses {3}\n", version, books, vchapters, vverses));
                }
            }
            TableofContentsTxt = sb.ToString();
            string path = Path + "ChaptersVerses.txt";
            using (StreamWriter sr = new StreamWriter(path))
            {
                sr.WriteLine(sb.ToString());
            }
        }

        private void LoadTableofContentsXml()
        {
            mVersions versions = new mVersions();
            versions.Versions = Versions;
            TableofContentsXml = SerializeObject(versions);
        }

        private void LoadTableofContentsJson()
        {
            mVersions versions = new mVersions();
            versions.Versions = Versions;
            TableofContentsJson = Serialize<mVersions>(versions);
        }

        private void LoadAllBibles()
        {
            int v = 0;
            Versions = new mVersion[lVersions.Count];
            foreach (string version in lProcess)
            {
                //raise an event
                VersionUpdate("Processing " + version + ": version " + v + " of " + lProcess.Count, v, lVersions.Count);
                _versions = new mVersion();
                Bibles[v] = LoadBooks(version);
                _versions.Name = version;
                Versions[v] = _versions;
                Debug.Write(Versions[v].Books);
                v += 1;
            }
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

                string path = Path + "" + Version;
                Directory.CreateDirectory(path);
                path += "\\" + book + ".txt";

                string getbook = "https://api.biblia.com/v1/bible/content/" + Version + ".txt?style=oneVersePerLineFullReference&passage=" + bk.Replace(" ", "") + "&" + key;

                List<string> contents = new List<string>();

                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        while (!sr.EndOfStream)
                            contents.Add(sr.ReadLine());
                    }
                }
                else
                {
                    contents = ReadXml(getbook).Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                    //Print it
                    using (StreamWriter sr = new StreamWriter(path))
                    {
                        contents.ForEach(sr.WriteLine);
                    }
                }

                //split it up
                c = 0;
                foreach (string chapter in bible.lChapters)
                {
                    //Count the new lines
                    int verses = contents.FindAll(s => s.StartsWith(chapter + ":")).Count;
                    if (verses == 0)
                        verses = contents.FindAll(s => s.StartsWith(chapter + " ")).Count;
                    //Debug.Print("Found {0} verses", verses.Length);
                    Chapters[c] = new mChapters();
                    Chapters[c].Chapter = c + 1;
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
            _versions.Name = version;
            _versions.Books = new mBooks[Books.lBooks.Count];
            LoadChapters(version, Books);
            
            return Books;
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

        internal static mVersions DeserializeObject<mVersions>(string xml)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(xml)))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(mVersions));
                return (mVersions)serializer.Deserialize(ms);
            }
        }

        internal static string SerializeObject<mVersions>(mVersions obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, obj);
                return textWriter.ToString();
            }
        }

        internal static mVersions Deserialize<mVersions>(string json)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(mVersions));
                return (mVersions)serializer.ReadObject(ms);
            }
        }

        internal static string Serialize<mVersions>(mVersions obj)
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
    internal class ProgressStatusArgs : EventArgs
    {
        internal ProgressStatusArgs(string s, int i)
        {
            message = s;
            count = i;
        }
        private string message;
        internal string Message
        {
            get { return message; }
            set { message = value; }
        }
        private int count;
        internal int Count
        {
            get { return count; }
            set { count = value; }
        }
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public class mVersions
    {
        [System.Runtime.Serialization.DataMemberAttribute()]
        public mVersion[] Versions { get; set; }
}

    [System.Runtime.Serialization.DataContractAttribute()]
    public class mVersion
    {
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        public mBooks[] Books { get; set; }
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public class mBooks
    {
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        public mChapters[] Chapters { get; set; }
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public class mChapters
    {
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Chapter { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Verses { get; set; }
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public class mVerses
    {
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Verse { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contents { get; set; }
    }
}
