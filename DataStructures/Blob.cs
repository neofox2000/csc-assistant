﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CSC_Assistant
{
    public class BlobForDisplay
    {
        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("itemID")]
        public string ItemID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("prod")]
        public bool Prod { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("subType")]
        public string SubType { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("unitWeight")]
        public int UnitWeight { get; set; }

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

        [JsonPropertyName("techLevel")]
        public int? TechLevel { get; set; }

        [JsonPropertyName("isHardPoint")]
        public bool? IsHardPoint { get; set; }

        [JsonPropertyName("jumpDrive")]
        public bool? JumpDrive { get; set; }

        [JsonPropertyName("preEquippedModulesList")]
        public string PreEquippedModulesList { get; set; }

        [JsonPropertyName("uniqueFeature")]
        public string UniqueFeature { get; set; }
    }
    public class Blob : BlobForDisplay
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("catalogIndex")]
        public bool CatalogIndex { get; set; }

        [JsonPropertyName("gameData")]
        public GameData GameData { get; set; }

        [JsonPropertyName("marketData")]
        public MarketData MarketData { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("iconLocation")]
        public string IconLocation { get; set; }

        [JsonPropertyName("slots")]
        public List<string> Slots { get; set; }

        [JsonPropertyName("webData")]
        public WebData WebData { get; set; }

        [JsonPropertyName("iconURL")]
        public string IconURL { get; set; }

    }
}