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

        /// <summary>
        /// Downloads full json database of CSC items from C3's endpoint
        /// Saves this json database to local file
        /// </summary>
        public static void UpdateLocalItemDatabase()
        {
            client.BaseAddress = new Uri(baseApiUri);

            try
            {
                var response = client.GetAsync(itemsUri).Result;

                if (response.IsSuccessStatusCode)
                {
                    string rawJson = response.Content.ReadAsStringAsync().Result;
                    File.WriteAllText(fullDbPath, rawJson);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Reads the last write date/time of the local item database
        /// </summary>
        /// <returns>Last write date on file, or lowest date value if no file/error reading file</returns>
        public static DateTime GetDatabaseLastWriteDate()
        {
            try { return File.GetLastWriteTime(fullDbPath); }
            catch { return DateTime.MinValue; }
        }

        /// <summary>
        /// Reads the local copy of the CSC Item Database into memory
        /// </summary>
        /// <returns>True if worked, False for all other cases</returns>
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