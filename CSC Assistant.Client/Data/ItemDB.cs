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

        public enum ResourceTreeType { Parts, Makes }

        public static List<Item> Items { get; private set; }
        static FSharpMap<string, Item> ItemMap;

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

        public static string GetResourcesDisplayList(Item item)
        {
            var resources = Algorithms.ItemParts(ItemMap, item.Id).Item2;

            //Bail if nothing else to do
            if (resources == null || resources.Count == 0) return "N/A";

            StringBuilder resDisplay = new(resources.Count);

            foreach (var res in resources)
            {
                //Fetch item
                Item resItem = LookupItemID(res.Key);

                //Handle bad id
                if (resItem == null)
                {
                    resDisplay.Append("<bad id>\n");
                    continue;
                }

                //Display relevant item details
                resDisplay.Append($"{res.Value}x {resItem.Name}\n");
            }

            return resDisplay.ToString();
        }
        public static DataTable GetDataTable(string itemFilter = null)
        {
            DataTable dataTable = new("Items");
            var itemList = new List<Blob>();

            if ((itemFilter == null) || (itemFilter == string.Empty))
            {
                itemList = Items
                    .Select(x => x.Blob).ToList();
            }
            else
            {
                var myRegex = new System.Text.RegularExpressions.Regex(
                    $"^{itemFilter}",
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                itemList = Items
                    .Where(x => x.Name != null && myRegex.IsMatch(x.Name))
                    .Select(x => x.Blob).ToList().ToList();
            }

            return ListtoDataTableConverter.ToDataTable(itemList, typeof(OmitFromViewing));
        }

        public static TreeNode GetItemResourceTree(Item item, ResourceTreeType treeType, Workshop.Stats shopStats, double amount)
        {
            //Root just gets a name
            TreeNode rootItem = new(item.ToString());

            //Child nodes get name + quantity
            if (treeType == ResourceTreeType.Parts)
                BuildPartsTree(item, rootItem, ResourceTreeDepth, shopStats, amount);
            else
                BuildMakesTree(item, rootItem, ResourceTreeDepth);

            return rootItem;
        }
        private static void BuildPartsTree(Item item, TreeNode parentNode, int depth, Workshop.Stats shopStats, double amount)
        {
            var resources = Algorithms.ItemParts(ItemMap, item.Id).Item2;

            //Bail if nothing to do
            if (resources.IsEmpty) return;

            //Iterate through all items in the database
            foreach (var res in resources)
            {
                var resItem = ItemMap[res.Key];
                var newNode = parentNode.Nodes.Add($"{res.Value * amount}x {resItem}");

                //Build sub-nodes if needed
                var newDepth = depth - 1;
                
                if (newDepth > 0) BuildPartsTree(
                    LookupItemID(res.Key), 
                    newNode, 
                    newDepth,
                    shopStats,
                    res.Value * amount);
            }
        }
        private static void BuildMakesTree(Item item, TreeNode parentNode, int depth)
        {
            //Iterate through each item in the database
            foreach (var itemCandidate in ItemMap)
            {
                var resources = Algorithms.ItemParts(ItemMap, itemCandidate.Key).Item2;
                if (resources.IsEmpty) continue;

                //Iterate through each component to see if it is made of item
                foreach(var res in resources)
                {
                    if(res.Key == item.Id)
                    {
                        var newNode = parentNode.Nodes.Add($"{itemCandidate.Value} [{res.Value}]");

                        //Build sub-nodes if needed
                        if (depth > 0) BuildMakesTree(
                            LookupItemID(itemCandidate.Key),
                            newNode,
                            depth - 1);
                    }
                }
            }
        }
    }
}