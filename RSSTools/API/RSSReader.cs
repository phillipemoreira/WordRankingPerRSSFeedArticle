using RSSTools.Exceptions;
using System.Collections.Generic;

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

        /// <summary>
        /// Returns the feed URI.
        /// </summary>
        public string FeedURI { get; }

        /// <summary>
        /// Returns a parsed represensation of the feed.
        /// </summary>
        public Feed Feed { get { return feed; } }

        /// <summary>
        /// Returns the list of most relevant words.
        /// </summary>
        /// <param name="numberOfWords">The number of words to be returned in descending order.</param>
        /// <returns>The words.</returns>
        public List<Word> GetMostRelevantWords(int numberOfWords)
        {
            FeedToosls tools = new FeedToosls(feed);
            return tools.IdentifyMostRelevantWords(numberOfWords);
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
    }
}
