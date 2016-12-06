using System;

namespace RSSTools.Exceptions
{
    public class FeedMalformedException : Exception
    {
        public override string ToString()
        {
            return "The XML feed is not correctly formed.";
        }
    }
}