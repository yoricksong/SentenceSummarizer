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
        public vi