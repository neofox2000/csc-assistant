using System.Collections.Generic;
using Microsoft.FSharp.Collections;
using System.IO;
using System.Text.Json;
using System.Net.Http;
using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CSC_Assistant.Common.DataStructures;
using CSC_Assistant.Algo;

namespace CSC_Assistant.Client.Data
{
    public static class ItemDB
    {
        const string baseApiUri = @"https://crosscuttingconcern.builtwithdark.com/";
        const string itemsUri = @"items";
        const string DbFileName = "items.json";

        public static List<Item> Items { get; private set; }
        public static FSharpMap<string, Item> ItemMap;
        public enum ResourceType { Craft, Refine };

        public static int ResourceTreeDepth { get; set; } = 3;

        static readonly HttpClient client = new ();
        static string FullDbPath => @$"{Program.outputPath}\{DbFileName}";

        public static int ItemCount => Items == null ? 0 : Items.Count;

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
                    File.WriteAllText(FullDbPath, rawJson);
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
            try { return File.GetLastWriteTime(FullDbPath); }
            catch { return DateTime.MinValue; }
        }

        /// <summary>
        /// Reads the local copy of the CSC Item Database into memory
        /// </summary>
        /// <returns>True if worked, False for all other cases</returns>
        public static bool ReadLocalItemDatabase()
        {
            if (!File.Exists(FullDbPath)) return false;

            Items = new List<Item>();

            var rawJson = File.ReadAllText(FullDbPath);

            Items.AddRange(JsonSerializer.Deserialize<Item[]>(rawJson));

            //Create fast lookup map
            ItemMap = Algorithms.ItemMap(Items);

            return true;
        }

        public static Item LookupItemID(string itemId)
        {
            return ItemMap[itemId];
            //try { return ItemMap[itemId]; }
            //catch { return null; }
        }
        public static Item LookupKey(string key)
        {
            return Items.Find(x => x.Key == key);
        }

        public static string GetResourcesDisplayList(Resource[] resources)
        {
            //Bail if nothing else to do
            if (resources == null || resources.Length == 0) return "N/A";

            StringBuilder resDisplay = new(resources.Length);

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
                Items.Select(x => x.Blob as BlobForDisplay).ToList());
        }

        public static TreeNode GetItemResourceTree(Item item, Algorithms.ItemType resType)
        {
            TreeNode rootItem = new(item.ToString());
            BuildTreeFromItem(item, resType, rootItem, ResourceTreeDepth);

            return rootItem;
        }
        private static void BuildTreeFromItem(Item item, Algorithms.ItemType resType, TreeNode parentNode, int depth)
        {
            var resources = Algorithms.ItemParts(ItemMap, item.Id, resType).Item2;

            //Bail if nothing to do
            if (resources.IsEmpty) return;

            //Iterate through all items in the database
            foreach (var res in resources)
            {
                var resItem = ItemMap[res.Key];
                var newNode = parentNode.Nodes.Add($"{res.Value}x {resItem.Name}");

                //Build sub-nodes if needed
                var newDepth = depth - 1;
                
                if (newDepth > 0) BuildTreeFromItem(
                    LookupItemID(res.Key), 
                    resType, 
                    newNode, 
                    newDepth);
            }
        }
    }
}