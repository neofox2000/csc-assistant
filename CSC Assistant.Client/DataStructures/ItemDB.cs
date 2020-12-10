using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Net.Http.Headers;
using System.Text;
using System.Data;
using System.Linq;

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


        public static void UpdateLocalItemDatabase()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri(baseApiUri);
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string rawJson = string.Empty;
            try
            {
                var response = client.GetAsync(itemsUri).Result;

                if (response.IsSuccessStatusCode)
                    rawJson =  response.Content.ReadAsStringAsync().Result;
                items = new List<Item>(JsonSerializer.Deserialize<Item[]>(rawJson));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        public static DateTime GetDatabaseLastWriteDate()
        {
            try { return File.GetLastWriteTime(fullDbPath); }
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

        public static Item LookupItemID(string itemId)
        {
            return items.Find(x => x.ItemId == itemId);
        }
        public static Item LookupKey(string key)
        {
            return items.Find(x => x.Key == key);
        }

        public static string GetResourcesDisplayList(Resource[] resources)
        {
            //Bail if nothing else to do
            if (resources == null || resources.Length == 0) return "N/A";

            StringBuilder resDisplay = new StringBuilder(resources.Length);

            foreach (Resource res in resources)
            {
                //Fetch item
                Item item = LookupItemID(res.ItemID);

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
        public static DataTable GetDataTable()
        {
            return ListtoDataTableConverter.ToDataTable(
                items.Select(x => x.Blob as BlobForDisplay).ToList());
        }
    }
}