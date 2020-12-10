using System.Windows.Forms;
using CSC_Assistant.Client.Data;
using CSC_Assistant.Common.DataStructures;
using System.Linq;

namespace CSC_Assistant.Client.Forms
{
    public partial class ItemUsedInRecipesForm : Form
    {
        const int treeDepth = 10;

        public ItemUsedInRecipesForm()
        {
            InitializeComponent();

            Program.OnShowItemUsedIn += ShowItem;
        }

        private void ShowItem(Item item)
        {
            ItemTreeView.Nodes.Clear();

            Location = MousePosition;

            //Build tree structure
            TreeNode rootItem = new TreeNode(item.ToString());
            BuildTreeFromItem(item, rootItem, treeDepth);

            //Add to controls for display
            ItemTreeView.Nodes.Add(rootItem);
            ItemTreeView.Nodes[0].Expand();

            //Present form to user
            Show();
            BringToFront();
        }

        private void BuildTreeFromItem(Item item, TreeNode parentNode, int depth)
        {
            //Iterate through all items in the database
            foreach (Item dbItem in ItemDB.items)
            {
                Resource[] resources = null;

                if (dbItem.Blob.GameData.RefinedResources != null)
                    resources = dbItem.Blob.GameData.RefinedResources.ToArray();

                if (dbItem.Blob.GameData.CraftingResources != null)
                {
                    if (resources == null)
                        resources = dbItem.Blob.GameData.CraftingResources.ToArray();
                    else
                        resources = resources.Union(dbItem.Blob.GameData.CraftingResources.ToArray()).ToArray();
                }

                //Skip items with no crafting components
                if (resources == null || resources.Length == 0) continue;

                //Iterate through all crafting components
                foreach (Resource res in resources)
                {
                    //Create nodes for matching components
                    if ($"FT:{res.ItemID}" == item.ItemId)
                    {
                        var newNode = parentNode.Nodes.Add(dbItem.ToString());

                        //Build sub-nodes if needed
                        var newDepth = depth - 1;
                        if (newDepth > 0) BuildTreeFromItem(dbItem, newNode, newDepth);
                    }
                }
            }
        }
    }
}