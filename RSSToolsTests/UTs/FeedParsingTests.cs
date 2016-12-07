using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RSSTools.Exceptions;
using System.IO;

namespace RSSTools.Tests
{
    /// <summary>
    /// Unit tests for RSSTools.RSSReader
    /// </summary>
    [TestClass()]
    public class FeedParsingTests
    {
        Feed feed;

        string simpleFeedURI = @"..\..\RSSFeeds\simpleFeed.xml";
        string malformedFeedURI = @"..\..\RSSFeeds\malformedFeed.xml";

        [TestInitialize]
        public void Initialize()
        {
            feed = RSSReader.Read(simpleFeedURI);
        }

        /// <summary>
        /// Given an empty feed URI
        /// Then the system must throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(EmptyORNullURIException))]
        public void MustThrowExceptionWhenURIIsEmpty()
        {
            RSSReader.Read(string.Empty);
        }

        /// <summary>
        /// Given a null feed URI
        /// Then the system must throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(EmptyORNullURIException))]
        public void MustThrowExceptionWhenURIIsNull()
        {
            RSSReader.Read(null);
        }

        /// <summary>
        /// Given an invalid feed URI
        /// Then the system must throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(FileNotFoundException))]
        public void MustThrowExceptionWhenURIIsInvalid()
        {
            RSSReader.Read("!#@$%");
        }

        /// <summary>
        /// Given a malformed feed XML
        /// Then the system must throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(FeedMalformedException))]
        public void MustThrowExceptionWhenFeedIsMalformed()
        {
            RSSReader.Read(malformedFeedURI);
        }

        /// <summary>
        /// Given a well formed RSS feed xml
        /// Then RSSTools feed must be correctly parsed.
        /// </summary>
        [TestMethod()]
        public void FeedMustBeCorrectlyLoadedWhenXMLIsWellFormed()
        {
            // Assert
            Assert.IsNotNull(feed);
            Assert.IsTrue(feed.Articles.Count == 3);

            Assert.AreEqual("Test website", feed.Title);
            Assert.AreEqual("Test website description", feed.Description);
            Assert.AreEqual("http://test.com", feed.Link);
        }

        /// <summary>
        /// Given a well formed RSS feed xml
        /// Then RSSTools Articles must be correctly parsed.
        /// </summary>
        [TestMethod()]
        public void ArticlesMustBeCorrectlyLoadedWhenXMLIsWellFormed()
        {
            // Assert
            var articles = feed.Articles;
            Assert.IsNotNull(articles);
            Assert.IsTrue(articles.Count == 3);

            this.AssertArticle(articles[0], "Fisrt Article", "Description of first article.", "http://test.com/firstArticle",
                new DateTime(2016, 12, 02, 20, 55, 38), "Content of first article.");

            this.AssertArticle(articles[1], "Second Article", "Description of second article.", "http://test.com/secondArticle",
                new DateTime(2016, 12, 03, 21, 55, 38), "Content of second article.");

            this.AssertArticle(articles[2], "Third Article", "Description of third article.", "http://test.com/thirdArticle",
                new DateTime(2016, 12, 04, 22, 55, 38), "Content of third article.");
        }

        private void AssertArticle(
            Article article,
            string title,
            string description,
            string link,
            DateTime postDate,
            string encodedContent)
        {
            Assert.AreEqual(title, article.Title);
            Assert.AreEqual(description, article.Description);
            Assert.AreEqual(link, article.Link);
            Assert.AreEqual(postDate, article.Date);
            Assert.AreEqual(encodedContent, article.EncodedContent);
        }
    }
}