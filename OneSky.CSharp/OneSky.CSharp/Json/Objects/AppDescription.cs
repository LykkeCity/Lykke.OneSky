﻿#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace Lykke.OneSky.Json
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    internal class AppDescription : IAppDescription
    {
        [JsonProperty("APP_NAME")]
        private string appName;

        [JsonProperty("TITLE")]
        private string title;

        [JsonProperty("AMAZON_APPSTORE_TITLE")]
        private string amazonTitle;

        [JsonProperty("DISPLAY_NAME")]
        private string displayName;

        [JsonProperty("DESCRIPTION")]
        private string description;

        [JsonProperty("APP_DESCRIPTION")]
        private string appDescription;

        [JsonProperty("SHORT_DESCRIPTION")]
        private string shortDescription;

        [JsonProperty("AMAZON_APPSTORE_SHORT_DESCRIPTION")]
        private string amazonShortDescription;

        [JsonProperty("DETAILED_DESCRIPTION")]
        private string detailedDescription;

        [JsonProperty("AMAZON_APPSTORE_LONG_DESCRIPTION")]
        private string amazonDetailedDescription;

        [JsonProperty("APP_VERSION_DESCRIPTION")]
        private string appVersionDescription;

        [JsonProperty("RECENT_CHANGES")]
        private string recentChanges;

        [JsonProperty("AMAZON_APPSTORE_FEATURE_BULLETS")]
        private string features;

        [JsonProperty("TAGLINE")]
        private string tagline;

        [JsonProperty("APP_KEYWORD")]
        private Dictionary<string, string> appKeywords;

        [JsonProperty("KEYWORDS")]
        private Dictionary<string, string> keywords;

        [JsonProperty("AMAZON_APPSTORE_KEYWORDS")]
        private Dictionary<string, string> amazonKeywords;

        [JsonProperty("APP_IAP_NAME")]
        private Dictionary<string, string> iapName;

        [JsonProperty("APP_IAP_DESCRIPTION")]
        private Dictionary<string, string> iapDescription;

        [JsonProperty("APP_TAG")]
        private IDictionary<string, string> tags;

        public string Name
        {
            get
            {
                return this.appName ?? this.title ?? this.amazonTitle ?? this.displayName;
            }
        }

        public string Description
        {
            get
            {
                return this.description ?? this.appDescription;
            }
        }

        public string ShortDescription
        {
            get
            {
                return this.shortDescription ?? this.amazonShortDescription;
            }
        }

        public string DetailedDescription
        {
            get
            {
                return this.detailedDescription ?? this.amazonDetailedDescription;
            }
        }

        public string RecentChanges
        {
            get
            {
                return this.recentChanges ?? this.appVersionDescription;
            }
        }

        public string Features
        {
            get
            {
                return this.features;
            }
        }

        public string Tagline
        {
            get
            {
                return this.tagline;
            }
        }

        public IDictionary<string, string> Keywords
        {
            get
            {
                return this.appKeywords ?? this.keywords ?? this.amazonKeywords;
            }
        }

        public IDictionary<string, string> Tags
        {
            get
            {
                return this.tags;
            }
        }

        public IDictionary<string, string> IapName
        {
            get
            {
                return this.iapName;
            }
        }

        public IDictionary<string, string> IapDescription
        {
            get
            {
                return this.iapDescription;
            }
        }
    }
}