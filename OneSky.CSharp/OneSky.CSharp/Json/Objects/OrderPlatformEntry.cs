#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace Lykke.OneSky.Json
{
    using Newtonsoft.Json;

    internal class OrderPlatformEntry : Order, IOrderPlatformEntry
    {
        [JsonProperty("status")]
        private string status;

        public string Status
        {
            get
            {
                return this.status;
            }
        }
    }
}