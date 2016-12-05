using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RSSTools.Exceptions;

namespace RSSTools.Tests
{
    [TestClass()]
    public class RSSReader_tests
    {
        RSSReader reader;
        string sampleFeedURI = @"..\RSSFeeds\feed.xml";

        [TestInitialize]
        public void Initialize()
        {
            
        }

        [TestMethod()]
        [ExpectedException(typeof(EmptyORNullURIException))]
        public void MustThrowExceptionIfURIIsEmpty()
        {
            RSSReader.Read(string.Empty);
        }

        [TestMethod()]
        [ExpectedException(typeof(EmptyORNullURIException))]
        public void MustThrowExceptionIfURIIsNull()
        {
            RSSReader.Read(null);
        }

        [TestMethod()]
        public void MustNotThrowExceptionIfURIIsValid()
        {
            reader = RSSReader.Read(sampleFeedURI);
        }
    }
}