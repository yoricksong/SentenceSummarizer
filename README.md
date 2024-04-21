## Sentence Summarizer
SentenceSummarizer is a .Net library for high-level sentence summarization, integrating Natural Language Processing for easy and versatile sentence summarization.

## Installation

#### Basic Usage Installation
For usage, import all of the SentenceSummarizer DLLs and external dependencies from the [distribute directory](./distribute) into your .net project solution. The DLLs include:
- SentenceSummarizer.Core
- SentenceSummarizer.Infrastructure
- Newtonsoft.Json
- OpenNLP

## Examples

### Summarizers
The library provides several summarizers. These include the TextRank summarizer which uses the [TextRank algorithm](https://web.eecs.umich.edu/~mihalcea/papers/mihalcea.emnlp04.pdf), the Synonymizer which uses a synonym-based approach, and the NodeProximity summarizer which maintains the original sentence order.

#### Basic Usage
Here's how to use the TextRank summarizer:

```c#
using SentenceSummarizer.Core;
using SentenceSummarizer.Core.Summarizers;

// ...
string text; // statement(s) to be summarized

ISummarizationLayer textRankSummarizer = new TextRankByFrequency();
string summarizedText = SummarizationHandler(textRankSummarizer).Invoke(text); // summarized text.

```

You can find more examples in the [Examples section](#exa