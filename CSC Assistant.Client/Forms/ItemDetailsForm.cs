using CSC_Assistant.Common.DataStructures;
using System.Windows.Forms;
using CSC_Assistant.Client.Utils;
using System.Text;
using System.Collections.Generic;

namespace CSC_Assistant.Client.Forms
{
    public partial class ItemDetailsForm : Form
    {
        //Re-used often
        readonly StringBuilder sb1 = new();
        readonly StringBuilder sb2 = new();

        public ItemDetailsForm()
        {
            InitializeComponent();

            Program.OnShowItemDetails += OpenItemDetails;
        }

        private void OpenItemDetails(Item item)
        {
            //Ignore bad items completely
            if (item == null) { return; }

            Location = MousePosition;

            Show();            

            Text = $"Item Details - {item.Name}";

            //Show all the main details for the item
            PropsToLabels(
                ReflectionUtils.DisplayAllProperties(item.Blob, typeof(OmitFromViewing)),
                ItemStatNamesLabel,
                ItemStatValuesLabel);

            //Show additional stats from GameData
            PropsToLabels(
                ReflectionUtils.DisplayAllProperties(item.Blob.GameData, typeof(OmitFromViewing)),
                GDStatNames,
                GDStatValues);
        }

        private void ItemDetailsForm_Leave(object sender, System.EventArgs e)
        {
            Hide();
        }
    
        private void PropsToLabels(Dictionary<string, string> props, Label names, Label values)
        {
            sb1.Clear();
            sb2.Clear();

            foreach(var prop in props)
            {
                sb1.Append($"{prop.Key}\n");
                sb2.Append($"{prop.Value}\n");
            }

            names.Text = sb1.ToString();
            values.Text = sb2.ToString();
        }
    }
}