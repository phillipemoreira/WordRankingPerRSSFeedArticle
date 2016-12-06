using System;
using System.Collections.Generic;

namespace RSSTools
{
    /// <summary>
    /// 
    /// </summary>
    public class Feed
    {
        public string Title { get; }
        public string Link { get; }
        public string Description { get; }
        public List<Article> Articles { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="link"></param>
        /// <param name="description"></param>
        public Feed(string title, string link, string description)
        {
            this.Title = title;
            this.Link = link;
            this.Description = description;

            Articles = new List<Article>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberOfWords"></param>
        /// <returns></returns>
        public List<Word> GetMostRelevantWords(int numberOfWords)
        {
            return new List<Word>() { new Word("Batata"), new Word("Agua"), new Word("Doritos") };
        }

        private void IdentifyMostRelevantWords()
        {
            throw new NotImplementedException();
        }
    }
}
