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

        /// <summary>
        /// TODO: Split this method; Think of having words nouns in the articles.
        /// </summary>
        internal List<Word> IdentifyMostRelevantWords(int _numberOfWords)
        {
            List<string> feedWords = new List<string>();
            List<Word> mostRelevantWords = new List<Word>();

            // Putting all nouns from every article in a single place
            foreach (var article in feed.Articles)
            {
                var rawContent = RemoveMarkup(article.EncodedContent.ToLower());
                POSTagger tagger = new POSTagger(rawContent);

                foreach (var item in tagger.ExtractNouns())
                {
                    feedWords.Add(item);
                }
            }

            // Finding TOP appearing nouns.
            var mostCommonWords = feedWords
                .GroupBy(q => q)
                .OrderByDescending(gp => gp.Count())
                .Take(_numberOfWords)
                .Select(g => g.Key).ToList();

            // Creating words representation
            foreach (var commonWord in mostCommonWords)
            {
                Word word = new Word(commonWord);

                foreach (var article in feed.Articles)
                {
                    var cnt = RemoveMarkup(article.EncodedContent.ToLower()).Split(' ')
                                .Count(w => w == commonWord.ToLower());

                    word.AddArticleAppearance(article.Title, cnt);
                }

                mostRelevantWords.Add(word);
            }

            return mostRelevantWords;
        }

        private string RemoveMarkup(string text)
        {
           return Regex.Replace(text, "<.*?>", String.Empty);
        }
    }
}
