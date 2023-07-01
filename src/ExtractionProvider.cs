using System.Collections.Generic;
using System.Linq;

namespace Summarizer.Core
{
    public abstract class ExtractionProvider
    {
        /*
         * Applies the abstract intensity to the amount of keywords by %.
         * Values 0.0 - 1
         */
        public virtual double AbstractIntensity { get; protected set; }

        public ExtractionProvider(double abstractIntensity)
        {
            AbstractIntensity = abstractIntensity;
        }
        public ExtractionProvider()
        {
            AbstractIntensity = .4;
        }

        protected abstract Dictionary<string, double> ExtractKeywords(string statement);
        public virtual D