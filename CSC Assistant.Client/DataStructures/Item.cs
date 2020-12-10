using System.Text.Json.Serialization;

namespace CSC_Assistant.Client.DataStructures
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

        public override string ToString()
        {
            if (Blob.TechLevel != null)
                return $"{Name} T{Blob.TechLevel}";
            else
                return Name;
        }
    }
}