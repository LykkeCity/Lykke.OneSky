﻿#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace Lykke.OneSky.Json
{
    using System;

    using Newtonsoft.Json;

    internal class QuotationDetails : IQuotationDetails
    {
        [JsonProperty("per_word_cost")]
        private decimal perWordCost;

        [JsonProperty("total_cost")]
        private decimal totalCost;

        [JsonProperty("will_complete_at")]
        private DateTime? willCompleteAt;

        [JsonProperty("will_complete_at_timestamp")]
        private long? willCompleteAtTimestamp;

        [JsonProperty("seconds_to_complete")]
        private int? secondsToComplete;

        [JsonProperty("estimated_return_datetime")]
        private DateTime? estimatedReturnDatetime;

        [JsonProperty("estimated_return_timestamp")]
        private long? estimatedReturnTimestamp;

        [JsonProperty("estimated_seconds_from_now")]
        private int? estimatedSecondsFromNow;

        public decimal PerWordCost
        {
            get
            {
                return this.perWordCost;
            }
        }

        public decimal TotalCost
        {
            get
            {
                return this.totalCost;
            }
        }

        public DateTime WillCompleteAt
        {
            get
            {
                return this.willCompleteAt ?? this.estimatedReturnDatetime ?? default(DateTime);
            }
        }

        public long WillCompleteAtTimestamp
        {
            get
            {
                return this.willCompleteAtTimestamp ?? this.estimatedReturnTimestamp ?? default(long);
            }
        }

        public int SecondsToComplete
        {
            get
            {
                return this.secondsToComplete ?? this.estimatedSecondsFromNow ?? default(int);
            }
        }
    }
}