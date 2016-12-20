﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RSSTools.Tests
{

    /// <summary>
    /// Auxiliary class in order to test Word, as it cannot be instantiated from outsite the assembly.
    /// </summary>
    public class WordTest
    {
        public List<AppearanceCountWordArticle> AppearanceCountPerArticle;
    }

    /// <summary>
    /// Unit tests for RSSTools.RSSReader
    /// </summary>
    [TestClass()]
    public class RelevantThermsTests
    {
        RSSReader reader;

        string simpleFeedURI = @"..\..\RSSFeeds\simpleFeed.xml";

        /// <summary>
        /// Given a well formed RSS feed xml
        /// The most relevant therm within the content of the articles
        /// must be correctly identified
        /// </summary>
        [TestMethod]
        public void ReaderMustidentifyFeedsMostRelevantWord()
        {
            // Arrange
            reader = RSSReader.Read(simpleFeedURI);

            // Act
            var mostRelevantWords = reader.GetMostRelevantWords(1);

            // Assert
            Assert.IsNotNull(mostRelevantWords);
            Assert.AreEqual(1, mostRelevantWords.Count);
            Assert.AreEqual("Erik", mostRelevantWords[0].Text);
            Assert.AreEqual(5, mostRelevantWords[0].AppearanceCount);
        }

        /// <summary>
        /// Given a well formed RSS feed xml
        /// The Five most relevant therms within the content of the articles
        /// must be correctly identified
        /// </summary>
        [TestMethod]
        public void ReaderMustIdentifyFeedsFiveMostRelevantWords()
        {
            // Arrange
            reader = RSSReader.Read(simpleFeedURI);

            // Act
            var mostRelevantWords = reader.GetMostRelevantWords(5);

            // Assert
            Assert.IsNotNull(mostRelevantWords);
            Assert.AreEqual(5, mostRelevantWords.Count);

            Assert.AreEqual("Erik", mostRelevantWords[0].Text);
            Assert.AreEqual(5, mostRelevantWords[0].AppearanceCount);

            Assert.AreEqual("Thor", mostRelevantWords[0].Text);
            Assert.AreEqual(4, mostRelevantWords[0].AppearanceCount);

            Assert.AreEqual("Yoshi", mostRelevantWords[0].Text);
            Assert.AreEqual(4, mostRelevantWords[0].AppearanceCount);

            Assert.AreEqual("Jim", mostRelevantWords[0].Text);
            Assert.AreEqual(3, mostRelevantWords[0].AppearanceCount);

            Assert.AreEqual("beach", mostRelevantWords[0].Text);
            Assert.AreEqual(3, mostRelevantWords[0].AppearanceCount);
        }

        /// <summary>
        /// Given a well formed RSS feed xml
        /// The most relevant therm within the content of the feed's
        /// articles must also identify how many times it appear in each of the articles.
        /// </summary>
        [TestMethod]
        public void ReaderMustIdentifyHowManyTimesARelevantWordAppearInEachArticle()
        {
            // Arrange
            reader = RSSReader.Read(simpleFeedURI);

            // Act
            var mostRelevantWords = reader.GetMostRelevantWords(1);

            // Assert
            var appearnceCountPerArticle = mostRelevantWords[0].AppearanceCountPerArticle;

            // Assert
            this.AssertAppearnceCountPerArticle(mostRelevantWords,
                new List<WordTest>()
                {
                    // Word: "Erik"
                    new WordTest()
                    {
                        AppearanceCountPerArticle = new List<AppearanceCountWordArticle>()
                        {
                            new AppearanceCountWordArticle { ArticleTitle = "Fisrt Article", NumberOfTimesInArticle = 2 },
                            new AppearanceCountWordArticle { ArticleTitle = "Second Article", NumberOfTimesInArticle = 2 },
                            new AppearanceCountWordArticle { ArticleTitle = "Third Article", NumberOfTimesInArticle = 1 }
                        }
                    }
                });
        }

        /// <summary>
        /// Given a well formed RSS feed xml
        /// Each of the five most relevant therms within the content of the feed's
        /// articles must also identify how many times it appear in each of the articles.
        /// </summary>
        [TestMethod]
        public void ReaderMustIdentifyHowManyTimesEachOfFiveRelevantWordsAppearInEachArticle()
        {
            // Arrange
            reader = RSSReader.Read(simpleFeedURI);

            // Act
            var mostRelevantWords = reader.GetMostRelevantWords(1);

            // Assert
            this.AssertAppearnceCountPerArticle(mostRelevantWords,
                new List<WordTest>()
                {
                    // Word: "Erik"
                    new WordTest()
                    {
                        AppearanceCountPerArticle = new List<AppearanceCountWordArticle>()
                        {
                            new AppearanceCountWordArticle { ArticleTitle = "Fisrt Article", NumberOfTimesInArticle = 2 },
                            new AppearanceCountWordArticle { ArticleTitle = "Second Article", NumberOfTimesInArticle = 2 },
                            new AppearanceCountWordArticle { ArticleTitle = "Third Article", NumberOfTimesInArticle = 1 }
                        }
                    },
                    // Word: "Thor"
                    new WordTest()
                    {
                        AppearanceCountPerArticle = new List<AppearanceCountWordArticle>()
                        {
                            new AppearanceCountWordArticle { ArticleTitle = "Fisrt Article", NumberOfTimesInArticle = 2 },
                            new AppearanceCountWordArticle { ArticleTitle = "Second Article", NumberOfTimesInArticle = 1 },
                            new AppearanceCountWordArticle { ArticleTitle = "Third Article", NumberOfTimesInArticle = 1 }
                        }
                    },
                    // Word: "Yoshi"
                    new WordTest()
                    {
                        AppearanceCountPerArticle = new List<AppearanceCountWordArticle>()
                        {
                            new AppearanceCountWordArticle { ArticleTitle = "Fisrt Article", NumberOfTimesInArticle = 1 },
                            new AppearanceCountWordArticle { ArticleTitle = "Second Article", NumberOfTimesInArticle = 1 },
                            new AppearanceCountWordArticle { ArticleTitle = "Third Article", NumberOfTimesInArticle = 2 }
                        }
                    },
                    // Word: "Jim"
                    new WordTest()
                    {
                        AppearanceCountPerArticle = new List<AppearanceCountWordArticle>()
                        {
                            new AppearanceCountWordArticle { ArticleTitle = "Fisrt Article", NumberOfTimesInArticle = 1 },
                            new AppearanceCountWordArticle { ArticleTitle = "Second Article", NumberOfTimesInArticle = 0 },
                            new AppearanceCountWordArticle { ArticleTitle = "Third Article", NumberOfTimesInArticle = 2 }
                        }
                    },
                    // Word: "beach"
                    new WordTest()
                    {
                        AppearanceCountPerArticle = new List<AppearanceCountWordArticle>()
                        {
                            new AppearanceCountWordArticle { ArticleTitle = "Fisrt Article", NumberOfTimesInArticle = 1 },
                            new AppearanceCountWordArticle { ArticleTitle = "Second Article", NumberOfTimesInArticle = 1 },
                            new AppearanceCountWordArticle { ArticleTitle = "Third Article", NumberOfTimesInArticle = 1 }
                        }
                    }
                });
        }

        private void AssertAppearnceCountPerArticle(
            List<Word> actual,
            List<WordTest> expectedOutput)
        {
            Assert.IsNotNull(actual);

            // Number of Words
            Assert.AreEqual(expectedOutput.Count, actual.Count);

            for (int i = 0; i < expectedOutput.Count; i++)
            {
                var expectedAppearanceCountPerArticle = expectedOutput[i].AppearanceCountPerArticle;
                var actualAppearanceCountPerArticle = actual[i].AppearanceCountPerArticle;

                // Number of Articles by word.
                Assert.AreEqual(expectedAppearanceCountPerArticle.Count, actualAppearanceCountPerArticle.Count);

                for (int j = 0; j < expectedAppearanceCountPerArticle.Count; j++)
                {
                    Assert.AreEqual(expectedAppearanceCountPerArticle[j].ArticleTitle, actualAppearanceCountPerArticle[j].ArticleTitle);
                    Assert.AreEqual(expectedAppearanceCountPerArticle[j].NumberOfTimesInArticle, actualAppearanceCountPerArticle[j].NumberOfTimesInArticle);
                }
            }
        }
    }
}