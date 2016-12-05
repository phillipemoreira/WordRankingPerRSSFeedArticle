using System;

namespace RSSTools
{
    public class Article
    {
        public DateTime Date { get; }
        public string Title { get; }
        public string Description { get; }
        public string Link { get; }
        public string EncodedContent { get; }

        public Article(
            string date,
            string title,
            string description,
            string link,
            string encodedContent)
        {
            this.Date = Convert.ToDateTime(date);
            this.Title = title;
            this.Description = description;
            this.Link = link;
            this.EncodedContent = encodedContent;
        }
    }
}
