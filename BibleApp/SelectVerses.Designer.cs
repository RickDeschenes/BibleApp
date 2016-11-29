namespace AnotherBibleApp
{
    partial class SelectVerses
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lVersion = new System.Windows.Forms.Label();
            this.cVersion = new System.Windows.Forms.ComboBox();
            this.lVerses = new System.Windows.Forms.Label();
            this.cVerses = new System.Windows.Forms.ComboBox();
            this.lBook = new System.Windows.Forms.Label();
            this.lStart = new System.Windows.Forms.Label();
            this.lChapter = new System.Windows.Forms.Label();
            this.cStart = new System.Windows.Forms.ComboBox();
            this.cChapter = new System.Windows.Forms.ComboBox();
            this.cBooks = new System.Windows.Forms.ComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.Location = new System.Drawing.Point(5, 1);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(42, 13);
            this.lVersion.TabIndex = 24;
            this.lVersion.Text = "&Version";
            // 
            // cVersion
            // 
            this.cVersion.FormattingEnabled = true;
            this.cVersion.Location = new System.Drawing.Point(3, 17);
            this.cVersion.Name = "cVersion";
            this.cVersion.Size = new System.Drawing.Size(78, 21);
            this.cVersion.TabIndex = 23;
            this.cVersion.SelectedValueChanged += new System.EventHandler(this.cVersion_SelectedValueChanged);
            // 
            // lVerses
            // 
            this.lVerses.AutoSize = true;
            this.lVerses.Location = new System.Drawing.Point(298, 1);
            this.lVerses.Name = "lVerses";
            this.lVerses.Size = new System.Drawing.Size(39, 13);
            this.lVerses.TabIndex = 22;
            this.lVerses.Text = "Ve&rses";
            // 
            // cVerses
            // 
            this.cVerses.FormattingEnabled = true;
            this.cVerses.Items.AddRange(new object[] {
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
            this.cVerses.Location = new System.Drawing.Point(295, 17);
            this.cVerses.Name = "cVerses";
            this.cVerses.Size = new System.Drawing.Size(56, 21);
            this.cVerses.TabIndex = 21;
            this.cVerses.SelectedValueChanged += new System.EventHandler(this.cVerses_SelectedValueChanged);
            // 
            // lBook
            // 
            this.lBook.AutoSize = true;
            this.lBook.Location = new System.Drawing.Point(89, 1);
            this.lBook.Name = "lBook";
            this.lBook.Size = new System.Drawing.Size(32, 13);
            this.lBook.TabIndex = 18;
            this.lBook.Text = "&Book";
            // 
            // lStart
            // 
            this.lStart.AutoSize = true;
            this.lStart.Location = new System.Drawing.Point(236, 1);
            this.lStart.Name = "lStart";
            this.lStart.Size = new System.Drawing.Size(59, 13);
            this.lStart.TabIndex = 17;
            this.lStart.Text = "&Start Verse";
            // 
            // lChapter
            // 
            this.lChapter.AutoSize = true;
            this.lChapter.Location = new System.Drawing.Point(174, 1);
            this.lChapter.Name = "lChapter";
            this.lChapter.Size = new System.Drawing.Size(44, 13);
            this.lChapter.TabIndex = 16;
            this.lChapter.Text = "&Chapter";
            // 
            // cStart
            // 
            this.cStart.FormattingEnabled = true;
            this.cStart.Location = new System.Drawing.Point(233, 17);
            this.cStart.Name = "cStart";
            this.cStart.Size = new System.Drawing.Size(56, 21);
            this.cStart.TabIndex = 15;
            this.cStart.SelectedValueChanged += new System.EventHandler(this.cStart_SelectedValueChanged);
            // 
            // cChapter
            // 
            this.cChapter.FormattingEnabled = true;
            this.cChapter.Location = new System.Drawing.Point(171, 17);
            this.cChapter.Name = "cChapter";
            this.cChapter.Size = new System.Drawing.Size(56, 21);
            this.cChapter.TabIndex = 14;
            this.cChapter.SelectedValueChanged += new System.EventHandler(this.cChapter_SelectedValueChanged);
            // 
            // cBooks
            // 
            this.cBooks.FormattingEnabled = true;
            this.cBooks.Location = new System.Drawing.Point(87, 17);
            this.cBooks.Name = "cBooks";
            this.cBooks.Size = new System.Drawing.Size(78, 21);
            this.cBooks.TabIndex = 13;
            this.cBooks.SelectedValueChanged += new System.EventHandler(this.cBooks_SelectedValueChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 41);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(484, 445);
            this.webBrowser1.TabIndex = 25;
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bSave.Location = new System.Drawing.Point(357, 15);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(60, 23);
            this.bSave.TabIndex = 26;
            this.bSave.Text = "&Save";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(421, 15);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(60, 23);
            this.bCancel.TabIndex = 27;
            this.bCancel.Text = "&Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bCancel);
            this.panel1.Controls.Add(this.bSave);
            this.panel1.Controls.Add(this.lVersion);
            this.panel1.Controls.Add(this.cVersion);
            this.panel1.Controls.Add(this.cBooks);
            this.panel1.Controls.Add(this.lVerses);
            this.panel1.Controls.Add(this.cChapter);
            this.panel1.Controls.Add(this.cVerses);
            this.panel1.Controls.Add(this.cStart);
            this.panel1.Controls.Add(this.lChapter);
            this.panel1.Controls.Add(this.lStart);
            this.panel1.Controls.Add(this.lBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 41);
            this.panel1.TabIndex = 28;
            // 
            // SelectVerses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 486);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(500, 525);
            this.Name = "SelectVerses";
            this.Text = "Select Vesres";
            this.Load += new System.EventHandler(this.selectVerses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.ComboBox cVersion;
        private System.Windows.Forms.Label lVerses;
        private System.Windows.Forms.ComboBox cVerses;
        private System.Windows.Forms.Label lBook;
        private System.Windows.Forms.Label lStart;
        private System.Windows.Forms.Label lChapter;
        private System.Windows.Forms.ComboBox cStart;
        private System.Windows.Forms.ComboBox cChapter;
        private System.Windows.Forms.ComboBox cBooks;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Panel panel1;
    }
}