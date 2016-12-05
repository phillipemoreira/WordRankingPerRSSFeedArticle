using System;

namespace RSSTools.Exceptions
{
    public class EmptyORNullURIException : Exception
    {
        public override string ToString()
        {
            return "The feed URI must be informed in order for the articles to be loaded";
        }
    }
}
