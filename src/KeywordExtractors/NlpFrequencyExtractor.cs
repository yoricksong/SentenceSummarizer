using System.Linq;
using System.Collections.Generic;

using Summarizer.Infrastructure.Nlp;

namespace Summarizer.Core.KeywordExtractors
{
    public class NlpFrequencyExtractor : ExtractionProvider, IKeywordExtractor
    {
        public readonly IEnumerable<PosType> OmittedTokens;

        public NlpFrequencyExtractor() : base()
        {
            _setupOmmitedTokens(ref OmittedTokens);
        }
        public NlpFrequencyExtractor(double abstractIntensity) : base(abstractIntensity)
        {
            _setupOmmitedTokens(ref OmittedTokens);
        }       
        public NlpFrequencyExtractor(double abstractIntensity, IEnumerable<PosType> omittedPartsOfSpeech) : base(abstractIntensity)
        {
            OmittedTokens = omittedPartsOfSpeech;
        }
        public NlpFrequencyExtractor(IEnumerable<PosType> omittedPartsOfSpeech)
        {
            OmittedTokens = omittedPartsOfSpeech;
        }


        publi