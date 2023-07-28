﻿using System;
using System.Collections.Generic;

namespace Summarizer.Core.KeywordExtractors
{
    public class RandomSelectionExtractor : IKeywordExtractor
    {
        public readonly uint MaxKeywords;
        public readonly double SelectionLikelihood; // value between 0.0 - 1;

        private readonly Random _random = new Random();

        public RandomSelectionExtractor()
        {
            MaxKeywords = 5;
            SelectionLikelihood = 0.4;
        }
        public RandomSelectionExtractor(uint maxKeywords) : this()
        {
            MaxKeywords = maxKeywords;
        }
        public RandomSelectionExtractor(double selectionLikelihood) : this()
        {
            SelectionLikelihood = selectionLikelihood;
        }
        public RandomSelectionExtractor(int maxKeywords, double selectionLikelihood) : this(maxKeywords)
        {
            SelectionLikelihood = selectionLikelihood;
        }

        public Dictionary<string, double> Invoke(str