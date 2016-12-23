using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            var feedWords = GetFeedRelevantWords(feed.Articles, GetWordExtractor());

            // Finding TOP appearing nouns.
            var mostCommonWords = GetTopAppearingWords(feedWords, _numberOfWords);

            // Creating Words representation
            return CreateWords(mostCommonWords);
        }

        private List<string> GetFeedRelevantWords(List<Article> articles, IRelevantWordExtractor wordExtractor)
        {
            List<string> feedWords = new List<string>();

            foreach (var article in articles)
            {
                var rawContent = StripText(article.EncodedContent);

                foreach (var item in wordExtractor.Extract(rawContent))
                {
                    feedWords.Add(item);
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
                    var cnt = StripText(article.EncodedContent.ToLower()).Split(' ')
                                .Count(w => w.Contains(commonWord.ToLower()));

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

        private string StripText(string text)
        {
            var paragraphs = Regex.Matches(RemoveLinks(text), "<p>.*</p>");

            var output = string.Empty;
            foreach (var paragraph in paragraphs)
            {
                output += RemoveMarkup(paragraph.ToString());
            }

            return output;
        }

        private string RemoveLinks(string text)
        {
            return Regex.Replace(text, "<a.*?</a>", String.Empty);
        }

        private string RemoveMarkup(string text)
        {
           return Regex.Replace(text, "<.*?>", String.Empty) + ' ';
        }
    }
}
