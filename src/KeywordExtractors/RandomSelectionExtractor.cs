using System;
using System.Collections.Generic;

namespace Summarizer.Core.KeywordExtractors
{
    public class RandomSelectionExtractor : IKeywordExtractor
    {
        public readonly uint MaxKeywords;
        public readonl