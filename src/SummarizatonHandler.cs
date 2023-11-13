﻿using System.Collections.Generic;
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
            SummarizerInstances = new List<ISummarizationLayer>
            {
                summarizerLayer
            };

            MaxStatementLength = maxStatementLength;
            ShouldFavorLowScores = shouldFavorLowScores;
        }

        public string Invoke(string statement)
        {
            var currentStatementList = new Dictionary<string, double>();
            foreach (ISummarizationLayer layer in SummarizerInstances)
            {
                if (currentStatementList.Count > 1)
                {
                    currentStatementList = layer.Invoke(currentStatementList);
                }
                else
                {
                    currentStatementList = layer.Invoke(statement);
                }
            }

            var orderedVectors = OrderSentenceVectors(currentStatementList);
            return ConvertScoredStatementToString(orderedVectors);
        }
        private Dictionary<string, double> OrderSentenceVectors(Dictionary<string, double> assignedVectors)
        {
            if (ShouldFavorLowScores)
            {
                return assignedVectors
                    .Orde