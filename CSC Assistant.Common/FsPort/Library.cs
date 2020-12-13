using CSC_Assistant.Common.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_Assistant.Common.FsPort
{
    public static class Algorithms
    {
        // Not exactly the same as in F# but close enough in this case
        public enum ItemType { NFT, FT, Ore }

        public static (ItemType, Dictionary<string, double>) ItemParts (Dictionary<string, Item> itemMap, string itemId )
        {
            var data = itemMap[itemId].Blob.GameData;
            Func<Resource, KeyValuePair<string, double>> splitLambda = 
                r => KeyValuePair.Create(r.ItemID, (double)r.Amount);
            if (data.CraftingResources != null && data.CraftingResources.Count > 0)
            {
                var craftMap = new Dictionary<string, double>(data.CraftingResources.Select(splitLambda));
                return (ItemType.NFT, craftMap);
            }else if (data.RefinedResources != null && data.RefinedResources.Count > 0)
            {
                var refineMap = new Dictionary<string, double>(data.RefinedResources.Select(splitLambda));
                return (ItemType.FT, refineMap);
            }else
            {
                return (ItemType.Ore, new Dictionary<string, double>());
            }
        }

        public static Dictionary<string, Item> ItemMap(IEnumerable<Item> allItems) => 
            new Dictionary<string, Item>(allItems.Select(i => KeyValuePair.Create(i.ItemId, i)));
    }
}
