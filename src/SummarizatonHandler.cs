using System.Collections.Generic;
using System.Linq;

namespace Summarizer.Core
{
    public class SummarizatonHandler
    {
        public readonly List<ISummarizationLayer> SummarizerInstances;
        public readonly bool ShouldFavorLowScores = false;
        public readonly int MaxStatementLength;

        public SummarizatonHandler(List<ISummarizationLayer> summarizationLayers, int maxStatementLength = 5, bool shouldFavorLowScores = false)
        {
            SummarizerInstances = summarizationLayers;
            MaxStatementLength = maxStatementLength;
            ShouldFavorLowScores = shouldFavorLowScores;
        }
        public SummarizatonHandler(ISummarizationLayer summarizerLayer, int maxStatementLength = 5, bool shouldFavorLowScores = false)
        {
       