using CSC_Assistant.Client.Data;
using CSC_Assistant.Common.DataStructures;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CSC_Assistant.Client.Forms
{
    public partial class ItemDetailsForm : Form
    {
        const string NoneAvailable = "N/A";

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
            DisplayAllProperties(item.Blob, typeof(BlobForDisplay), out string n, out string v);
            ItemStatNamesLabel.Text = n;
            ItemStatValuesLabel.Text = v;

            //Show additional stats from GameData
            DisplayAllProperties(item.Blob.GameData, typeof(GameDataForDisplay), out n, out v);
            GDStatNames.Text = n;
            GDStatValues.Text = v;

            RefineListLabel.Text = item.Blob.GameData.RefinedResources == null ? NoneAvailable :
                ItemDB.GetResourcesDisplayList(item.Blob.GameData.RefinedResources.ToArray());

            PartsListLabel.Text = item.Blob.GameData.CraftingResources == null ? NoneAvailable :
                ItemDB.GetResourcesDisplayList(item.Blob.GameData.CraftingResources.ToArray());
        }

        private void ItemDetailsForm_Leave(object sender, System.EventArgs e)
        {
            Hide();
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