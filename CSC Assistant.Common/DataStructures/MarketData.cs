using System.Text.Json.Serialization;

namespace CSC_Assistant.Common.DataStructures
{
    public class MarketData
    {
        [JsonPropertyName("asset")]
        public string Asset { get; set; }

        [JsonPropertyName("gfEstUSDItemMarketCap")]
        public double GfEstUSDItemMarketCap { get; set; }

        [JsonPropertyName("gfEstUSDValue")]
        public double GfEstUSDValue { get; set; }

        [JsonPropertyName("itemID")]
        public string ItemID { get; set; }

        [JsonPropertyName("lastUpdated")]
        public object LastUpdated { get; set; }

        [JsonPropertyName("totalItems")]
        public long TotalItems { get; set; }

        [JsonPropertyName("GRP")]
        public Currency GRP { get; set; }

        [JsonPropertyName("GFC")]
        public Currency GFC { get; set; }

        [JsonPropertyName("grpUSDValueForItem")]
        public double? GrpUSDValueForItem { get; set; }

        [JsonPropertyName("mintedTotalItems")]
        public int? MintedTotalItems { get; set; }

        [JsonPropertyName("ETH")]
        public Currency ETH { get; set; }

        [JsonPropertyName("DAI")]
        public Currency DAI { get; set; }

        [JsonPropertyName("GPL")]
        public Currency GPL { get; set; }

        [JsonPropertyName("SAI")]
        public Currency SAI { get; set; }

        [JsonPropertyName("WHALE")]
        public Currency WHALE { get; set; }

        [JsonPropertyName("USDC")]
        public Currency USDC { get; set; }
    }
}