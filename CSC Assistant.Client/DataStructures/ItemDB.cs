using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Net.Http.Headers;

namespace CSC_Assistant.Client.DataStructures
{
    public static class ItemDB
    {
        const string baseApiUri = @"https://crosscuttingconcern.builtwithdark.com/";
        const string itemsUri = @"items/";
        const string DbFileName = "itemsDb.json";

        public const string tempDBPath = @"X:\downloads\items.json";

        public static List<Item> items;
        
        static HttpClient HClient = new HttpClient();
        
        public static int ItemCount { get { return items == null ? 0 : items.Count; } }

        static async Task<string> GetDataFromApi(string path)
        {
            string rawJson = string.Empty;
            HttpResponseMessage response = await HClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                rawJson = await response.Content.ReadAsStringAsync();
            }
            return rawJson;
        }

        static async Task RunAsync()
        {
            // Update port # in the following line.
            HClient.BaseAddress = new Uri(baseApiUri);
            HClient.DefaultRequestHeaders.Accept.Clear();
            HClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Get the product
                var rawjson = await GetDataFromApi(itemsUri);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        public static bool Read()
        {
            if(!File.Exists(tempDBPath)) return false;

            items = new List<Item>();

            var rawJson = File.ReadAllText(tempDBPath);

            items.AddRange(JsonSerializer.Deserialize<Item[]>(rawJson));

            return true;
        }

        public static Item LookupId(string itemId)
        {
            return items.Find(x => x.Blob.ItemID == itemId);
        }
    }
}