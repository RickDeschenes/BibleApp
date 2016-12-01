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
            this.bCancel = new System.Windows.Forms.Button();
            this.bProcess = new System.Windows.Forms.Button();
            this.lDetails = new System.Windows.Forms.Label();
            this.pControls = new System.Windows.Forms.Panel();
            this.lVersions = new System.Windows.Forms.Label();
            this.pVersions = new System.Windows.Forms.ProgressBar();
            this.lBooks = new System.Windows.Forms.Label();
            this.pBooks = new System.Windows.Forms.ProgressBar();
            this.lChapters = new System.Windows.Forms.Label();
            this.pChapters = new System.Windows.Forms.ProgressBar();
            this.bVersions = new System.Windows.Forms.Button();
            this.cVersions = new System.Windows.Forms.CheckedListBox();
            this.pVersion = new System.Windows.Forms.Panel();
            this.rResults = new System.Windows.Forms.RichTextBox();
            this.tPath = new System.Windows.Forms.TextBox();
            this.lOutput = new System.Windows.Forms.Label();
            this.bBrowse = new System.Windows.Forms.Button();
            this.pBrowse = new System.Windows.Forms.Panel();
            this.pControls.SuspendLayout();
            this.pVersion.SuspendLayout();
            this.pBrowse.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(621, 0);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "&Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bProcess
            // 
            this.bProcess.Enabled = false;
            this.bProcess.Location = new System.Drawing.Point(540, 0);
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
            this.lDetails.Location = new System.Drawing.Point(0, 5);
            this.lDetails.Name = "lDetails";
            this.lDetails.Size = new System.Drawing.Size(426, 13);
            this.lDetails.TabIndex = 3;
            this.lDetails.Text = "Select each version to process and click Process to output Version:Book:Chapter:V" +
    "erses";
            // 
            // pControls
            // 
            this.pControls.Controls.Add(this.lOutput);
            this.pControls.Controls.Add(this.pBrowse);
            this.pControls.Controls.Add(this.lVersions);
            this.pControls.Controls.Add(this.pVersions);
            this.pControls.Controls.Add(this.lBooks);
            this.pControls.Controls.Add(this.pBooks);
            this.pControls.Controls.Add(this.lChapters);
            this.pControls.Controls.Add(this.pChapters);
            this.pControls.Controls.Add(this.lDetails);
            this.pControls.Controls.Add(this.bCancel);
            this.pControls.Controls.Add(this.bProcess);
            this.pControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControls.Location = new System.Drawing.Point(91, 0);
            this.pControls.Name = "pControls";
            this.pControls.Size = new System.Drawing.Size(699, 132);
            this.pControls.TabIndex = 5;
            // 
            // lVersions
            // 
            this.lVersions.AutoSize = true;
            this.lVersions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lVersions.Location = new System.Drawing.Point(0, 54);
            this.lVersions.Name = "lVersions";
            this.lVersions.Size = new System.Drawing.Size(73, 13);
            this.lVersions.TabIndex = 9;
            this.lVersions.Text = "Version status";
            // 
            // pVersions
            // 
            this.pVersions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pVersions.Location = new System.Drawing.Point(0, 67);
            this.pVersions.Name = "pVersions";
            this.pVersions.Size = new System.Drawing.Size(699, 13);
            this.pVersions.TabIndex = 8;
            // 
            // lBooks
            // 
            this.lBooks.AutoSize = true;
            this.lBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lBooks.Location = new System.Drawing.Point(0, 80);
            this.lBooks.Name = "lBooks";
            this.lBooks.Size = new System.Drawing.Size(68, 13);
            this.lBooks.TabIndex = 7;
            this.lBooks.Text = "Books status";
            // 
            // pBooks
            // 
            this.pBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBooks.Location = new System.Drawing.Point(0, 93);
            this.pBooks.Name = "pBooks";
            this.pBooks.Size = new System.Drawing.Size(699, 13);
            this.pBooks.TabIndex = 6;
            // 
            // lChapters
            // 
            this.lChapters.AutoSize = true;
            this.lChapters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lChapters.Location = new System.Drawing.Point(0, 106);
            this.lChapters.Name = "lChapters";
            this.lChapters.Size = new System.Drawing.Size(80, 13);
            this.lChapters.TabIndex = 5;
            this.lChapters.Text = "Chapters status";
            // 
            // pChapters
            // 
            this.pChapters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pChapters.Location = new System.Drawing.Point(0, 119);
            this.pChapters.Name = "pChapters";
            this.pChapters.Size = new System.Drawing.Size(699, 13);
            this.pChapters.TabIndex = 4;
            // 
            // bVersions
            // 
            this.bVersions.Dock = System.Windows.Forms.DockStyle.Top;
            this.bVersions.Location = new System.Drawing.Point(0, 0);
            this.bVersions.Name = "bVersions";
            this.bVersions.Size = new System.Drawing.Size(91, 23);
            this.bVersions.TabIndex = 10;
            this.bVersions.Text = "&Versions";
            this.bVersions.UseVisualStyleBackColor = true;
            // 
            // cVersions
            // 
            this.cVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cVersions.FormattingEnabled = true;
            this.cVersions.Location = new System.Drawing.Point(0, 23);
            this.cVersions.Name = "cVersions";
            this.cVersions.Size = new System.Drawing.Size(91, 467);
            this.cVersions.TabIndex = 11;
            this.cVersions.SelectedIndexChanged += new System.EventHandler(this.cVersions_SelectedIndexChanged);
            // 
            // pVersion
            // 
            this.pVersion.Controls.Add(this.cVersions);
            this.pVersion.Controls.Add(this.bVersions);
            this.pVersion.Dock = System.Windows.Forms.DockStyle.Left;
            this.pVersion.Location = new System.Drawing.Point(0, 0);
            this.pVersion.Name = "pVersion";
            this.pVersion.Size = new System.Drawing.Size(91, 490);
            this.pVersion.TabIndex = 12;
            // 
            // rResults
            // 
            this.rResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rResults.Location = new System.Drawing.Point(91, 132);
            this.rResults.Name = "rResults";
            this.rResults.Size = new System.Drawing.Size(699, 358);
            this.rResults.TabIndex = 10;
            this.rResults.Text = "";
            // 
            // tPath
            // 
            this.tPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tPath.Location = new System.Drawing.Point(0, 0);
            this.tPath.Name = "tPath";
            this.tPath.Size = new System.Drawing.Size(672, 20);
            this.tPath.TabIndex = 10;
            this.tPath.Text = "D:\\Bibles\\";
            this.tPath.TextChanged += new System.EventHandler(this.tPath_TextChanged);
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lOutput.Location = new System.Drawing.Point(0, 21);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(98, 13);
            this.lOutput.TabIndex = 13;
            this.lOutput.Text = "Set an output path:";
            // 
            // bBrowse
            // 
            this.bBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowse.Location = new System.Drawing.Point(671, 0);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(25, 20);
            this.bBrowse.TabIndex = 14;
            this.bBrowse.Text = "...";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // pBrowse
            // 
            this.pBrowse.Controls.Add(this.bBrowse);
            this.pBrowse.Controls.Add(this.tPath);
            this.pBrowse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBrowse.Location = new System.Drawing.Point(0, 34);
            this.pBrowse.Name = "pBrowse";
            this.pBrowse.Size = new System.Drawing.Size(699, 20);
            this.pBrowse.TabIndex = 13;
            // 
            // TotalVerses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 490);
            this.Controls.Add(this.rResults);
            this.Controls.Add(this.pControls);
            this.Controls.Add(this.pVersion);
            this.Name = "TotalVerses";
            this.Text = "TotalVerses";
            this.Load += new System.EventHandler(this.TotalVerses_Load);
            this.pControls.ResumeLayout(false);
            this.pControls.PerformLayout();
            this.pVersion.ResumeLayout(false);
            this.pBrowse.ResumeLayout(false);
            this.pBrowse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bProcess;
        private System.Windows.Forms.Label lDetails;
        private System.Windows.Forms.Panel pControls;
        private System.Windows.Forms.ProgressBar pChapters;
        private System.Windows.Forms.Label lChapters;
        private System.Windows.Forms.Label lVersions;
        private System.Windows.Forms.ProgressBar pVersions;
        private System.Windows.Forms.Label lBooks;
        private System.Windows.Forms.ProgressBar pBooks;
        private System.Windows.Forms.CheckedListBox cVersions;
        private System.Windows.Forms.Button bVersions;
        private System.Windows.Forms.Panel pVersion;
        private System.Windows.Forms.Label lOutput;
        private System.Windows.Forms.RichTextBox rResults;
        private System.Windows.Forms.TextBox tPath;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.Panel pBrowse;
    }
}