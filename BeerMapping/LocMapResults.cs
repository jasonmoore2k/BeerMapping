using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BeerMapping
{
    [CollectionDataContract(Name = "bmp_locations", Namespace = "")]
    public class LocMapResults : List<LocMapResult>
    {
    }

    [DataContract(Name = "location", Namespace = "")]
    public class LocMapResult
    {
        [JsonProperty("name")]
        [DataMember(Name = "name", Order = 1, IsRequired = true)]
        public string Name { get; set; }

        [JsonProperty("status")]
        [DataMember(Name = "status", Order = 2, IsRequired = true)]
        public string Status { get; set; }

        [JsonProperty("lat")]
        [DataMember(Name = "lat", Order = 3, IsRequired = true)]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        [DataMember(Name = "lng", Order = 4, IsRequired = true)]
        public double Lng { get; set; }

        [JsonProperty("map")]
        [DataMember(Name = "map", Order = 5, IsRequired = true)]
        public string Map { get; set; }

        [JsonProperty("altmap")]
        [DataMember(Name = "altmap", Order = 6, IsRequired = true)]
        public string AltMap { get; set; }
    }
}