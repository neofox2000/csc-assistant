using System.Text.Json.Serialization;

namespace CSC_Assistant
{
    public class Item
    {
        [JsonPropertyName("blob")]
        public Blob Blob { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}