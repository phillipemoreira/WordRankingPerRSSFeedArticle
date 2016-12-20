using System.Collections.Generic;

namespace RSSTools
{
    public class AppearanceCountWordArticle
    {
        public string ArticleTitle;
        public int NumberOfTimesInArticle;
    }

    /// <summary>
    /// The representation of an word present in the feed's articles.
    /// </summary>
    public class Word
    {
        /// <summary>
        /// The actual word.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// The total of times the word appeared in the feed.
        /// </summary>
        public int AppearanceCount { get; }

        /// <summary>
        /// Returns the appearnce count of the word in each of the feeds article.
        /// </summary>
        public List<AppearanceCountWordArticle> AppearanceCountPerArticle { get; }

        internal Word (string text)
        {
            this.Text = text;
            AppearanceCountPerArticle = new List<AppearanceCountWordArticle>();
        }

        internal void AddArticleAppearance(string articleTittle, int appearanceCount)
        {
            AppearanceCountPerArticle.Add(new AppearanceCountWordArticle() { ArticleTitle= articleTittle, NumberOfTimesInArticle = appearanceCount });
        }
    }
}
