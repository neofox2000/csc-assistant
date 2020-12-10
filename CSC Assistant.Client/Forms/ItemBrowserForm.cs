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

            TestDBGridView.DataSource = ItemDB.GetDataTable();

            //Hide key column
            TestDBGridView.Columns[0].Visible = false;

            //Tidy up a bit
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