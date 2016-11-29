namespace AnotherBibleApp
{
    partial class TotalVerses
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
            this.wResults = new System.Windows.Forms.WebBrowser();
            this.bCancel = new System.Windows.Forms.Button();
            this.bProcess = new System.Windows.Forms.Button();
            this.lDetails = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lVersions = new System.Windows.Forms.Label();
            this.pVersions = new System.Windows.Forms.ProgressBar();
            this.lBooks = new System.Windows.Forms.Label();
            this.pBooks = new System.Windows.Forms.ProgressBar();
            this.lChapters = new System.Windows.Forms.Label();
            this.pChapters = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wResults
            // 
            this.wResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wResults.Location = new System.Drawing.Point(0, 107);
            this.wResults.MinimumSize = new System.Drawing.Size(20, 20);
            this.wResults.Name = "wResults";
            this.wResults.Size = new System.Drawing.Size(790, 383);
            this.wResults.TabIndex = 0;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(703, 11);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "&Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bProcess
            // 
            this.bProcess.Location = new System.Drawing.Point(622, 11);
            this.bProcess.Name = "bProcess";
            this.bProcess.Size = new System.Drawing.Size(75, 23);
            this.bProcess.TabIndex = 2;
            this.bProcess.Text = "&Process";
            this.bProcess.UseVisualStyleBackColor = true;
            this.bProcess.Click += new System.EventHandler(this.bProcess_Click);
            // 
            // lDetails
            // 
            this.lDetails.AutoSize = true;
            this.lDetails.Location = new System.Drawing.Point(0, 11);
            this.lDetails.Name = "lDetails";
            this.lDetails.Size = new System.Drawing.Size(379, 13);
            this.lDetails.TabIndex = 3;
            this.lDetails.Text = "Press Process button to list each version by Version:Bible:Book:Chapter:Verses";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lVersions);
            this.panel1.Controls.Add(this.pVersions);
            this.panel1.Controls.Add(this.lBooks);
            this.panel1.Controls.Add(this.pBooks);
            this.panel1.Controls.Add(this.lChapters);
            this.panel1.Controls.Add(this.pChapters);
            this.panel1.Controls.Add(this.lDetails);
            this.panel1.Controls.Add(this.bCancel);
            this.panel1.Controls.Add(this.bProcess);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 107);
            this.panel1.TabIndex = 5;
            // 
            // lVersions
            // 
            this.lVersions.AutoSize = true;
            this.lVersions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lVersions.Location = new System.Drawing.Point(0, 29);
            this.lVersions.Name = "lVersions";
            this.lVersions.Size = new System.Drawing.Size(73, 13);
            this.lVersions.TabIndex = 9;
            this.lVersions.Text = "Version status";
            // 
            // pVersions
            // 
            this.pVersions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pVersions.Location = new System.Drawing.Point(0, 42);
            this.pVersions.Name = "pVersions";
            this.pVersions.Size = new System.Drawing.Size(790, 13);
            this.pVersions.TabIndex = 8;
            // 
            // lBooks
            // 
            this.lBooks.AutoSize = true;
            this.lBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lBooks.Location = new System.Drawing.Point(0, 55);
            this.lBooks.Name = "lBooks";
            this.lBooks.Size = new System.Drawing.Size(68, 13);
            this.lBooks.TabIndex = 7;
            this.lBooks.Text = "Books status";
            // 
            // pBooks
            // 
            this.pBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBooks.Location = new System.Drawing.Point(0, 68);
            this.pBooks.Name = "pBooks";
            this.pBooks.Size = new System.Drawing.Size(790, 13);
            this.pBooks.TabIndex = 6;
            // 
            // lChapters
            // 
            this.lChapters.AutoSize = true;
            this.lChapters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lChapters.Location = new System.Drawing.Point(0, 81);
            this.lChapters.Name = "lChapters";
            this.lChapters.Size = new System.Drawing.Size(80, 13);
            this.lChapters.TabIndex = 5;
            this.lChapters.Text = "Chapters status";
            // 
            // pChapters
            // 
            this.pChapters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pChapters.Location = new System.Drawing.Point(0, 94);
            this.pChapters.Name = "pChapters";
            this.pChapters.Size = new System.Drawing.Size(790, 13);
            this.pChapters.TabIndex = 4;
            // 
            // TotalVerses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 490);
            this.Controls.Add(this.wResults);
            this.Controls.Add(this.panel1);
            this.Name = "TotalVerses";
            this.Text = "TotalVerses";
            this.Load += new System.EventHandler(this.TotalVerses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wResults;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bProcess;
        private System.Windows.Forms.Label lDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar pChapters;
        private System.Windows.Forms.Label lChapters;
        private System.Windows.Forms.Label lVersions;
        private System.Windows.Forms.ProgressBar pVersions;
        private System.Windows.Forms.Label lBooks;
        private System.Windows.Forms.ProgressBar pBooks;
    }
}