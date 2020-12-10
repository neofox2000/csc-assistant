using System.Text.Json.Serialization;

namespace CSC_Assistant.Common.DataStructures
{
    public class Bonuses
    {
        [JsonPropertyName("cargo")]
        public string Cargo { get; set; }

        [JsonPropertyName("defensePower")]
        public string DefensePower { get; set; }

        [JsonPropertyName("miningPower")]
        public string MiningPower { get; set; }

        [JsonPropertyName("miningSpeed")]
        public string MiningSpeed { get; set; }

        [JsonPropertyName("miningYield")]
        public string MiningYield { get; set; }

        [JsonPropertyName("qJump")]
        public string QJump { get; set; }

        [JsonPropertyName("qJumpEfficiency")]
        public string QJumpEfficiency { get; set; }

        [JsonPropertyName("ftl")]
        public string Ftl { get; set; }

        [JsonPropertyName("personnelCapacity")]
        public string PersonnelCapacity { get; set; }

        [JsonPropertyName("subLight")]
        public string SubLight { get; set; }

        [JsonPropertyName("damage")]
        public string Damage { get; set; }

        [JsonPropertyName("damagePower")]
        public string DamagePower { get; set; }

        [JsonPropertyName("enginePower")]
        public string EnginePower { get; set; }

        [JsonPropertyName("power")]
        public string Power { get; set; }

        [JsonPropertyName("personnelWeightReduction")]
        public string PersonnelWeightReduction { get; set; }

        [JsonPropertyName("defense")]
        public string Defense { get; set; }

        [JsonPropertyName("miningWeightReduction")]
        public string MiningWeightReduction { get; set; }
    }
}