using System;
using System.Collections.Generic;

namespace RSSTools
{
    /// <summary>
    /// Parsed representation of a RSS feed.
    /// </summary>
    public class Feed
    {
        /// <summary>
        /// The title of the feed.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// The link to the address where the feed belongs to.
        /// </summary>
        public string Link { get; }

        /// <summary>
        /// The description of the feed.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The articles of the feed.
        /// </summary>
        public List<Article> Articles { get; }

        internal Feed(string title, string link, string description)
        {
            this.Title = title;
            this.Link = link;
            this.Description = description;

            Articles = new List<Article>();
        }
    }
}
