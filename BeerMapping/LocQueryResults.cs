using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BeerMapping
{
    [CollectionDataContract(Name = "bmp_locations", Namespace = "")]
    public class LocQueryResults : List<LocQueryResult>
    {
    }

    [DataContract(Name = "location", Namespace = "")]
    public class LocQueryResult
    {
        [JsonProperty("id")]
        [DataMember(Name = "id", Order = 1, IsRequired = true)]
        public int Id { get; set; }

        [JsonProperty("name")]
        [DataMember(Name = "name", Order = 2, IsRequired = true)]
        public string Name { get; set; }

        [JsonProperty("status")]
        [DataMember(Name = "status", Order = 3, IsRequired = true)]
        public string Status { get; set; }

        /// <summary>
        /// The review page on beermapping.com
        /// </summary>
        [JsonProperty("reviewlink")]
        [DataMember(Name = "reviewlink", Order = 4, IsRequired = true)]
        public string ReviewLink { get; set; }

        /// <summary>
        /// A map showing the location and all locations within a specific proximity.
        /// </summary>
        [JsonProperty("proxylink")]
        [DataMember(Name = "proxylink", Order = 5, IsRequired = true)]
        public string ProxyLink { get; set; }

        /// <summary>
        /// The url of a proximity map that is intended to be embedded in an iframe and it can be posted in a blog or site.
        /// </summary>
        [JsonProperty("blogmap")]
        [DataMember(Name = "blogmap", Order = 6, IsRequired = true)]
        public string BlogMap { get; set; }

        [JsonProperty("street")]
        [DataMember(Name = "street", Order = 7, IsRequired = true)]
        public string Street { get; set; }

        [JsonProperty("city")]
        [DataMember(Name = "city", Order = 8, IsRequired = true)]
        public string City { get; set; }

        [JsonProperty("state")]
        [DataMember(Name = "state", Order = 9, IsRequired = true)]
        public string State { get; set; }

        [JsonProperty("zip")]
        [DataMember(Name = "zip", Order = 10, IsRequired = true)]
        public string Zip { get; set; }

        [JsonProperty("country")]
        [DataMember(Name = "country", Order = 11, IsRequired = true)]
        public string Country { get; set; }

        [JsonProperty("phone")]
        [DataMember(Name = "phone", Order = 12, IsRequired = true)]
        public string Phone { get; set; }

        [JsonProperty("overall")]
        [DataMember(Name = "overall", Order = 13, IsRequired = true)]
        public double Overall { get; set; }

        [JsonProperty("imagecount")]
        [DataMember(Name = "imagecount", Order = 14, IsRequired = true)]
        public double ImageCount { get; set; }
    }
}