using System;
using System.ComponentModel;
using System.Windows.Forms;

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
            if (ItemDB.Read())
            {
                var bindingList = new BindingList<Item>(ItemDB.items);
                var bindingSource = new BindingSource(bindingList, null);
                TestDBGridView.DataSource = bindingSource;
                TestDBGridView.Columns[0].Visible = false;
                TestDBGridView.AutoResizeColumns();

                MessageBox.Show($"Success! {ItemDB.ItemCount} items read");
            }
            else
                MessageBox.Show("Fu**");
        }
    }
}
