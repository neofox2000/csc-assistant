using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSC_Assistant
{
    public static class ItemDB
    {
        const string ApiUrl = @"https://crosscuttingconcern.builtwithdark.com/items";
        const string DbFileName = "itemsDb.json";

        const string tempDBPath = @"X:\downloads\items.json";

        public static List<Item> items;
        
        //HttpClient HClient = new HttpClient();
        
        public static int ItemCount { get { return items == null ? 0 : items.Count; } }

        public static bool Read()
        {
            if(!File.Exists(tempDBPath)) return false;

            items = new List<Item>();

            var rawJson = File.ReadAllText(tempDBPath);

            items.AddRange(JsonSerializer.Deserialize<Item[]>(rawJson));

            return true;
        }
    }
}