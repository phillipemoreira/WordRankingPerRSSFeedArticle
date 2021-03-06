﻿using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace RSSTools
{
    internal class FeedToosls
    {
        private Feed feed;

        public FeedToosls(Feed feed)
        {
            this.feed = feed;
        }

        internal List<Word> IdentifyMostRelevantWords(int _numberOfWords)
        {
            // Putting all nouns from every article in a single place
            var feedWords = GetFeedRelevantWords(GetWordExtractor());

            // Finding TOP appearing nouns.
            var mostCommonWords = GetTopAppearingWords(feedWords, _numberOfWords);

            // Creating Words representation
            return CreateWords(mostCommonWords);
        }

        private List<string> GetFeedRelevantWords(IRelevantWordExtractor wordExtractor)
        {
            List<string> feedWords = new List<string>();

            foreach (var article in feed.Articles)
            {
                foreach (var word in wordExtractor.Extract(article.PureTextContent))
                {
                    feedWords.Add(word);
                }
            }

            return feedWords;
        }

        private List<string> GetTopAppearingWords(List<string> words, int numberOfWords)
        {
            var mostCommonWords = words
                .GroupBy(q => q)
                .OrderByDescending(gp => gp.Count())
                .Take(numberOfWords)
                .Select(g => g.Key).ToList();

            return mostCommonWords;
        }

        private List<Word> CreateWords(List<string> topAppearingWords)
        {
            List<Word> mostRelevantWords = new List<Word>();

            foreach (var commonWord in topAppearingWords)
            {
                Word word = new Word(commonWord);

                foreach (var article in feed.Articles)
                {
                    var regexhelper = new RegexHelper(article.PureTextContent.ToLower());

                    var articleAplhaOnly = regexhelper.KeepOnlyAlpha().Text;

                    var cnt = articleAplhaOnly.Split(' ').Count(w => w == commonWord.ToLower());

                    word.AddArticleAppearance(article.Title, cnt);
                }

                mostRelevantWords.Add(word);
            }

            return mostRelevantWords;
        }

        private IRelevantWordExtractor GetWordExtractor()
        {
            //return new POSTagger();
            return new ExclusionListExtractor();
        }
    }
}
