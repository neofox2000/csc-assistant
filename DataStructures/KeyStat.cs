using System.Text.Json.Serialization;

namespace CSC_Assistant
{
    public class KeyStat
    {
        [JsonPropertyName("gameDataField")]
        public string GameDataField { get; set; }

        [JsonPropertyName("gameDataIncrement")]
        public string GameDataIncrement { get; set; }

        [JsonPropertyName("gameDataLabel")]
        public string GameDataLabel { get; set; }
    }
}