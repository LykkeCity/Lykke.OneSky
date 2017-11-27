﻿#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace Lykke.OneSky.Json
{
    using Newtonsoft.Json;

    internal class ItemDetails : ItemContainer, IItemDetails
    {
        [JsonProperty("translateables")]
        private ItemTranslateables translateables;

        public IItemTranslateables Translateables
        {
            get
            {
                return this.translateables;
            }
        }
    }
}