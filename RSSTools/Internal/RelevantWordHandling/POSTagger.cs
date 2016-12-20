using System.Collections.Generic;

using System.Linq;

namespace RSSTools
{
    internal enum POSCategory
    {
        Numeral,
        Article,
        Noun,
        Verb,
        Adjective,
        Adverb,
        Pronoun,
        Preposition,
        Conjunction,
        Interjection,
        Determiner
    }

    internal class POS
    {
        public string Text { get; set; }
        public POSCategory Category { get; set; }
    }

    internal class POSTagger : IRelevantWordExtractor
    {
        List<POS> partsOfSpeach;

        public List<string> Extract(string text)
        {
            partsOfSpeach = Tag(text);

            return partsOfSpeach
                .Where(c => c.Category == POSCategory.Noun)
                .Select(p => p.Text).ToList();
        }

        internal static List<POS> Tag(string text)
        {
            // TODO Implement

            return new List<POS>() {
                new POS() { Text = "House", Category = POSCategory.Noun},
                new POS() { Text = "The", Category = POSCategory.Article},
                new POS() { Text = "On", Category = POSCategory.Preposition},
                new POS() { Text = "Rock", Category = POSCategory.Noun},
                new POS() { Text = "Window", Category = POSCategory.Noun},
                new POS() { Text = "House", Category = POSCategory.Noun},
                new POS() { Text = "Nicely", Category = POSCategory.Adverb},
                new POS() { Text = "Bad", Category = POSCategory.Adjective},
                new POS() { Text = "Thor", Category = POSCategory.Noun},
                new POS() { Text = "He", Category = POSCategory.Pronoun},
                new POS() { Text = "Window", Category = POSCategory.Noun},
                new POS() { Text = "Fly", Category = POSCategory.Verb},
                new POS() { Text = "House", Category = POSCategory.Noun},
                new POS() { Text = "Nice", Category = POSCategory.Adjective},
                new POS() { Text = "Sea", Category = POSCategory.Noun},
                new POS() { Text = "He", Category = POSCategory.Pronoun},
                new POS() { Text = "Window", Category = POSCategory.Noun},
                new POS() { Text = "Fly", Category = POSCategory.Verb},
                new POS() { Text = "Nicely", Category = POSCategory.Adverb},
                new POS() { Text = "Thor", Category = POSCategory.Adjective},
                new POS() { Text = "Sea", Category = POSCategory.Noun},
                new POS() { Text = "James", Category = POSCategory.Noun},
                new POS() { Text = "Window", Category = POSCategory.Noun},
                new POS() { Text = "Pen", Category = POSCategory.Noun},
                new POS() { Text = "Nicely", Category = POSCategory.Adverb},
                new POS() { Text = "House", Category = POSCategory.Noun},
                new POS() { Text = "Sea", Category = POSCategory.Noun},
                new POS() { Text = "Mario", Category = POSCategory.Noun}};
        }
    }
}
