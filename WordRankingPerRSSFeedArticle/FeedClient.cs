using System;
using System.Windows.Forms;
using RSSTools;

namespace WordRankingPerRSSFeedArticle
{
    public partial class FeedClient : Form
    {
        RSSReader reader;

        public FeedClient()
        {
            InitializeComponent();
        }

        private void FeedClient_Load(object sender, EventArgs e)
        {
            txtFeedURI.Text = "http://feeds.arstechnica.com/arstechnica/technology-lab";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                var feedURI = txtFeedURI.Text;
                reader = RSSReader.Read(txtFeedURI.Text);

                this.FillControls();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillControls()
        {
            this.FillFeedListView();
        }

        private void FillFeedListView()
        {
            var articles = reader.Articles;
            foreach (var article in articles)
            {
                var row = new ListViewItem();
                row.Text = article.Title;
                row.SubItems.Add(article.Link);
                row.SubItems.Add(article.Date.ToShortDateString());
                lvFeeds.Items.Add(row);
            }
        }
    }
}
