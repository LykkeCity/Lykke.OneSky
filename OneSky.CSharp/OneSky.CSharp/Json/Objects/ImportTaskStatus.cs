#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace Lykke.OneSky.Json
{
    using Newtonsoft.Json;

    internal class ImportTaskStatus : ImportTask, IImportTaskStatus
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