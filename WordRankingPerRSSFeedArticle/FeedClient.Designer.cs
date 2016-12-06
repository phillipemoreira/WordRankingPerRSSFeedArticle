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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.gbFeedAddress = new System.Windows.Forms.GroupBox();
            this.txtFeedURI = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.gbFeeds = new System.Windows.Forms.GroupBox();
            this.lvFeeds = new System.Windows.Forms.ListView();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbContent = new System.Windows.Forms.GroupBox();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.gbRelevantWords = new System.Windows.Forms.GroupBox();
            this.lvWordArticle = new System.Windows.Forms.ListView();
            this.Article = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AppearnceCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRelevantWords = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbFeedAddress.SuspendLayout();
            this.gbFeeds.SuspendLayout();
            this.gbContent.SuspendLayout();
            this.gbRelevantWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFeedAddress
            // 
            this.gbFeedAddress.Controls.Add(this.txtFeedURI);
            this.gbFeedAddress.Controls.Add(this.btnRead);
            this.gbFeedAddress.Location = new System.Drawing.Point(13, 13);
            this.gbFeedAddress.Name = "gbFeedAddress";
            this.gbFeedAddress.Size = new System.Drawing.Size(1349, 56);
            this.gbFeedAddress.TabIndex = 0;
            this.gbFeedAddress.TabStop = false;
            this.gbFeedAddress.Text = "Feed Address";
            // 
            // txtFeedURI
            // 
            this.txtFeedURI.Location = new System.Drawing.Point(7, 21);
            this.txtFeedURI.Name = "txtFeedURI";
            this.txtFeedURI.Size = new System.Drawing.Size(1245, 20);
            this.txtFeedURI.TabIndex = 1;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(1268, 19);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // gbFeeds
            // 
            this.gbFeeds.Controls.Add(this.lvFeeds);
            this.gbFeeds.Location = new System.Drawing.Point(13, 75);
            this.gbFeeds.Name = "gbFeeds";
            this.gbFeeds.Size = new System.Drawing.Size(515, 350);
            this.gbFeeds.TabIndex = 1;
            this.gbFeeds.TabStop = false;
            this.gbFeeds.Text = "Feeds";
            // 
            // lvFeeds
            // 
            this.lvFeeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.date});
            this.lvFeeds.FullRowSelect = true;
            this.lvFeeds.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.lvFeeds.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lvFeeds.Location = new System.Drawing.Point(7, 20);
            this.lvFeeds.Name = "lvFeeds";
            this.lvFeeds.Size = new System.Drawing.Size(502, 320);
            this.lvFeeds.TabIndex = 0;
            this.lvFeeds.UseCompatibleStateImageBehavior = false;
            this.lvFeeds.View = System.Windows.Forms.View.List;
            this.lvFeeds.SelectedIndexChanged += new System.EventHandler(this.lvFeeds_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.Text = "Título";
            this.title.Width = 420;
            // 
            // date
            // 
            this.date.Text = "Data";
            // 
            // gbContent
            // 
            this.gbContent.Controls.Add(this.browser);
            this.gbContent.Location = new System.Drawing.Point(534, 75);
            this.gbContent.Name = "gbContent";
            this.gbContent.Size = new System.Drawing.Size(828, 706);
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
            this.browser.Size = new System.Drawing.Size(822, 687);
            this.browser.TabIndex = 0;
            // 
            // gbRelevantWords
            // 
            this.gbRelevantWords.Controls.Add(this.lvRelevantWords);
            this.gbRelevantWords.Controls.Add(this.lvWordArticle);
            this.gbRelevantWords.Location = new System.Drawing.Point(13, 431);
            this.gbRelevantWords.Name = "gbRelevantWords";
            this.gbRelevantWords.Size = new System.Drawing.Size(515, 350);
            this.gbRelevantWords.TabIndex = 3;
            this.gbRelevantWords.TabStop = false;
            this.gbRelevantWords.Text = "5 Most relevant words";
            // 
            // lvWordArticle
            // 
            this.lvWordArticle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Article,
            this.AppearnceCount});
            this.lvWordArticle.FullRowSelect = true;
            this.lvWordArticle.GridLines = true;
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup1";
            this.lvWordArticle.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
            this.lvWordArticle.Location = new System.Drawing.Point(123, 19);
            this.lvWordArticle.Name = "lvWordArticle";
            this.lvWordArticle.Size = new System.Drawing.Size(385, 325);
            this.lvWordArticle.TabIndex = 0;
            this.lvWordArticle.UseCompatibleStateImageBehavior = false;
            this.lvWordArticle.View = System.Windows.Forms.View.List;
            // 
            // Article
            // 
            this.Article.Text = "Título";
            this.Article.Width = 320;
            // 
            // AppearnceCount
            // 
            this.AppearnceCount.Text = "Data";
            // 
            // lvRelevantWords
            // 
            this.lvRelevantWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvRelevantWords.FullRowSelect = true;
            this.lvRelevantWords.GridLines = true;
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            this.lvRelevantWords.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.lvRelevantWords.Location = new System.Drawing.Point(7, 19);
            this.lvRelevantWords.Name = "lvRelevantWords";
            this.lvRelevantWords.Size = new System.Drawing.Size(110, 325);
            this.lvRelevantWords.TabIndex = 1;
            this.lvRelevantWords.UseCompatibleStateImageBehavior = false;
            this.lvRelevantWords.View = System.Windows.Forms.View.List;
            this.lvRelevantWords.SelectedIndexChanged += new System.EventHandler(this.lvRelevantWords_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Título";
            this.columnHeader3.Width = 420;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data";
            // 
            // FeedClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 787);
            this.Controls.Add(this.gbRelevantWords);
            this.Controls.Add(this.gbContent);
            this.Controls.Add(this.gbFeeds);
            this.Controls.Add(this.gbFeedAddress);
            this.Name = "FeedClient";
            this.Text = "RSS Feed reader";
            this.Load += new System.EventHandler(this.FeedClient_Load);
            this.gbFeedAddress.ResumeLayout(false);
            this.gbFeedAddress.PerformLayout();
            this.gbFeeds.ResumeLayout(false);
            this.gbContent.ResumeLayout(false);
            this.gbRelevantWords.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFeedAddress;
        private System.Windows.Forms.TextBox txtFeedURI;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox gbFeeds;
        private System.Windows.Forms.ListView lvFeeds;
        private System.Windows.Forms.GroupBox gbContent;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.GroupBox gbRelevantWords;
        private System.Windows.Forms.ListView lvWordArticle;
        private System.Windows.Forms.ColumnHeader Article;
        private System.Windows.Forms.ColumnHeader AppearnceCount;
        private System.Windows.Forms.ListView lvRelevantWords;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

