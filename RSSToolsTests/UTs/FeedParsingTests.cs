using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RSSTools.Exceptions;
using System.IO;

namespace RSSTools.Tests
{
    /// <summary>
    /// Unit tests for RSSTools.RSSReader
    /// TODO: Add test to cover HTML tag removal
    /// </summary>
    [TestClass()]
    public class FeedParsingTests
    {
        Feed feed;

        string simpleFeedURI = @"..\..\RSSFeeds\simpleFeed.xml";
        string malformedFeedURI = @"..\..\RSSFeeds\malformedFeed.xml";

        /// <summary>
        /// Given an empty feed URI
        /// Then the system must throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(EmptyORNullURIException))]
        public void MustThrowExceptionWhenURIIsEmpty()
        {
            // Act and Assert
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
            // Act and Assert
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
            // Act and Assert
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
            // Act and Assert
            RSSReader.Read(malformedFeedURI);
        }

        /// <summary>
        /// Given a well formed RSS feed xml
        /// Then RSSTools feed must be correctly parsed.
        /// </summary>
        [TestMethod()]
        public void FeedMustBeCorrectlyLoadedWhenXMLIsWellFormed()
        {
            // Arrange && Act
            feed = RSSReader.Read(simpleFeedURI).Feed;

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
            // Arrange && Act
            feed = RSSReader.Read(simpleFeedURI).Feed;

            // Assert
            var articles = feed.Articles;
            Assert.IsNotNull(articles);
            Assert.IsTrue(articles.Count == 3);

            this.AssertArticle(articles[0], "Fisrt Article", "Description of first article.", "http://test.com/firstArticle",
                new DateTime(2016, 12, 02, 20, 55, 38), "22 Thor Jim, Erik, Yoshi with me in the beach. They were at my place, but Erik wanted to go out with Thor, so I let them. 22");

            this.AssertArticle(articles[1], "Second Article", "Description of second article.", "http://test.com/secondArticle",
                new DateTime(2016, 12, 03, 21, 55, 38), "22 Out of nowhere, some Storm started and we all looked at Thor because we thought he did it, "
                + "but it turns out, it was actually Erik. Erik did it in order for us to open a portal to the land of Yoshi, where we could eat some "
                + "apples and play in some other beach.");

            this.AssertArticle(articles[2], "Third Article", "Description of third article.", "http://test.com/thirdArticle",
                new DateTime(2016, 12, 04, 22, 55, 38), "22 When we got back from the land of Yoshi, I woke up and realized it was a dream, a bad dream, "
                + "a dream I only had because Jim put some Gim in my drink. Today all I can think of is my friends in the beach, all of them: Thor, "
                + "Jim, Erik and Yoshi.");
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