using System;
using System.Collections.Generic;

namespace RSSTools
{
    internal interface IRelevantWordExtractor
    {
        List<String> Extract(string text);
    }
}
