using System.Collections.Generic;
using System.Linq;

namespace Summarizer.Core
{
    public class SummarizatonHandler
    {
        public readonly List<ISummarizationLayer> SummarizerInstances;
        public readonly bool ShouldFavorLowScores = false;
        public readonly int MaxStatementLength;

        public SummarizatonHandler(List<ISummarizationLayer> summarizationLayers, int maxStatementLeng