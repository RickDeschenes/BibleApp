using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AnotherBibleApp
{
    class BibleDetails
    {
        // Declare the event using EventHandler<T>
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        private BibleBooks[] Bibles;
        private BibleBooks Books;
        private mVersions _versions;
        private mVersions[] Versions;

        private const string key = "key=adbcd6d6ae712cfe5e1657757b010c4c";

        private List<string> lVersions;
        private List<string> lBooks;
        private List<string> lChapters;

        public BibleDetails()
        {
            LoadBibles();
            LoadAllBibles();
        }

        private void LoadAllBibles()
        {
            int i = 0;
            Versions = new mVersions[lVersions.Count];
            foreach (string version in lVersions)
            {
                _versions = new mVersions();
                Bibles[i] = LoadBooks(version);
                _versions.name = version;
                Versions[i] = _versions;
                Debug.Write(Versions[i].Books);
                i += 1;
            }
        }

        private void LoadChapters(string Version, BibleBooks bible)
        {
            int b = 0;
            foreach (string book in bible.lBooks)
            {
                int c = 0;
                bible.LoadBibleBooks(book);
                mChapters[] Chapters = new mChapters[bible.lChapters.Count];

                //return entire book
                string bk = book;
                if (bk.StartsWith("Song of Solomon"))
                    bk = book.Replace("Song of Solomon", "song");
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
                }

                //fill our object

                //c = 0;
                //foreach (string chapter in bible.lChapters)
                //{
                //    string cr = chapter;
                //    if (cr.StartsWith("Song of Solomon"))
                //        cr = chapter.Replace("Song of Solomon", "song");
                //    string query = "https://api.biblia.com/v1/bible/content/" + Version + ".txt?style=oneVersePerLineFullReference&passage=" + cr.Replace(" ", "") + "&" + key;
                //    string results = ReadXml(query);
                //    //Debug.WriteLine(xml);
                //    //Count the new lines
                //    string[] verses = results.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                //    //Debug.Print("Found {0} verses", verses.Length);
                //    Chapters[c] = new mChapters();
                //    Chapters[c].Chapter = c;
                //    Chapters[c].Verses = verses.Length;
                //    c += 1;
                //}
                _versions.Books[b] = new mBooks();
                _versions.Books[b].Name = book;
                _versions.Books[b].Chapters = Chapters;

                //raise an event
                OnRaiseCustomEvent(new CustomEventArgs("Processing book " + b + " of " + bible.lBooks.Count));
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

            response = request.GetResponse();
            dataStream = response.GetResponseStream();
            reader = new StreamReader(dataStream);
            results = reader.ReadToEnd();

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

        // Wrap event invocations inside a protected virtual method
        // to allow derived classes to override the event invocation behavior
        protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            EventHandler<CustomEventArgs> handler = RaiseCustomEvent;

            // Event will be null if there are no subscribers
            if (handler != null)
            {
                // Format the string to send inside the CustomEventArgs parameter
                e.Message += String.Format(" at {0}", DateTime.Now.ToString());

                // Use the () operator to raise the event.
                handler(this, e);
            }
        }
    }

    // Define a class to hold custom event info
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string s)
        {
            message = s;
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }

    internal class mVersions
    {
        internal string name { get; set; }
        internal mBooks[] Books { get; set; }
    }

    internal class mBooks
    {
        internal string Name { get; set; }
        internal mChapters[] Chapters { get; set; }
    }

    internal class mChapters
    {
        internal int Chapter { get; set; }
        internal int Verses { get; set; }
    }

    internal class mVerses
    {
        internal int Verse { get; set; }
        internal string Contents { get; set; }
    }
}
