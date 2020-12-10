using System.Text.Json.Serialization;

namespace CSC_Assistant.Common.DataStructures
{
    public class CraftingResource : Resource
    {
        [JsonPropertyName("qty")]
        public int Qty { get; set; }

        public override double Amount { get { return Qty; } }
    }
}