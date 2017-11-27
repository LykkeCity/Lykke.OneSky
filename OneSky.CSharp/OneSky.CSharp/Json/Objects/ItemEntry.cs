﻿#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace Lykke.OneSky.Json
{
    using Newtonsoft.Json;

    internal class ItemEntry : ItemContainer, IItemEntry
    {
        [JsonProperty("translateables")]
        private Item translateables;

        [JsonProperty("language")]
        private Localeo language;

        public IItem Translateables
        {
            get
            {
                return this.translateables;
            }
        }

        public ILocale Language
        {
            get
            {
                return this.language;
            }
        }
    }
}