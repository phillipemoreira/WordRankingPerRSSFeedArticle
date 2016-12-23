namespace WordRankingPerRSSFeedArticle
{
    partial class FeedClient
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
            this.gbFeed = new System.Windows.Forms.GroupBox();
            this.rbPOSTagging = new System.Windows.Forms.RadioButton();
            this.rbExclusionList = new System.Windows.Forms.RadioButton();
            this.lblIdentifyingMethod = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtFeedURI = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.gbContent = new System.Windows.Forms.GroupBox();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.gbRelevantWords = new System.Windows.Forms.GroupBox();
            this.btnIdendify = new System.Windows.Forms.Button();
            this.txtNumberOfWords = new System.Windows.Forms.TextBox();
            this.lblNumberOfWords = new System.Windows.Forms.Label();
            this.lvRelevantWords = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvWordArticle = new System.Windows.Forms.ListView();
            this.AppearanceCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbAppearingPerArticle = new System.Windows.Forms.GroupBox();
            this.lvArticles = new System.Windows.Forms.ListView();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbFeed.SuspendLayout();
            this.gbContent.SuspendLayout();
            this.gbRelevantWords.SuspendLayout();
            this.gbAppearingPerArticle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFeed
            // 
            this.gbFeed.Controls.Add(this.rbPOSTagging);
            this.gbFeed.Controls.Add(this.rbExclusionList);
            this.gbFeed.Controls.Add(this.lblIdentifyingMethod);
            this.gbFeed.Controls.Add(this.lblAddress);
            this.gbFeed.Controls.Add(this.txtFeedURI);
            this.gbFeed.Controls.Add(this.btnRead);
            this.gbFeed.Location = new System.Drawing.Point(13, 13);
            this.gbFeed.Name = "gbFeed";
            this.gbFeed.Size = new System.Drawing.Size(959, 92);
            this.gbFeed.TabIndex = 0;
            this.gbFeed.TabStop = false;
            this.gbFeed.Text = "Feed";
            // 
            // rbPOSTagging
            // 
            this.rbPOSTagging.AutoSize = true;
            this.rbPOSTagging.Enabled = false;
            this.rbPOSTagging.Location = new System.Drawing.Point(199, 53);
            this.rbPOSTagging.Name = "rbPOSTagging";
            this.rbPOSTagging.Size = new System.Drawing.Size(89, 17);
            this.rbPOSTagging.TabIndex = 5;
            this.rbPOSTagging.Text = "POS Tagging";
            this.rbPOSTagging.UseVisualStyleBackColor = true;
            // 
            // rbExclusionList
            // 
            this.rbExclusionList.AutoSize = true;
            this.rbExclusionList.Checked = true;
            this.rbExclusionList.Enabled = false;
            this.rbExclusionList.Location = new System.Drawing.Point(108, 53);
            this.rbExclusionList.Name = "rbExclusionList";
            this.rbExclusionList.Size = new System.Drawing.Size(85, 17);
            this.rbExclusionList.TabIndex = 4;
            this.rbExclusionList.TabStop = true;
            this.rbExclusionList.Text = "Exclusion list";
            this.rbExclusionList.UseVisualStyleBackColor = true;
            // 
            // lblIdentifyingMethod
            // 
            this.lblIdentifyingMethod.AutoSize = true;
            this.lblIdentifyingMethod.Location = new System.Drawing.Point(6, 55);
            this.lblIdentifyingMethod.Name = "lblIdentifyingMethod";
            this.lblIdentifyingMethod.Size = new System.Drawing.Size(96, 13);
            this.lblIdentifyingMethod.TabIndex = 3;
            this.lblIdentifyingMethod.Text = "Identifying method:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 24);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // txtFeedURI
            // 
            this.txtFeedURI.Location = new System.Drawing.Point(60, 21);
            this.txtFeedURI.Name = "txtFeedURI";
            this.txtFeedURI.Size = new System.Drawing.Size(812, 20);
            this.txtFeedURI.TabIndex = 1;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(878, 63);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // gbContent
            // 
            this.gbContent.Controls.Add(this.browser);
            this.gbContent.Location = new System.Drawing.Point(13, 477);
            this.gbContent.Name = "gbContent";
            this.gbContent.Size = new System.Drawing.Size(959, 273);
            this.gbContent.TabIndex = 2;
            this.gbContent.TabStop = false;
            this.gbContent.Text = "Content";
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(3, 16);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(953, 254);
            this.browser.TabIndex = 0;
            // 
            // gbRelevantWords
            // 
            this.gbRelevantWords.Controls.Add(this.btnIdendify);
            this.gbRelevantWords.Controls.Add(this.txtNumberOfWords);
            this.gbRelevantWords.Controls.Add(this.lblNumberOfWords);
            this.gbRelevantWords.Controls.Add(this.lvRelevantWords);
            this.gbRelevantWords.Location = new System.Drawing.Point(13, 111);
            this.gbRelevantWords.Name = "gbRelevantWords";
            this.gbRelevantWords.Size = new System.Drawing.Size(217, 360);
            this.gbRelevantWords.TabIndex = 3;
            this.gbRelevantWords.TabStop = false;
            this.gbRelevantWords.Text = "Relevant words";
            // 
            // btnIdendify
            // 
            this.btnIdendify.Enabled = false;
            this.btnIdendify.Location = new System.Drawing.Point(154, 24);
            this.btnIdendify.Name = "btnIdendify";
            this.btnIdendify.Size = new System.Drawing.Size(57, 23);
            this.btnIdendify.TabIndex = 4;
            this.btnIdendify.Text = "Identify";
            this.btnIdendify.UseVisualStyleBackColor = true;
            this.btnIdendify.Click += new System.EventHandler(this.btnIdendify_Click);
            // 
            // txtNumberOfWords
            // 
            this.txtNumberOfWords.Location = new System.Drawing.Point(99, 26);
            this.txtNumberOfWords.Name = "txtNumberOfWords";
            this.txtNumberOfWords.Size = new System.Drawing.Size(36, 20);
            this.txtNumberOfWords.TabIndex = 3;
            // 
            // lblNumberOfWords
            // 
            this.lblNumberOfWords.AutoSize = true;
            this.lblNumberOfWords.Location = new System.Drawing.Point(3, 29);
            this.lblNumberOfWords.Name = "lblNumberOfWords";
            this.lblNumberOfWords.Size = new System.Drawing.Size(90, 13);
            this.lblNumberOfWords.TabIndex = 2;
            this.lblNumberOfWords.Text = "Number of words:";
            // 
            // lvRelevantWords
            // 
            this.lvRelevantWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvRelevantWords.FullRowSelect = true;
            this.lvRelevantWords.GridLines = true;
            this.lvRelevantWords.Location = new System.Drawing.Point(6, 52);
            this.lvRelevantWords.Name = "lvRelevantWords";
            this.lvRelevantWords.Size = new System.Drawing.Size(205, 302);
            this.lvRelevantWords.TabIndex = 1;
            this.lvRelevantWords.UseCompatibleStateImageBehavior = false;
            this.lvRelevantWords.View = System.Windows.Forms.View.Details;
            this.lvRelevantWords.SelectedIndexChanged += new System.EventHandler(this.lvRelevantWords_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Word";
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total count";
            this.columnHeader4.Width = 83;
            // 
            // lvWordArticle
            // 
            this.lvWordArticle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AppearanceCount});
            this.lvWordArticle.FullRowSelect = true;
            this.lvWordArticle.GridLines = true;
            this.lvWordArticle.Location = new System.Drawing.Point(6, 26);
            this.lvWordArticle.Name = "lvWordArticle";
            this.lvWordArticle.Size = new System.Drawing.Size(144, 328);
            this.lvWordArticle.TabIndex = 0;
            this.lvWordArticle.UseCompatibleStateImageBehavior = false;
            this.lvWordArticle.View = System.Windows.Forms.View.Details;
            this.lvWordArticle.SelectedIndexChanged += new System.EventHandler(this.lvWordArticle_SelectedIndexChanged);
            // 
            // AppearanceCount
            // 
            this.AppearanceCount.Text = "Appearance count";
            this.AppearanceCount.Width = 132;
            // 
            // gbAppearingPerArticle
            // 
            this.gbAppearingPerArticle.Controls.Add(this.lvArticles);
            this.gbAppearingPerArticle.Controls.Add(this.lvWordArticle);
            this.gbAppearingPerArticle.Location = new System.Drawing.Point(236, 111);
            this.gbAppearingPerArticle.Name = "gbAppearingPerArticle";
            this.gbAppearingPerArticle.Size = new System.Drawing.Size(736, 360);
            this.gbAppearingPerArticle.TabIndex = 4;
            this.gbAppearingPerArticle.TabStop = false;
            this.gbAppearingPerArticle.Text = "Appearing count per article";
            // 
            // lvArticles
            // 
            this.lvArticles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.date});
            this.lvArticles.FullRowSelect = true;
            this.lvArticles.GridLines = true;
            this.lvArticles.Location = new System.Drawing.Point(150, 26);
            this.lvArticles.Name = "lvArticles";
            this.lvArticles.Size = new System.Drawing.Size(569, 328);
            this.lvArticles.TabIndex = 1;
            this.lvArticles.UseCompatibleStateImageBehavior = false;
            this.lvArticles.View = System.Windows.Forms.View.Details;
            this.lvArticles.SelectedIndexChanged += new System.EventHandler(this.lvArticles_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 427;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 137;
            // 
            // FeedClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.gbAppearingPerArticle);
            this.Controls.Add(this.gbRelevantWords);
            this.Controls.Add(this.gbContent);
            this.Controls.Add(this.gbFeed);
            this.Name = "FeedClient";
            this.Text = "RSS Feed reader";
            this.Load += new System.EventHandler(this.FeedClient_Load);
            this.gbFeed.ResumeLayout(false);
            this.gbFeed.PerformLayout();
            this.gbContent.ResumeLayout(false);
            this.gbRelevantWords.ResumeLayout(false);
            this.gbRelevantWords.PerformLayout();
            this.gbAppearingPerArticle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFeed;
        private System.Windows.Forms.TextBox txtFeedURI;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox gbContent;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.GroupBox gbRelevantWords;
        private System.Windows.Forms.ListView lvWordArticle;
        private System.Windows.Forms.ColumnHeader AppearanceCount;
        private System.Windows.Forms.ListView lvRelevantWords;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton rbPOSTagging;
        private System.Windows.Forms.RadioButton rbExclusionList;
        private System.Windows.Forms.Label lblIdentifyingMethod;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnIdendify;
        private System.Windows.Forms.TextBox txtNumberOfWords;
        private System.Windows.Forms.Label lblNumberOfWords;
        private System.Windows.Forms.GroupBox gbAppearingPerArticle;
        private System.Windows.Forms.ListView lvArticles;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader date;
    }
}

