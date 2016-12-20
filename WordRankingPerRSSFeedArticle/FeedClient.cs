using System;
using System.Windows.Forms;
using RSSTools;
using System.Linq;
using System.Collections.Generic;

namespace WordRankingPerRSSFeedArticle
{
    public partial class FeedClient : Form
    {
        RSSReader reader;
        Feed feed;
        List<Word> mostRelevantWords;

        #region constructor

        public FeedClient()
        {
            InitializeComponent();
        }

        #endregion

        #region events

        private void FeedClient_Load(object sender, EventArgs e)
        {
            txtFeedURI.Text = "http://feeds.arstechnica.com/arstechnica/technology-lab";
            txtFeedURI.Text = @"C:\Users\phillipe\Documents\GitHub\WordRankingPerRSSFeedArticle\RSSToolsTests\RSSFeeds\simpleFeed.xml";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                var feedURI = txtFeedURI.Text;
                reader = RSSReader.Read(txtFeedURI.Text);
                feed = reader.Feed;

                this.FillControls();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView view = (ListView)sender;

            if (view.SelectedItems.Count == 1)
            {
                browser.DocumentText = feed.Articles.Single(i => i.Title == view.SelectedItems[0].Text).EncodedContent;
            }
        }

        private void lvRelevantWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView view = (ListView)sender;

            lvWordArticle.Clear();

            if (view.SelectedItems.Count == 1)
            {
                var word = mostRelevantWords.Single(a => a.Text == view.SelectedItems[0].Text);

                foreach (var item in word.AppearanceCountPerArticle)
                {
                    var row = new ListViewItem(item.NumberOfTimesInArticle.ToString(), item.ArticleTitle);
                    lvWordArticle.Items.Add(row);
                }
            }
        }

        #endregion

        #region private methods

        private void FillControls()
        {
            this.FillFeedListView();
            this.FillRelevantWords();
        }

        private void FillFeedListView()
        {
            var articles = feed.Articles;
            foreach (var article in articles)
            {
                var row = new ListViewItem(article.Title, article.Date.ToShortDateString());
                lvFeeds.Items.Add(row);
            }
        }

        private void FillRelevantWords()
        {
            mostRelevantWords = reader.GetMostRelevantWords(5);
            foreach (var word in mostRelevantWords)
            {
                var row = new ListViewItem(word.Text);
                lvRelevantWords.Items.Add(row);
            }
        }

        #endregion  
    }
}
