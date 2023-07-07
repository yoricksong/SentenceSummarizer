using System.Linq;
using System.Collections.Generic;

using Summarizer.Infrastructure.Nlp;

namespace Summarizer.Core.KeywordExtractors
{
    public class NlpFrequencyExtractor : ExtractionProvider, IKeywordExtractor
    {
        