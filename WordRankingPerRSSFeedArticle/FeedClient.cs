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
            //txtFeedURI.Text = @"C:\Users\phillipe\Documents\GitHub\WordRankingPerRSSFeedArticle\RSSToolsTests\RSSFeeds\simpleFeed.xml";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                lvArticles.Items.Clear();
                lvWordArticle.Items.Clear();
                lvRelevantWords.Items.Clear();

                var feedURI = txtFeedURI.Text;
                reader = RSSReader.Read(txtFeedURI.Text);
                feed = reader.Feed;

                this.FillControls();

                btnIdendify.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIdendify_Click(object sender, EventArgs e)
        {
            if (reader == null)
            {
                MessageBox.Show("First you need to load a feed.");
            }
            else
            {
                try
                {
                    var numberOfRelevantTherms = Convert.ToInt32(txtNumberOfWords.Text);

                    mostRelevantWords = reader.GetMostRelevantWords(numberOfRelevantTherms);

                    this.FillRelevantWords(mostRelevantWords);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("An error occured: {0}", ex.Message));
                }
            }
        }

        private void lvArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView view = (ListView)sender;

            for (int i = 0; i < view.Items.Count; i++)
            {
                view.Items[i].BackColor = System.Drawing.Color.White;
            }

            if (view.SelectedItems.Count == 1)
            {
                browser.DocumentText = feed.Articles.Single(i => i.Title == view.SelectedItems[0].Text).EncodedContent;
            }
        }

        private void lvRelevantWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView view = (ListView)sender;

            lvWordArticle.Items.Clear();

            if (view.SelectedItems.Count == 1)
            {
                var word = mostRelevantWords.Single(a => a.Text == view.SelectedItems[0].Text);

                foreach (var item in word.AppearanceCountPerArticle)
                {
                    var row = new ListViewItem(item.NumberOfTimesInArticle.ToString());
                    row.SubItems.Add(item.ArticleTitle);
                    lvWordArticle.Items.Add(row);
                }
            }
        }

        private void lvWordArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView view = (ListView)sender;

            for (int i = 0; i < view.Items.Count; i++)
            {
                view.Items[i].BackColor = System.Drawing.Color.White;
            }

            for (int i = 0; i < lvArticles.Items.Count; i++)
            {
                lvArticles.Items[i].BackColor = System.Drawing.Color.White;
            }

            if (view.SelectedItems.Count == 1)
            {
                view.Items[view.SelectedIndices[0]].BackColor = System.Drawing.Color.Pink;

                var index = view.SelectedIndices[0];
                lvArticles.Items[index].BackColor = System.Drawing.Color.Pink;

                browser.DocumentText = feed.Articles.Single(i => i.Title == lvArticles.Items[index].Text).EncodedContent;
            }
        }

        #endregion

        #region private methods

        private void FillControls()
        {
            this.FillFeedListView();
        }

        private void FillFeedListView()
        {
            var articles = feed.Articles;
            foreach (var article in articles)
            {
                var row = new ListViewItem(article.Title);
                row.SubItems.Add(article.Date.ToShortDateString());
                lvArticles.Items.Add(row);
            }
        }

        private void FillRelevantWords(List<Word> words)
        {
            lvRelevantWords.Items.Clear();

            foreach (var word in words)
            {
                var row = new ListViewItem(word.Text);
                row.SubItems.Add(word.AppearanceCount.ToString());
                lvRelevantWords.Items.Add(row);
            }
        }

        #endregion


    }
}
