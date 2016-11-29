namespace AnotherBibleApp
{
    partial class Passage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pControls = new System.Windows.Forms.Panel();
            this.pSearch = new System.Windows.Forms.Panel();
            this.lSearch = new System.Windows.Forms.Label();
            this.lFind = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.tSearch = new System.Windows.Forms.TextBox();
            this.bFind = new System.Windows.Forms.Button();
            this.pTools = new System.Windows.Forms.Panel();
            this.bSearch = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.lVersion = new System.Windows.Forms.Label();
            this.cVersion = new System.Windows.Forms.ComboBox();
            this.cBooks = new System.Windows.Forms.ComboBox();
            this.lVerses = new System.Windows.Forms.Label();
            this.cChapter = new System.Windows.Forms.ComboBox();
            this.cStop = new System.Windows.Forms.ComboBox();
            this.cStart = new System.Windows.Forms.ComboBox();
            this.lChapter = new System.Windows.Forms.Label();
            this.lStart = new System.Windows.Forms.Label();
            this.lBook = new System.Windows.Forms.Label();
            this.wbPassage = new System.Windows.Forms.WebBrowser();
            this.pControls.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.pTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pControls
            // 
            this.pControls.Controls.Add(this.pSearch);
            this.pControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControls.Location = new System.Drawing.Point(0, 0);
            this.pControls.Name = "pControls";
            this.pControls.Size = new System.Drawing.Size(250, 80);
            this.pControls.TabIndex = 29;
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.lSearch);
            this.pSearch.Controls.Add(this.lFind);
            this.pSearch.Controls.Add(this.bClose);
            this.pSearch.Controls.Add(this.tSearch);
            this.pSearch.Controls.Add(this.bFind);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(250, 80);
            this.pSearch.TabIndex = 28;
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Location = new System.Drawing.Point(0, 59);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(0, 13);
            this.lSearch.TabIndex = 4;
            // 
            // lFind
            // 
            this.lFind.AutoSize = true;
            this.lFind.Location = new System.Drawing.Point(0, 0);
            this.lFind.Name = "lFind";
            this.lFind.Size = new System.Drawing.Size(179, 13);
            this.lFind.TabIndex = 3;
            this.lFind.Text = "enter search value(s), seperated by ;";
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(169, 54);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "&Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // tSearch
            // 
            this.tSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tSearch.Location = new System.Drawing.Point(0, 27);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(168, 20);
            this.tSearch.TabIndex = 1;
            this.tSearch.TextChanged += new System.EventHandler(this.tSearch_TextChanged);
            // 
            // bFind
            // 
            this.bFind.Location = new System.Drawing.Point(169, 25);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(75, 23);
            this.bFind.TabIndex = 0;
            this.bFind.Text = "&Find";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // pTools
            // 
            this.pTools.Controls.Add(this.bSearch);
            this.pTools.Controls.Add(this.bLoad);
            this.pTools.Controls.Add(this.lVersion);
            this.pTools.Controls.Add(this.cVersion);
            this.pTools.Controls.Add(this.cBooks);
            this.pTools.Controls.Add(this.lVerses);
            this.pTools.Controls.Add(this.cChapter);
            this.pTools.Controls.Add(this.cStop);
            this.pTools.Controls.Add(this.cStart);
            this.pTools.Controls.Add(this.lChapter);
            this.pTools.Controls.Add(this.lStart);
            this.pTools.Controls.Add(this.lBook);
            this.pTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTools.Location = new System.Drawing.Point(0, 0);
            this.pTools.Name = "pTools";
            this.pTools.Size = new System.Drawing.Size(250, 80);
            this.pTools.TabIndex = 29;
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bSearch.Location = new System.Drawing.Point(192, 17);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(55, 23);
            this.bSearch.TabIndex = 27;
            this.bSearch.Text = "&Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bLoad
            // 
            this.bLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bLoad.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bLoad.Location = new System.Drawing.Point(192, 56);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(55, 23);
            this.bLoad.TabIndex = 26;
            this.bLoad.Text = "&Load";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.Location = new System.Drawing.Point(3, 3);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(42, 13);
            this.lVersion.TabIndex = 24;
            this.lVersion.Text = "&Version";
            // 
            // cVersion
            // 
            this.cVersion.FormattingEnabled = true;
            this.cVersion.Location = new System.Drawing.Point(6, 19);
            this.cVersion.Name = "cVersion";
            this.cVersion.Size = new System.Drawing.Size(78, 21);
            this.cVersion.TabIndex = 23;
            this.cVersion.SelectedValueChanged += new System.EventHandler(this.cVersion_SelectedValueChanged);
            // 
            // cBooks
            // 
            this.cBooks.FormattingEnabled = true;
            this.cBooks.Location = new System.Drawing.Point(90, 19);
            this.cBooks.Name = "cBooks";
            this.cBooks.Size = new System.Drawing.Size(78, 21);
            this.cBooks.TabIndex = 13;
            this.cBooks.SelectedValueChanged += new System.EventHandler(this.cBooks_SelectedValueChanged);
            // 
            // lVerses
            // 
            this.lVerses.AutoSize = true;
            this.lVerses.Location = new System.Drawing.Point(127, 40);
            this.lVerses.Name = "lVerses";
            this.lVerses.Size = new System.Drawing.Size(26, 13);
            this.lVerses.TabIndex = 22;
            this.lVerses.Text = "&End";
            // 
            // cChapter
            // 
            this.cChapter.FormattingEnabled = true;
            this.cChapter.Location = new System.Drawing.Point(6, 56);
            this.cChapter.Name = "cChapter";
            this.cChapter.Size = new System.Drawing.Size(56, 21);
            this.cChapter.TabIndex = 14;
            this.cChapter.SelectedValueChanged += new System.EventHandler(this.cChapter_SelectedValueChanged);
            // 
            // cStop
            // 
            this.cStop.FormattingEnabled = true;
            this.cStop.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176"});
            this.cStop.Location = new System.Drawing.Point(130, 56);
            this.cStop.Name = "cStop";
            this.cStop.Size = new System.Drawing.Size(56, 21);
            this.cStop.TabIndex = 21;
            this.cStop.SelectedValueChanged += new System.EventHandler(this.cVerses_SelectedValueChanged);
            // 
            // cStart
            // 
            this.cStart.FormattingEnabled = true;
            this.cStart.Location = new System.Drawing.Point(68, 56);
            this.cStart.Name = "cStart";
            this.cStart.Size = new System.Drawing.Size(56, 21);
            this.cStart.TabIndex = 15;
            this.cStart.SelectedValueChanged += new System.EventHandler(this.cStart_SelectedValueChanged);
            // 
            // lChapter
            // 
            this.lChapter.AutoSize = true;
            this.lChapter.Location = new System.Drawing.Point(3, 40);
            this.lChapter.Name = "lChapter";
            this.lChapter.Size = new System.Drawing.Size(44, 13);
            this.lChapter.TabIndex = 16;
            this.lChapter.Text = "&Chapter";
            // 
            // lStart
            // 
            this.lStart.AutoSize = true;
            this.lStart.Location = new System.Drawing.Point(65, 40);
            this.lStart.Name = "lStart";
            this.lStart.Size = new System.Drawing.Size(34, 13);
            this.lStart.TabIndex = 17;
            this.lStart.Text = "&Start";
            // 
            // lBook
            // 
            this.lBook.AutoSize = true;
            this.lBook.Location = new System.Drawing.Point(87, 3);
            this.lBook.Name = "lBook";
            this.lBook.Size = new System.Drawing.Size(32, 13);
            this.lBook.TabIndex = 18;
            this.lBook.Text = "&Book";
            // 
            // wbPassage
            // 
            this.wbPassage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbPassage.Location = new System.Drawing.Point(0, 80);
            this.wbPassage.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPassage.Name = "wbPassage";
            this.wbPassage.Size = new System.Drawing.Size(250, 170);
            this.wbPassage.TabIndex = 30;
            // 
            // Passage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wbPassage);
            this.Controls.Add(this.pTools);
            this.Name = "Passage";
            this.Size = new System.Drawing.Size(250, 250);
            this.pControls.ResumeLayout(false);
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.pTools.ResumeLayout(false);
            this.pTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControls;
        private System.Windows.Forms.Panel pTools;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.ComboBox cVersion;
        private System.Windows.Forms.ComboBox cBooks;
        private System.Windows.Forms.Label lVerses;
        private System.Windows.Forms.ComboBox cChapter;
        private System.Windows.Forms.ComboBox cStop;
        private System.Windows.Forms.ComboBox cStart;
        private System.Windows.Forms.Label lChapter;
        private System.Windows.Forms.Label lStart;
        private System.Windows.Forms.Label lBook;
        private System.Windows.Forms.WebBrowser wbPassage;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.Label lFind;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Label lSearch;
    }
}
