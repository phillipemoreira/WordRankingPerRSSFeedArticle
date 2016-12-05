using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace RSSTools
{
    /// <summary>
    /// 
    /// </summary>
    internal class XMLParser
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="feedURI"></param>
        /// <returns></returns>
        internal static Feed ParseFeed(string feedURI)
        {
            Feed feed = null;

            var reader = XmlReader.Create(feedURI);
            var xdocument = XDocument.Load(reader);

            var channel = xdocument.Element("channel");
            var title = channel.Element("title");
            var link = channel.Element("link");
            var description = channel.Element("description");

            feed = new Feed(title.Value, link.Value, description.Value);

            var items = channel.Descendants("item");
            foreach (var item in items)
            {
                feed.Articles.Add(ParseArticle(item));
            }

            return feed;
        }

        private static Article ParseArticle(XElement ArticleItem)
        {
            // TODO: find a way to infer the namespace automatically
            XNamespace ContentNS = "http://purl.org/rss/1.0/modules/content/";

            var title = ArticleItem.Element("title");
            var date = ArticleItem.Element("date");
            var description = ArticleItem.Element("description");
            var link = ArticleItem.Element("link");            
            var encodedContent = ArticleItem.Element(ContentNS + "encoded");

            return new Article(date.Value, title.Value, description.Value, link.Value, encodedContent.Value);
        }
    }
}
