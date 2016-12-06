using RSSTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RSSTools.Exceptions;

namespace RSSTools.Tests
{
    [TestClass()]
    public class RSSReaderTests
    {
        RSSReader reader;

        string simpleFeedURI = @"..\..\RSSFeeds\simpleFeed.xml";
        string arstechnicaFeedURL = @"http://feeds.arstechnica.com/arstechnica/technology-lab";

        [TestInitialize]
        public void Initialize()
        {
            reader = RSSReader.Read(simpleFeedURI);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(EmptyORNullURIException))]
        public void MustThrowExceptionIfURIIsEmpty()
        {
            RSSReader.Read(string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(EmptyORNullURIException))]
        public void MustThrowExceptionIfURIIsNull()
        {
            RSSReader.Read(null);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod()]
        public void FeedMustBeCorrectlyLoaded()
        {
            // Act
            var feed = reader.Feed;

            // Assert
            Assert.IsNotNull(feed);
            Assert.IsTrue(feed.Articles.Count == 3);

            Assert.AreEqual("Test website", feed.Title);
            Assert.AreEqual("Test website description", feed.Description);
            Assert.AreEqual("http://test.com", feed.Link);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod()]
        public void ArticlesMustBeCorrectlyLoaded()
        {
            // Act
            var articles = reader.Articles;

            // Assert
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