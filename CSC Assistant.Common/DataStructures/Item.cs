using System.Text.Json.Serialization;

namespace CSC_Assistant.Common.DataStructures
{
    public class Item
    {
        [JsonPropertyName("blob")]
        public Blob Blob { get; set; }

        [JsonPropertyName("id")]
        public string ItemId { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        public override string ToString() => // XD
            $"{Name} {(Blob.TechLevel != null ? "T{Blob.TechLevel}" : "" )}";
    }
}