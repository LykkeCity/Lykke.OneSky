﻿#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace Lykke.OneSky.Json
{
    using Newtonsoft.Json;

    internal class OrderPlugin : Order, IOrderPlugin
    {
        [JsonProperty("amount")]
        private decimal amount;

        public decimal Amount
        {
            get
            {
                return this.amount;
            }
        }
    }
}