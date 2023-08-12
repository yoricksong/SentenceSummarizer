using System.Linq;
using System.Collections.Generic;

namespace Summarizer.Core.KeywordExtractors
{
    /*
     *  Vectorizes keywords based on how frequently they appear within the statement's context.
     */
    public class RegularFrequencyExtractor : ExtractionProvider, IKeywordExtractor
    {
        public RegularFrequencyExtractor() : base() { }
        public RegularFrequencyExtra