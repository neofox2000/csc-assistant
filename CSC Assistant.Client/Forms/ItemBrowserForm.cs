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
        }

        private void ItemBrowserForm_Shown(object sender, EventArgs e)
        {
            if (!ItemDB.Read())
            {
                MessageBox.Show($"Error loading test file: {ItemDB.tempDBPath}");
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