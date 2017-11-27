﻿#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace Lykke.OneSky.Json
{
    using Newtonsoft.Json;

    internal class ProjectDetails : ProjectNew, IProjectDetails
    {
        [JsonProperty("string_count")]
        private int stringCount;

        [JsonProperty("word_count")]
        private int wordCount;

        public int StringCount { get { return this.stringCount; } }

        public int WordCount { get { return this.wordCount; } }
    }
}
