using CSC_Assistant.Client.DataStructures;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
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
            if (item == null)
            {
                MessageBox.Show("Bad Item");
                return;
            }

            Location = MousePosition;

            Show();            

            Text = $"Item Details - {item.Name}";

            //Show all the main details for the item
            string n, v;
            DisplayAllProperties(item.Blob, typeof(BlobForDisplay), out n, out v);
            ItemStatNamesLabel.Text = n;
            ItemStatValuesLabel.Text = v;

            //Show additional stats from GameData
            DisplayAllProperties(item.Blob.GameData, typeof(GameDataForDisplay), out n, out v);
            GDStatNames.Text = n;
            GDStatValues.Text = v;

            DisplayRefinedResources(item.Blob.GameData.RefinedResources);
        }

        private void ItemDetailsForm_Leave(object sender, System.EventArgs e)
        {
            Hide();
        }

        private void DisplayRefinedResources(List<RefinedResource> rRes)
        {
            //Bail if nothing else to do
            if (rRes == null || rRes.Count == 0)
            {
                PartsListLabel.Text = "N/A";
                return;
            }

            StringBuilder resDisplay = new StringBuilder(rRes.Count);

            foreach (RefinedResource rr in rRes)
            {
                //Fetch item
                Item item = ItemDB.LookupId(rr.ItemID);

                //Handle bad id
                if (item == null)
                {
                    resDisplay.Append("<bad id>\n");
                    continue;
                }

                //Display relevant item details
                resDisplay.Append($"{rr.OptimalQty}x {item.Name}\n");
            }

            PartsListLabel.Text = resDisplay.ToString();
        }

        private void DisplayAllProperties<T>(T target, System.Type targetType, out string propNames, out string propValues)
        {
            //Show all the main details for the item
            PropertyInfo[] Props = targetType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            
            var propCount = Props.Length;
            StringBuilder sbNames = new StringBuilder(propCount);
            StringBuilder sbValues = new StringBuilder(propCount);

            foreach (PropertyInfo prop in Props)
            {
                var val = prop.GetValue(target);

                //Skip empty values (they probably don't apply to this item)
                if ((val == null) || (val.ToString() == string.Empty)) continue;

                sbNames.Append($"{prop.Name}:\n");
                sbValues.Append($"{val}\n");
            }

            propNames = sbNames.ToString();
            propValues = sbValues.ToString();
        }
    }
}