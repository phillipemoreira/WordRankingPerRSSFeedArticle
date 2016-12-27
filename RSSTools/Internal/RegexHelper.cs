using System;
using System.Text.RegularExpressions;

namespace RSSTools
{
    internal class RegexHelper
    {
        private string text;

        internal string Text
        {
            get { return text; }
        }

        internal RegexHelper(string text)
        {
            this.text = text;
        }

        internal RegexHelper KeepOnlyHTMLParagraphs()
        {
            var matches = Regex.Matches(text, "<p>.*</p>");

            var paragraphs = string.Empty;
            foreach (var item in matches)
            {
                paragraphs += item.ToString() + ' ';
            }

            text = paragraphs.Substring(0, paragraphs.Length - 1);

            Regex.Replace(text, @"\s\s*", " ");

            return this;
        }

        internal RegexHelper RemoveLinks()
        {
            text =  Regex.Replace(text, "<a.*?</a>", String.Empty);

            return this;
        }

        internal RegexHelper RemoveMarkup()
        {
            text =  Regex.Replace(text, "<.*?>", String.Empty) + ' ';

            return this;
        }

        internal RegexHelper KeepOnlyAlpha()
        {
            text = Regex.Replace(text, "'s", string.Empty);

            text = Regex.Replace(text, @"[^a-zA-Z&\s]", string.Empty);
           
            return this;
        }
    }
}
