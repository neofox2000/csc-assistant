using System.Windows.Forms;

namespace CSC_Assistant.Client.Forms
{
    public partial class ItemDetailsForm : Form
    {
        public ItemDetailsForm()
        {
            InitializeComponent();

            Program.OnShowItemDetails += OpenItemDetails;
        }

        private void OpenItemDetails(Item item)
        {
            if (Visible) BringToFront(); else Show();

            Text = $"Item Details - {item.Name}";
            

        }
    }
}