using System;
using System.Collections.Generic;

namespace RSSTools
{
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
        /// Returns the appearnce count of the word in each of the feeds article.
        /// </summary>
        public Dictionary<string, int> AppearanceCountPerArticle { get; }

        internal Word (string text)
        {
            this.Text = text;
            AppearanceCountPerArticle = new Dictionary<string, int>();
        }

        internal void AddArticleAppearance(string articleTittle, int appearanceCount)
        {
            if (!AppearanceCountPerArticle.ContainsKey(articleTittle))
            {
                AppearanceCountPerArticle.Add(articleTittle, appearanceCount);
            }
            else
            {
                throw new Exception("Article '{0}' was already taken into account");
            }
        }
    }
}
