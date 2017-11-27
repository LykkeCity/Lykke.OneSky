﻿#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace Lykke.OneSky.Json
{
    using Newtonsoft.Json;

    internal class Account : IAccount
    {
        [JsonProperty("name")]
        private string name;

        [JsonProperty("api_key")]
        private string apiKey;

        [JsonProperty("api_secret")]
        private string apiSecret;

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string ApiKey
        {
            get
            {
                return this.apiKey;
            }
        }

        public string ApiSecret
        {
            get
            {
                return this.apiSecret;
            }
        }
    }
}