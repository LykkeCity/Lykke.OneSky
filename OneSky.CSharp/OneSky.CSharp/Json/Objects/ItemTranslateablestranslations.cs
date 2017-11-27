#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace Lykke.OneSky.Json
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    internal class ItemTranslateablesTranslations
    {
        [JsonProperty("translations")]
        private Dictionary<string, string> translations;

        public Dictionary<string, string> Translations
        {
            get
            {
                return this.translations;
            }
        }
    }
}