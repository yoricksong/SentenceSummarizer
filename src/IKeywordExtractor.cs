using System.Collections.Generic;

namespace Summarizer.Core
{
    public interface IKeywordExtractor
    {
        /// <summary>
        /// Invoke with the base statement.
        /// </summary>
        /// <param name="statement"></param>
        /// <returns>vectorized keywords</returns>
        Dictionary<string, double> Invoke(string statement);

        /// <summary>
        /// In