using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BeerMapping
{
    [CollectionDataContract(Name = "bmp_locations", Namespace = "")]
    public class LocImageResults : List<LocImageResult>
    {
    }

    [DataContract(Name = "location", Namespace = "")]
    public class LocImageResult
    {
        [JsonProperty("imageid")]
        [DataMember(Name = "imageid", Order = 1, IsRequired = true)]
        public int ImageId { get; set; }

        /// <summary>
        /// This is the link to the full sized image on beermapping.com.
        /// </summary>
        [JsonProperty("directurl")]
        [DataMember(Name = "directurl", Order = 2, IsRequired = true)]
        public string DirectUrl { get; set; }

        /// <summary>
        /// This is the direct image that can be included on your site.
        /// </summary>
        [JsonProperty("imageurl")]
        [DataMember(Name = "imageurl", Order = 3, IsRequired = true)]
        public string ImageUrl { get; set; }

        [JsonProperty("width")]
        [DataMember(Name = "width", Order = 4, IsRequired = true)]
        public int Width { get; set; }

        [JsonProperty("height")]
        [DataMember(Name = "height", Order = 5, IsRequired = true)]
        public int Height { get; set; }

        /// <summary>
        /// This is our generated thumbnail sized image for the full image that can be included on another site.
        /// </summary>
        [JsonProperty("thumburl")]
        [DataMember(Name = "thumburl", Order = 6, IsRequired = true)]
        public string ThumbUrl { get; set; }

        [JsonProperty("caption")]
        [DataMember(Name = "caption", Order = 7, IsRequired = true)]
        public string Caption { get; set; }

        [JsonProperty("credit")]
        [DataMember(Name = "credit", Order = 8, IsRequired = true)]
        public string Credit { get; set; }

        /// <summary>
        /// This is the link to the beermapping.com user who uploaded the image originally.
        /// </summary>
        [JsonProperty("crediturl")]
        [DataMember(Name = "crediturl", Order = 9, IsRequired = true)]
        public string CreditUrl { get; set; }

        /// <summary>
        /// This is the date and time when the image was uploaded.
        /// </summary>
        [JsonProperty("imagedate")]
        [DataMember(Name = "imagedate", Order = 10, IsRequired = true)]
        public string ImageDate { get; set; }

        [JsonProperty("score")]
        [DataMember(Name = "score", Order = 11, IsRequired = true)]
        public double Score { get; set; }
    }
}