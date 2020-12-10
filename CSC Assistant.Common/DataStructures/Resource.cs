using System.Text.Json.Serialization;

namespace CSC_Assistant.Common.DataStructures
{
    public class Resource
    {
        [JsonPropertyName("itemID")]
        public virtual string ItemID { get; set; }

        public virtual double Amount { get { return 0; } }
    }
}