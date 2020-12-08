using System;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using CSC_Assistant.Client.DataStructures;

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

            //If the database hasn't been updated in a day, try to fetch a new file
            if (timeSpan.Days > 1)
            {
                //TODO: Fix this!
                MessageBox.Show("Fetching Updated Items DB...");
                ItemDB.UpdateLocalItemDatabase();
                MessageBox.Show("Finished!");
            }

            if (!ItemDB.ReadLocalItemDatabase())
            {
                //MessageBox.Show($"Error loading local item database");
                return;
            }

            TestDBGridView.DataSource = ListtoDataTableConverter.ToDataTable(
                ItemDB.items.Select(x => x.Blob as BlobForDisplay).ToList());

            TestDBGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void TestDBGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Don't consider header row
            if (e.RowIndex < 0) return;

            Program.OnShowItemDetails?.Invoke(ItemDB.LookupId(
                TestDBGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
        }
    }
}