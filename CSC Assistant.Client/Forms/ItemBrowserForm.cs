using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CSC_Assistant.Client.Data;
using CSC_Assistant.Client.Utils;
using CSC_Assistant.Common.DataStructures;
using CSC_Assistant.Client.Properties;

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
            LoadSettings();
            RefreshItems();
        }

        private void LoadSettings()
        {
            BaseYeildNUD.Value = Settings.Default.BaseYield;
            InputModifierNUD.Value = Settings.Default.AugInput;
            YieldModifierNUD.Value = Settings.Default.AugYield;
        }

        private void SaveSettings()
        {
            Settings.Default.BaseYield = BaseYeildNUD.Value;
            Settings.Default.AugInput = InputModifierNUD.Value;
            Settings.Default.AugYield = YieldModifierNUD.Value;
            Settings.Default.Save();
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

            //ItemDB.ResourceTreeDepth = 10;
            var qty = (double)QuantityNUD.Value;
            var shopStats = new Workshop.Stats()
            {
                useStats = UseShopStatsCheckBox.Checked,
                yield = (double)BaseYeildNUD.Value, 
                inputModifier = (double)InputModifierNUD.Value, 
                outputModifier = (double)YieldModifierNUD.Value
            };

            ComponentUtility.SetTreeViewRootNode(
                PartsTreeView,
                ItemDB.GetItemResourceTree(item, ItemDB.ResourceTreeType.Parts, shopStats, qty));
            ComponentUtility.SetTreeViewRootNode(
                MakesTreeView,
                ItemDB.GetItemResourceTree(item, ItemDB.ResourceTreeType.Makes, shopStats, qty));
        }

        private void TreeNodeToText(TreeNode node, List<string> output, int currentDepth, int maxDepth)
        {
            if (currentDepth > maxDepth) return;

            output.Add($"{new string('-', Math.Max(0, currentDepth - 1))} {node.Text}");
            if (node.Nodes.Count > 0)
                for (int i = 0; i < node.Nodes.Count; i++)
                    TreeNodeToText(node.Nodes[i], output, currentDepth + 1, maxDepth);
        }

        private void PartsTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Copy csv data to clipboard
            List<string> output = new();
            TreeNodeToText(PartsTreeView.Nodes[0], output, 0, (int)ClipboardCopyDepthNUD.Value);

            StringBuilder sb = new(output.Count);
            for (int i = 0; i < output.Count; i++)
                sb.Append($"{output[i]}\n");

            var outputString = sb.ToString();
            Clipboard.SetText(outputString);
            MessageBox.Show($"The following was copied to clipboard:\n\n{outputString}");
        }

        private void UseShopStatsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCraftTrees();
        }

        private void QuantityNUD_ValueChanged(object sender, EventArgs e)
        {
            UpdateCraftTrees(
                GetRowItem(ItemsGridView.SelectedCells[0].RowIndex));
        }
    }
}