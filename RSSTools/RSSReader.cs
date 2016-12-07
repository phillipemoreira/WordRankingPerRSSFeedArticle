using System.Collections.Generic;
using RSSTools.Exceptions;

namespace RSSTools
{
    /// <summary>
    /// RSS feed reader.
    /// </summary>
    public class RSSReader
    {
        private Feed feed;

        private RSSReader(string feedURI)
        {
            this.FeedURI = feedURI;
            feed = XMLParser.ParseFeed(feedURI);
        }

        #region public API

        /// <summary>
        /// Returns the feed URI.
        /// </summary>
        public string FeedURI { get; }

        /// <summary>
        /// Returns a parsed represensation of the feed.
        /// </summary>
        public Feed Feed { get { return feed; } }

        /// <summary>
        /// Returns a parsed represensation of the feed articles.
        /// </summary>
        public List<Article> Articles
        {
            get { return Feed != null ? Feed.Articles : null; }
        }

        /// <summary>
        /// Parses the feed content.
        /// </summary>
        /// <param name="feedURI">The location of the feed.</param>
        /// <returns>An instance of the reader containing the parsed content.</returns>
        public static RSSReader Read(string feedURI)
        {
            if (feedURI == null || feedURI == string.Empty)
            {
                throw new EmptyORNullURIException();
            }

            return new RSSReader(feedURI);
        }

        #endregion  
    }
}
