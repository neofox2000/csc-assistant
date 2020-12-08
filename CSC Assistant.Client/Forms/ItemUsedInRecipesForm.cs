using System.Windows.Forms;
using CSC_Assistant.Client.DataStructures;

namespace CSC_Assistant.Client.Forms
{
    public partial class ItemUsedInRecipesForm : Form
    {
        public ItemUsedInRecipesForm()
        {
            InitializeComponent();

            Program.OnShowItemUsedIn += ShowItem;
        }

        private void ShowItem(Item item)
        {
            ItemTreeView.Nodes.Clear();

            Location = MousePosition;

            //ItemTreeView.Nodes.ad

            //Build tree structure
            ItemTreeView.Nodes.Add(BuildTreeFromItem(item));

            Show();
        }

        private TreeNode BuildTreeFromItem(Item item)
        {
            TreeNode rootItem = new TreeNode(item.Name);

            foreach (Item dbItem in ItemDB.items)
                foreach (RefinedResource rr in dbItem.Blob.GameData.RefinedResources)
                    if (rr.ItemID == item.Blob.Id)
                        rootItem.Nodes.Add(dbItem.Name);

            return rootItem;
        }
    }
}
