using System;
using System.Collections.Generic;

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
        /// The content of the article.
        /// </summary>
        public string EncodedContent { get; }

        /// <summary>
        /// The list of relevant words present in the article.
        /// </summary>
        /// <remarks>
        /// Only nouns are considered relevant words,
        /// verbs, adjectives, adverbs, pronouns and prepositions
        /// won't be taken into account.
        /// </remarks>
        public List<Word> RelevantWords { get; }

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
        }
    }
}
