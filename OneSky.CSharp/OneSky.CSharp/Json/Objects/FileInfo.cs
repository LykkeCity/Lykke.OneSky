﻿#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace Lykke.OneSky.Json
{
    using Newtonsoft.Json;

    internal class FileInfo : File, IFileInfo
    {
        [JsonProperty("format")]
        private string format;

        [JsonProperty("locale")]
        private Localeo locale;

        [JsonProperty("language")]
        private Localeo language;

        public string Format
        {
            get
            {
                return this.format;
            }
        }

        public ILocale Locale
        {
            get
            {
                return this.language ?? this.locale;
            }
        }
    }
}