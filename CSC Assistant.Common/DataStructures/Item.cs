using System.Text.Json.Serialization;
using Microsoft.FSharp.Collections;

namespace CSC_Assistant.Common.DataStructures
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

        //Cached parts list
        public FSharpMap<string, double> PartsList { get; set; }

        public override string ToString() => // XD
            $"{Name} {(Blob.TechLevel != null ? $"T{Blob.TechLevel}" : "" )}";

        public string ItemIdFull() => $"{Id}";
    }
}