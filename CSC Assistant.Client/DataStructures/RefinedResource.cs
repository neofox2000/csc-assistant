using System.Text.Json.Serialization;

namespace CSC_Assistant.Client
{
    public class RefinedResource
    {
        [JsonPropertyName("asset")]
        public string Asset { get; set; }

        [JsonPropertyName("itemID")]
        public string ItemID { get; set; }

        [JsonPropertyName("optimalQty")]
        public double OptimalQty { get; set; }
    }
}