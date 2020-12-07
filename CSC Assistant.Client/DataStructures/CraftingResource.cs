using System.Text.Json.Serialization;

namespace CSC_Assistant.Client.DataStructures
{
    public class CraftingResource
    {
        [JsonPropertyName("itemID")]
        public string ItemID { get; set; }

        [JsonPropertyName("qty")]
        public int Qty { get; set; }
    }
}