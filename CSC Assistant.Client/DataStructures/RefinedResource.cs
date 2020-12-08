using System.Text.Json.Serialization;

namespace CSC_Assistant.Client.DataStructures
{
    public class RefinedResource : Resource
    {
        [JsonPropertyName("asset")]
        public string Asset { get; set; }

        [JsonPropertyName("optimalQty")]
        public double OptimalQty { get; set; }

        public override double Amount { get { return OptimalQty; } }
    }
}