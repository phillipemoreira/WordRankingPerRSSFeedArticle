using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RSSTools.Tests
{
    /// <summary>
    /// Unit tests for RSSTools.RSSReader
    /// </summary>
    /// <remarks>
    /// Tests contained in this class require internet connection in order to run.
    /// </remarks>
    [TestClass()]
    public class ARSTechnicaParsingTests
    {
        string arstechnicaFeedURL = @"http://feeds.arstechnica.com/arstechnica/technology-lab";

        /// <summary>
        /// Given ARSTechnica RSS feed
        /// Then RSSTools feed must be correctly parsed.
        /// </summary>
        [TestMethod()]
        public void ARSTechnicaFeedMustBeCorrectlyLoaded()
        {
            // Arrange && Act
            Feed feed = RSSReader.Read(arstechnicaFeedURL).Feed;

            // Assert
            Assert.IsNotNull(feed);
            Assert.IsTrue(feed.Articles.Count > 0);

            Assert.AreEqual("Technology Lab – Ars Technica", feed.Title);
            Assert.AreEqual("Serving the Technologist for more than a decade. IT news, reviews, and analysis.", feed.Description);
            Assert.AreEqual("http://arstechnica.com", feed.Link);
        }
    }
}
