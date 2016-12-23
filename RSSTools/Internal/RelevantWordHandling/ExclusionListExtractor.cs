using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RSSTools
{
    /// <summary>
    /// This exclusion list based class has a small sample of English parts of speach only, 
    /// therefore it won't work with all texts.
    /// </summary>
    internal class ExclusionListExtractor : IRelevantWordExtractor
    {
        private List<string> ExclusionList
        {
            get
            {
                return new List<string>()
                {
                    // Articles
                    "a",
                    "an",
                    "the",
                    "some",

                    // Adjectives
                    "good", "new", "first", "last", "long", "great", "little", "own", "other", "old",
                    "right", "big", "high", "different", "small", "large", "next", "early", "young", "important",
                    "few", "public", "bad", "same", "able",

                    // Pronouns
                    "i", "me", "my","", "mine", "myself",
                    "you", "your", "yours", "yourself", "yourselves",
                    "he", "him", "his", "himself",
                    "she", "her", "hers", "herself",
                    "it", "its", "itself",
                    "we", "us", "our", "ours", "ourselves",
                    "they", "them", "their", "theirs", "themselves",

                    // Prepositions
                    "aboard", "about", "above", "across", "after", "against", "along", "amid", "among", "anti", "around",
                    "as", "at", "before", "behind", "below", "beneath", "beside", "besides", "between", "beyond", "but", "by",
                    "concerning", "considering", "despite", "down", "during", "except", "excepting", "excluding", "following",
                    "for", "from", "in", "inside", "into", "like", "minus", "near", "of", "off", "on", "onto", "opposite", "outside",
                    "over", "past", "per", "plus", "regarding", "round", "save", "since", "than", "through", "to", "toward", "towards",
                    "under", "underneath", "unlike", "until", "up", "upon", "versus", "via", "with", "within", "without",

                    // Conjunctions
                    "for", "and", "nor", "but", "or", "yet", "so ", "after", "although", "because", "before", "even", "if",
                    "once", "since", "than", "that", "though", "till", "unless", "until", "when", "whenever", "where",
                    "whereever", "while",

                    // Relative clauses
                    "who", "which", "whose", "whom", "that", 

                    // tobe verbs
                    "is" , "are", "am", "were", "was", "will", "be",

                    // Other common verbs
                    "have", "has", "had"
                };
            }
        }

        public List<string> Extract(string text)
        {
            List<string> result = new List<string>();

            var words = KeepOnlyAlpha(text).Split(' ');

            foreach (var word in words)
            {
                if (!ExclusionList.Contains(word.ToLower()))
                {
                    result.Add(word);
                }
            }

            return result;
        }

        private string KeepOnlyAlpha(string input)
        {
            return Regex.Replace(input, @"[^a-zA-Z\s]", string.Empty);
        }
    }
}
