using System.Text.Json.Serialization;

namespace CSC_Assistant.Client.DataStructures
{
    public class Currency
    {
        [JsonPropertyName("avgPricePerUnit")]
        public double AvgPricePerUnit { get; set; }

        [JsonPropertyName("avgUSDPerUnit")]
        public double AvgUSDPerUnit { get; set; }

        [JsonPropertyName("currencyType")]
        public string CurrencyType { get; set; }

        [JsonPropertyName("maxPricePerUnit")]
        public double MaxPricePerUnit { get; set; }

        [JsonPropertyName("maxUSDPerUnit")]
        public double MaxUSDPerUnit { get; set; }

        [JsonPropertyName("minPricePerUnit")]
        public double MinPricePerUnit { get; set; }

        [JsonPropertyName("minUSDPerUnit")]
        public double MinUSDPerUnit { get; set; }

        [JsonPropertyName("totalQtySold")]
        public int TotalQtySold { get; set; }

        [JsonPropertyName("totalSalesPrice")]
        public double TotalSalesPrice { get; set; }

        [JsonPropertyName("totalSalesUSD")]
        public double TotalSalesUSD { get; set; }

        [JsonPropertyName("totalTXCount")]
        public int TotalTXCount { get; set; }
    }
}