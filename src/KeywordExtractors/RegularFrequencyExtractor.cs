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
        public RegularFrequencyExtractor(double abstractIntensity) : base(abstractIntensity) { }

        public Dictionary<string, double> Invoke(Dictionary<string, double> scoredStatements)
        {
            var