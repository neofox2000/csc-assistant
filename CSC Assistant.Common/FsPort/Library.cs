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

        public static (ItemType, Dictionary<string, double>) ItemParts(Dictionary<string, Item> itemMap, string itemId)
        {
            var data = itemMap[itemId].Blob.GameData;
            Func<Resource, KeyValuePair<string, double>> splitLambda =
                r => KeyValuePair.Create(r.ItemID, (double)r.Amount);
            if (data.CraftingResources != null && data.CraftingResources.Count > 0)
            {
                var craftMap = new Dictionary<string, double>(data.CraftingResources.Select(splitLambda));
                return (ItemType.NFT, craftMap);
            }
            else if (data.RefinedResources != null && data.RefinedResources.Count > 0)
            {
                var refineMap = new Dictionary<string, double>(data.RefinedResources.Select(splitLambda));
                return (ItemType.FT, refineMap);
            }
            else
            {
                return (ItemType.Ore, new Dictionary<string, double>());
            }
        }

        public static Dictionary<string, Item> ItemMap(IEnumerable<Item> allItems) =>
            new Dictionary<string, Item>(allItems.Select(i => KeyValuePair.Create(i.Id, i)));

        public static Dictionary<string, double> mergeMaps(Dictionary<string, double> dict1, Dictionary<string, double> dict2) =>
            new(dict1.Concat(dict2)
                .GroupBy(kvp => kvp.Key)
                .Select(grp => KeyValuePair.Create(
                    grp.Key,
                    grp.Select(g => g.Value).Sum())));

        public static Dictionary<string, double> mergeMapSeq(IEnumerable<Dictionary<string, double>> arg) =>
            arg.Aggregate(new Dictionary<string, double>(), (state, dict) => mergeMaps(state, dict));

        public static Dictionary<string, double> DeeperParts(Dictionary<string, Item> itemMap, Dictionary<string, double> parts) =>
            mergeMapSeq(
                parts.Select(kvp =>
                {
                    var (typ, ps) = ItemParts(itemMap, "FT:" + kvp.Key);
                    switch (typ)
                    {
                        case ItemType.Ore:
                            return new Dictionary<string, double> { { kvp.Key, kvp.Value } };
                        default:
                            return new Dictionary<string, double>(ps.Select(p => KeyValuePair.Create(p.Key, p.Value * kvp.Value)));
                    }
                }));
    }
}
