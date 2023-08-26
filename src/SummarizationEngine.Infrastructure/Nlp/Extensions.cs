
﻿using OpenNLP.Tools.Tokenize;
using OpenNLP.Tools.PosTagger;

namespace Summarizer.Infrastructure.Nlp
{
    public static class Extensions
    {
        private static readonly string _englishPOSPath = "../nlp/EnglishPOs.nbin";
        private static readonly string _englishTagDictPath = "../nlp/tagdict";

        public static string[] TokenizeStatement(this string statement)
        {
            var tokenizer = new EnglishRuleBasedTokenizer(false);
            return tokenizer.Tokenize(statement);
        }
        public static string[] TagPartsOfSpeech(this string[] tokens)
        {
            var posTagger = new EnglishMaximumEntropyPosTagger(_englishPOSPath, _englishTagDictPath);
            return posTagger.Tag(tokens);
        }

        public static string ToStringPos(this PosType tagType)
        {
            switch (tagType)
            {
                case PosType.CC:
                    return "CC";
                case PosType.CD:
                    return "CD";
                case PosType.DT:
                    return "DT";
                case PosType.EX:
                    return "EX";
                case PosType.FW:
                    return "FW";
                case PosType.IN:
                    return "IN";
                case PosType.JJ:
                    return "JJ";
                case PosType.JJR:
                    return "JJR";
                case PosType.JJS:
                    return "JJS";
                case PosType.LS:
                    return "LS";
                case PosType.MD:
                    return "MD";
                case PosType.NN:
                    return "NN";
                case PosType.NNP:
                    return "NNP";
                case PosType.NNPS: