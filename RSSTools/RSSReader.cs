using RSSTools.Exceptions;

namespace RSSTools
{
    /// <summary>
    /// RSS feed reader.
    /// </summary>
    public class RSSReader
    {
        /// <summary>
        /// Parses the feed content.
        /// </summary>
        /// <param name="feedURI">The location of the feed.</param>
        /// <returns>The parsed representation of the feed.</returns>
        public static Feed Read(string feedURI)
        {
            if (feedURI == null || feedURI == string.Empty)
            {
                throw new EmptyORNullURIException();
            }

            return XMLParser.ParseFeed(feedURI);
        }
    }
}
