using System;
using System.Collections.Generic;
using RSSTools.Exceptions;

namespace RSSTools
{
    /// <summary>
    /// 
    /// </summary>
    public class RSSReader
    {
        private Feed feed;

        /// <summary>
        /// 
        /// </summary>
        public string FeedURI { get; }

        /// <summary>
        /// 
        /// </summary>
        public Feed Feed { get { return feed; } }

        /// <summary>
        /// 
        /// </summary>
        public List<Article> Articles { get { return Feed.Articles; } }

        private RSSReader(string feedURI)
        {
            this.FeedURI = feedURI;
            feed = XMLParser.ParseFeed(feedURI);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="feedURI"></param>
        /// <returns></returns>
        public static RSSReader Read(string feedURI)
        {
            if (feedURI == null || feedURI == string.Empty)
            {
                throw new EmptyORNullURIException();
            }

            return new RSSReader(feedURI);
        }
    }
}
