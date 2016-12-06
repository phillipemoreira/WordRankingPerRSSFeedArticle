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
            this.gbFeedAddress = new System.Windows.Forms.GroupBox();
            this.txtFeedURI = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.gbFeeds = new System.Windows.Forms.GroupBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.lvFeeds = new System.Windows.Forms.ListView();
            this.gbFeedAddress.SuspendLayout();
            this.gbFeeds.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFeedAddress
            // 
            this.gbFeedAddress.Controls.Add(this.txtFeedURI);
            this.gbFeedAddress.Controls.Add(this.btnRead);
            this.gbFeedAddress.Location = new System.Drawing.Point(13, 13);
            this.gbFeedAddress.Name = "gbFeedAddress";
            this.gbFeedAddress.Size = new System.Drawing.Size(850, 56);
            this.gbFeedAddress.TabIndex = 0;
            this.gbFeedAddress.TabStop = false;
            this.gbFeedAddress.Text = "Feed Address";
            // 
            // txtFeedURI
            // 
            this.txtFeedURI.Location = new System.Drawing.Point(7, 21);
            this.txtFeedURI.Name = "txtFeedURI";
            this.txtFeedURI.Size = new System.Drawing.Size(720, 20);
            this.txtFeedURI.TabIndex = 1;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(750, 19);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Carregar";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // gbFeeds
            // 
            this.gbFeeds.Controls.Add(this.rtbContent);
            this.gbFeeds.Controls.Add(this.lvFeeds);
            this.gbFeeds.Location = new System.Drawing.Point(13, 75);
            this.gbFeeds.Name = "gbFeeds";
            this.gbFeeds.Size = new System.Drawing.Size(849, 232);
            this.gbFeeds.TabIndex = 1;
            this.gbFeeds.TabStop = false;
            this.gbFeeds.Text = "Feeds";
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(425, 20);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(400, 200);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            // 
            // lvFeeds
            // 
            this.lvFeeds.GridLines = true;
            this.lvFeeds.Location = new System.Drawing.Point(7, 20);
            this.lvFeeds.Name = "lvFeeds";
            this.lvFeeds.Size = new System.Drawing.Size(400, 200);
            this.lvFeeds.TabIndex = 0;
            this.lvFeeds.UseCompatibleStateImageBehavior = false;
            // 
            // FeedClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 322);
            this.Controls.Add(this.gbFeeds);
            this.Controls.Add(this.gbFeedAddress);
            this.Name = "FeedClient";
            this.Text = "RSS Feed reader";
            this.Load += new System.EventHandler(this.FeedClient_Load);
            this.gbFeedAddress.ResumeLayout(false);
            this.gbFeedAddress.PerformLayout();
            this.gbFeeds.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFeedAddress;
        private System.Windows.Forms.TextBox txtFeedURI;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox gbFeeds;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.ListView lvFeeds;
    }
}

