using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CSC_Assistant.Client.DataStructures
{
    public class WebData
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("descriptionShort")]
        public string DescriptionShort { get; set; }

        [JsonPropertyName("featureImageFour")]
        public string FeatureImageFour { get; set; }

        [JsonPropertyName("featureImageOne")]
        public string FeatureImageOne { get; set; }

        [JsonPropertyName("featureImageThree")]
        public string FeatureImageThree { get; set; }

        [JsonPropertyName("featureImageTwo")]
        public string FeatureImageTwo { get; set; }

        [JsonPropertyName("imagelocation")]
        public string Imagelocation { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("keyStats")]
        public List<KeyStat> KeyStats { get; set; }

        [JsonPropertyName("subType")]
        public string SubType { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("activeSaleMessage")]
        public string ActiveSaleMessage { get; set; }

        [JsonPropertyName("marketplaceImage")]
        public string MarketplaceImage { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("saleStartMessage")]
        public string SaleStartMessage { get; set; }

        [JsonPropertyName("salesStartTime")]
        public string SalesStartTime { get; set; }

        [JsonPropertyName("special")]
        public string Special { get; set; }
    }
}