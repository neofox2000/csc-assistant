using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Net.Http.Headers;
using System.Text;

namespace CSC_Assistant.Client.DataStructures
{
    public static class ItemDB
    {
        const string baseApiUri = @"https://crosscuttingconcern.builtwithdark.com/";
        const string itemsUri = @"items";
        const string DbFileName = "items.json";

        public static List<Item> items;
        
        static HttpClient client = new HttpClient();
        static string fullDbPath { get { return @$"{Program.outputPath}\{DbFileName}"; } }

        public static int ItemCount { get { return items == null ? 0 : items.Count; } }

        static async Task<string> GetDataFromApi(string path)
        {
            string rawJson = string.Empty;
            var response = await client.GetAsync(path);
            
            if (response.IsSuccessStatusCode)
                rawJson = await response.Content.ReadAsStringAsync();

            return rawJson;
        }

        public static async Task UpdateLocalItemDatabase()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri(baseApiUri);
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

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

        public static DateTime GetDatabaseLastWriteDate()
        {
            try   { return File.GetLastWriteTime(fullDbPath); }
            catch { return DateTime.MinValue; }
        }

        public static bool ReadLocalItemDatabase()
        {            
            if (!File.Exists(fullDbPath)) return false;

            items = new List<Item>();

            var rawJson = File.ReadAllText(fullDbPath);

            items.AddRange(JsonSerializer.Deserialize<Item[]>(rawJson));

            return true;
        }

        public static Item LookupId(string itemId)
        {
            return items.Find(x => x.Blob.ItemID == itemId);
        }

        public static string GetResourcesDisplayList(Resource[] resources)
        {
            //Bail if nothing else to do
            if (resources == null || resources.Length == 0) return "N/A";

            StringBuilder resDisplay = new StringBuilder(resources.Length);

            foreach (Resource res in resources)
            {
                //Fetch item
                Item item = LookupId(res.ItemID);

                //Handle bad id
                if (item == null)
                {
                    resDisplay.Append("<bad id>\n");
                    continue;
                }

                //Display relevant item details
                resDisplay.Append($"{res.Amount}x {item.Name}\n");
            }

            return resDisplay.ToString();
        }
    }
}