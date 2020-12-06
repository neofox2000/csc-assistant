using System.Collections.Generic;
using System.Windows.Forms;

namespace NioFox.Utils
{
    public enum FormTypes { LogViewer, EzAltStarter, ItemBrowser, ItemDetails }

    public class MdiChildFormManager
    {
        Form parent;
        Dictionary<FormTypes, Form> children = new Dictionary<FormTypes, Form>();

        public MdiChildFormManager(Form parent)
        {
            this.parent = parent;
        }
        public void Add<T>(FormTypes formType) where T : Form, new()
        {
            var newForm = new T();
            newForm.MdiParent = parent;
            children.Add(formType, newForm);
        }
        public void Show(FormTypes formType)
        {
            var form = children[formType];
            if (form.Visible) form.BringToFront(); else form.Show();
        }
    }
}
