using System;
using System.Windows.Forms;
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
            if(timeSpan.Days > 1)
            {
                //TODO: Fix this!
                //MessageBox.Show("Fetching Updated Items DB...");
                //ItemDB.UpdateLocalItemDatabase().GetAwaiter().GetResult();
                //MessageBox.Show("Finished!");
            }

            if (!ItemDB.ReadLocalItemDatabase())
            {
                //MessageBox.Show($"Error loading local item database");
                return;
            }

            TestDBGridView.DataSource = ItemDB.GetDataTable();

            //Hide key column
            TestDBGridView.Columns[0].Visible = false;

            TestDBGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void TestDBGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Don't consider header row
            if (e.RowIndex < 0) return;

            Program.OnShowItemUsedIn.Invoke(ItemDB.LookupKey(TestDBGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
        }
    }
}