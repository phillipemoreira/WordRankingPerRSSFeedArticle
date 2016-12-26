using System;
using System.Net;

namespace RSSTools
{
    /// <summary>
    /// Parsed representation of a RSS feed item.
    /// </summary>
    public class Article
    {
        /// <summary>
        /// The publication date of the article.
        /// </summary>
        public DateTime Date { get; }

        /// <summary>
        /// The title of the article.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// The description of the article.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The link to the article.
        /// </summary>
        public string Link { get; }

        /// <summary>
        /// The HTML formatted content of the article.
        /// </summary>
        public string EncodedContent { get; }

        /// <summary>
        /// The text only representation of the content of the article.
        /// </summary>
        public string PureTextContent { get; }

        internal Article(
            string date,
            string title,
            string description,
            string link,
            string encodedContent)
        {
            this.Date = Convert.ToDateTime(date);
            this.Title = title;
            this.Description = description;
            this.Link = link;
            this.EncodedContent = encodedContent;
            this.PureTextContent = StripText(encodedContent);
        }

        private string StripText(string text)
        {
            var decodedText = WebUtility.HtmlDecode(text);

            RegexHelper regexHelper = new RegexHelper(decodedText);

            regexHelper.RemoveLinks()
                .KeepOnlyHTMLParagraphs()
                .RemoveMarkup();

            return regexHelper.Text;
        }
    }
}
