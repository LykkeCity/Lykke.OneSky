#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace Lykke.OneSky.Json
{
    using Newtonsoft.Json;

    internal class ProjectType : IProjectType
    {
        [JsonProperty("code")]
        private string code;

        [JsonProperty("name")]
        private string name;

        public string Code
        {
            get
            {
                return this.code;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }
}