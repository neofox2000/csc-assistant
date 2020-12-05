using System;
using System.Collections.Generic;
using System.Text;

namespace CSC_Assistant
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class RefinedResource
    {
        public string asset { get; set; }
        public string itemID { get; set; }
        public double optimalQty { get; set; }
    }

    public class GameData
    {
        public bool allowRNG { get; set; }
        public string description { get; set; }
        public int refineTimePerUnit { get; set; }
        public List<RefinedResource> refinedResources { get; set; }
    }

    public class PriceData
    {
        public int avgPricePerUnit { get; set; }
        public double avgUSDPerUnit { get; set; }
        public string currencyType { get; set; }
        public int maxPricePerUnit { get; set; }
        public double maxUSDPerUnit { get; set; }
        public int minPricePerUnit { get; set; }
        public double minUSDPerUnit { get; set; }
        public int totalQtySold { get; set; }
        public int totalSalesPrice { get; set; }
        public double totalSalesUSD { get; set; }
        public int totalTXCount { get; set; }
    }

    public class MarketData
    {
        public PriceData GFC { get; set; }
        public PriceData GRP { get; set; }
        public string asset { get; set; }
        public double gfEstUSDItemMarketCap { get; set; }
        public double gfEstUSDValue { get; set; }
        public double grpUSDValueForItem { get; set; }
        public string itemID { get; set; }
        public long lastUpdated { get; set; }
        public int totalItems { get; set; }
    }

    public class Item
    {
        public string _id { get; set; }
        public bool catalogIndex { get; set; }
        public string category { get; set; }
        public GameData gameData { get; set; }
        public string itemID { get; set; }
        public MarketData marketData { get; set; }
        public string name { get; set; }
        public bool prod { get; set; }
        public string rarity { get; set; }
        public string subType { get; set; }
        public string type { get; set; }
        public int unitWeight { get; set; }
    }


    public class ItemDB
    {

    }
}
