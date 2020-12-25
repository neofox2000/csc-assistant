using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CSC_Assistant.Common.DataStructures
{
    public class Blob
    {
        [JsonPropertyName("_id")]
        public string Key { get; set; }

        /// <summary>
        /// A shortened version of the normally used itemId (eg: V1002 instead of FT:V1002)
        /// </summary>
        [JsonPropertyName("itemID")]
        public string ShortItemID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("subType")]
        public string SubType { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("unitWeight")]
        public int UnitWeight { get; set; }

        [JsonPropertyName("techLevel")]
        public int? TechLevel { get; set; }

        [JsonPropertyName("scanColor")]
        public string ScanColor { get; set; }

        [JsonPropertyName("#slotcount")]
        public string Slotcount { get; set; }

        [JsonPropertyName("baseCargo")]
        public int? BaseCargo { get; set; }

        [JsonPropertyName("baseFTL")]
        public double? BaseFTL { get; set; }

        [JsonPropertyName("class")]
        public string Class { get; set; }

        [JsonPropertyName("classType")]
        public string ClassType { get; set; }

        [JsonPropertyName("hardPointsLimit")]
        public int? HardPointsLimit { get; set; }

        [JsonPropertyName("implementationState")]
        public string ImplementationState { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("isHardPoint")]
        public bool? IsHardPoint { get; set; }

        [JsonPropertyName("jumpDrive")]
        public bool? JumpDrive { get; set; }

        [JsonPropertyName("preEquippedModulesList")]
        public string PreEquippedModulesList { get; set; }

        [OmitFromViewing]
        [JsonPropertyName("prod")]
        public bool Prod { get; set; }

        [OmitFromViewing]
        [JsonPropertyName("uniqueFeature")]
        public string UniqueFeature { get; set; }
        
        [OmitFromViewing]
        [JsonPropertyName("catalogIndex")]
        public bool CatalogIndex { get; set; }

        [OmitFromViewing]
        [JsonPropertyName("gameData")]
        public GameData GameData { get; set; }

        [OmitFromViewing]
        [JsonPropertyName("marketData")]
        public MarketData MarketData { get; set; }

        [OmitFromViewing]
        [JsonPropertyName("location")]
        public string Location { get; set; }

        [OmitFromViewing]
        [JsonPropertyName("iconLocation")]
        public string IconLocation { get; set; }

        [OmitFromViewing]
        [JsonPropertyName("slots")]
        public List<string> Slots { get; set; }

        [OmitFromViewing]
        [JsonPropertyName("webData")]
        public WebData WebData { get; set; }

        [OmitFromViewing]
        [JsonPropertyName("iconURL")]
        public string IconURL { get; set; }
    }
}