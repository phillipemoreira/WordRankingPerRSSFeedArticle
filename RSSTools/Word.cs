using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSTools
{
    /// <summary>
    /// 
    /// </summary>
    public class Word
    {
        public string Text { get; }
        public Dictionary<string, int> AppearanceNumberPerArticle { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        public Word (string text)
        {
            this.Text = text;
            AppearanceNumberPerArticle = new Dictionary<string, int>();

            AppearanceNumberPerArticle.Add("ArtigoTeste" + Text, 5);
            AppearanceNumberPerArticle.Add("ArtigoTeste2" + Text, 5);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="articleTittle"></param>
        /// <param name="appearanceCount"></param>
        public void AddArticleAppearance(string articleTittle, int appearanceCount)
        {
            if (!AppearanceNumberPerArticle.ContainsKey(articleTittle))
            {
                AppearanceNumberPerArticle.Add(articleTittle, appearanceCount);
            }
            else
            {
                throw new Exception("Article '{0}' was already taken into account");
            }
        }
    }
}
