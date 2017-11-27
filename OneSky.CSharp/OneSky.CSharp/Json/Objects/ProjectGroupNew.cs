#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace Lykke.OneSky.Json
{
    using Newtonsoft.Json;

    internal class ProjectGroupNew : ProjectGroup, IProjectGroupNew
    {
        [JsonProperty("base_language")]
        private Localeo baseLanguage;

        public ILocale BaseLanguage
        {
            get
            {
                return this.baseLanguage;
            }
        }
    }
}