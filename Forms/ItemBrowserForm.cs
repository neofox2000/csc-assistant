using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace CSC_Assistant.Forms
{
    public partial class ItemBrowserForm : Form
    {
        public ItemBrowserForm()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            TestButton.Enabled = false;

            if (ItemDB.Read())
            {
                var bindingList = new BindingList<Blob>(
                    ItemDB.items.Select(x => x.Blob).ToList());
                var bindingSource = new BindingSource(bindingList, null);
                TestDBGridView.DataSource = bindingSource;
            }
            else MessageBox.Show($"Error loading test file: {ItemDB.tempDBPath}");
        }

        private void ItemBrowserForm_Shown(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }
    }
}