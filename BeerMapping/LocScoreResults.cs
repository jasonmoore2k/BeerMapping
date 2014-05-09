using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BeerMapping
{
    [CollectionDataContract(Name = "bmp_locations", Namespace = "")]
    public class LocScoreResults : List<LocScoreResult>
    {
    }

    [DataContract(Name = "location", Namespace = "")]
    public class LocScoreResult
    {
        [JsonProperty("overall")]
        [DataMember(Name = "overall", Order = 1, IsRequired = true)]
        public double Overall { get; set; }

        [JsonProperty("selection")]
        [DataMember(Name = "selection", Order = 2, IsRequired = true)]
        public double Selection { get; set; }

        [JsonProperty("service")]
        [DataMember(Name = "service", Order = 3, IsRequired = true)]
        public double Service { get; set; }

        [JsonProperty("atmosphere")]
        [DataMember(Name = "atmosphere", Order = 4, IsRequired = true)]
        public double Atmosphere { get; set; }

        [JsonProperty("food")]
        [DataMember(Name = "food", Order = 5, IsRequired = true)]
        public double Food { get; set; }

        /// <summary>
        /// This is the number of times this location has been reviewed by users.
        /// </summary>
        [JsonProperty("reviewcount")]
        [DataMember(Name = "reviewcount", Order = 6, IsRequired = true)]
        public int ReviewCount { get; set; }

        /// <summary>
        /// facebook.com score from our Breweries I've Visited application. This is an averaged score from all visits.
        /// </summary>
        [JsonProperty("fbscore")]
        [DataMember(Name = "fbscore", Order = 7, IsRequired = true)]
        public double FbScore { get; set; }

        /// <summary>
        /// The number of facebook.com users who have logged a visit to this location.
        /// </summary>
        [JsonProperty("fbcount")]
        [DataMember(Name = "fbcount", Order = 8, IsRequired = true)]
        public int FbCount { get; set; }
    }
}