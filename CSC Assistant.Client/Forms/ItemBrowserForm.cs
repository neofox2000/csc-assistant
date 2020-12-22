using System;
using System.Windows.Forms;
using CSC_Assistant.Algo;
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

            ItemsGridView.DataSource = ItemDB.GetDataTable();

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
            var item = GetRowItem(e.RowIndex);
            ComponentUtility.SetTreeViewRootNode(
                CraftsTreeView, 
                ItemDB.GetItemResourceTree(item, Algorithms.ItemType.FT));
            ComponentUtility.SetTreeViewRootNode(
                RefinesTreeView,
                ItemDB.GetItemResourceTree(item, Algorithms.ItemType.NFT));
        }

        private Item GetRowItem(int rowIndex)
        {
            //Header row is invalid
            if (rowIndex < 0) return null;

            return ItemDB.LookupKey(
                    ItemsGridView.Rows[rowIndex].Cells[0].Value.ToString());
        }
    }
}