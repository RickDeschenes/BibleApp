namespace AnotherBibleApp
{
    partial class MyBible
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.passage1 = new AnotherBibleApp.Passage();
            this.passage2 = new AnotherBibleApp.Passage();
            this.lTitle = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 32);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.passage1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.passage2);
            this.splitContainer2.Size = new System.Drawing.Size(720, 545);
            this.splitContainer2.SplitterDistance = 351;
            this.splitContainer2.TabIndex = 0;
            // 
            // passage1
            // 
            this.passage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passage1.Location = new System.Drawing.Point(0, 0);
            this.passage1.MyProperty = 0;
            this.passage1.Name = "passage1";
            this.passage1.Size = new System.Drawing.Size(351, 545);
            this.passage1.TabIndex = 0;
            // 
            // passage2
            // 
            this.passage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passage2.Location = new System.Drawing.Point(0, 0);
            this.passage2.MyProperty = 0;
            this.passage2.Name = "passage2";
            this.passage2.Size = new System.Drawing.Size(365, 545);
            this.passage2.TabIndex = 0;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Location = new System.Drawing.Point(3, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(319, 13);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Welcome to My Bible Tools, Used to seach and read the striptures";
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(642, 4);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "&Close";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bClose);
            this.panel3.Controls.Add(this.lTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 32);
            this.panel3.TabIndex = 3;
            // 
            // MyBible
            // 
            this.ClientSize = new System.Drawing.Size(720, 577);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.panel3);
            this.Name = "MyBible";
            this.Text = "My Bible Tools";
            this.Load += new System.EventHandler(this.MyBible_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Panel panel3;
        private Passage passage1;
        private Passage passage2;
    }
}

