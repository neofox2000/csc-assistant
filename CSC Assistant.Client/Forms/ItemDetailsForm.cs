using CSC_Assistant.Client.Data;
using CSC_Assistant.Common.DataStructures;
using System.Reflection;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using CSC_Assistant.Algo;

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
            DisplayAllProperties(item.Blob, out string n, out string v);
            ItemStatNamesLabel.Text = n;
            ItemStatValuesLabel.Text = v;

            //Show additional stats from GameData
            DisplayAllProperties(item.Blob.GameData, out n, out v);
            GDStatNames.Text = n;
            GDStatValues.Text = v;

            RefineListLabel.Text = item.Blob.GameData.RefinedResources == null ? NoneAvailable :
                ItemDB.GetResourcesDisplayList(item);

            PartsListLabel.Text = item.Blob.GameData.CraftingResources == null ? NoneAvailable :
                ItemDB.GetResourcesDisplayList(item);
        }

        private void ItemDetailsForm_Leave(object sender, System.EventArgs e)
        {
            Hide();
        }

        private void DisplayAllProperties<T>(T target, out string propNames, out string propValues)
        {
            //Show all the main details for the item
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(x => !System.Attribute.IsDefined(x, typeof(OmitFromViewing))).ToArray();

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