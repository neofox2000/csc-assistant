using System;
using System.Windows.Forms;
using System.Linq;
using System.Data;

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
            Dock = DockStyle.Fill;

            if (!ItemDB.Read())
            {
                MessageBox.Show($"Error loading test file: {ItemDB.tempDBPath}");
                return;
            }

            TestDBGridView.DataSource = ListtoDataTableConverter.ToDataTable(
                ItemDB.items.Select(x => x.Blob as BlobForDisplay).ToList());
        }

        private void TestDBGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.OnShowItemDetails?.Invoke(
                ItemDB.items[e.RowIndex]);
        }
    }
}