using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CSC_Assistant.Client.Data;
using CSC_Assistant.Client.Utils;
using CSC_Assistant.Common.DataStructures;

namespace CSC_Assistant.Client.Forms
{
    public partial class ItemBrowserForm : Form
    {
        public ItemBrowserForm()
        {
            InitializeComponent();

            Program.OnLocalItemDbUpdated += RefreshItems;
        }

        private void ItemBrowserForm_Shown(object sender, EventArgs e)
        {
            RefreshItems();
        }

        private void RefreshItems()
        {
            TimeSpan timeSpan = DateTime.Now - ItemDB.GetDatabaseLastWriteDate();

            //If the database hasn't been updated in a day, try to fetch a new file (if user wants)
            if (timeSpan.Days > 1)
            {
                var response = MessageBox.Show(
                    "Do you want to download an updated item database? (You will need to do this at least once for this feature to work)",
                    "Download Item Database Update?",
                    MessageBoxButtons.YesNo);

                if (response == DialogResult.Yes)
                {
                    ItemDB.UpdateLocalItemDatabase();
                    MessageBox.Show("Finished!");
                }
            }

            if (!ItemDB.ReadLocalItemDatabase())
            {
                MessageBox.Show($"No database found, or error reading database file\nRestart this app to try again");
                return;
            }

            UpdateGrid(null);
        }

        private void UpdateGrid(string itemFilter)
        {

            ItemsGridView.DataSource = ItemDB.GetDataTable(itemFilter);

            //Hide key column
            ItemsGridView.Columns[0].Visible = false;

            //Tidy up a bit
            ItemsGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void TestDBGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.OnShowItemDetails.Invoke(GetRowItem(e.RowIndex));
        }

        private void ItemsGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            UpdateCraftTrees(GetRowItem(e.RowIndex));
        }

        private Item GetRowItem(int rowIndex)
        {
            //Header row is invalid
            if (rowIndex < 0) return null;

            return ItemDB.LookupKey(
                    ItemsGridView.Rows[rowIndex].Cells[0].Value.ToString());
        }

        private void ItemNameFilterTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UpdateGrid(ItemNameFilterTextBox.Text);
        }

        private void QuantityNUD_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateCraftTrees(
                GetRowItem(ItemsGridView.SelectedCells[0].RowIndex));
        }
        
        private void UpdateCraftTrees(Item item = null)
        {
            //Try to get the item from available grid selection
            if(item == null)
                item = GetRowItem(ItemsGridView.SelectedCells[0].RowIndex);

            //If no items possible, clear trees
            if (item == null)
            {
                PartsTreeView.Nodes.Clear();
                MakesTreeView.Nodes.Clear();
                return;
            }

            ItemDB.ResourceTreeDepth = (int)TreeDepthNUD.Value;
            var qty = (double)QuantityNUD.Value;
            var shopStats = new Workshop.Stats()
            {
                useStats = UseShopStatsCheckBox.Checked,
                yield = (float)(BaseYeildNUD.Value), 
                inputModifier = (float)(InputModifierNUD.Value), 
                outputModifier = (float)(YieldModifierNUD.Value)
            };

            ComponentUtility.SetTreeViewRootNode(
                PartsTreeView,
                ItemDB.GetItemResourceTree(item, ItemDB.ResourceTreeType.Parts, shopStats, qty));
            ComponentUtility.SetTreeViewRootNode(
                MakesTreeView,
                ItemDB.GetItemResourceTree(item, ItemDB.ResourceTreeType.Makes, shopStats, qty));
        }

        private void Bleh(TreeNode node, List<string> output)
        {
            output.Add(node.Text);
            if (node.Nodes.Count > 0)
                for (int i = 0; i < node.Nodes.Count; i++)
                    Bleh(node.Nodes[i], output);
        }

        private void PartsTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Copy csv data to clipboard
            List<string> output = new();
            Bleh(PartsTreeView.Nodes[0], output);

            StringBuilder sb = new(output.Count);
            for (int i = 0; i < output.Count; i++)
                sb.Append($"{output[i]}\n");
            MessageBox.Show(sb.ToString());
        }

        private void UseShopStatsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCraftTrees();
        }
    }
}