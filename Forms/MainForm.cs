using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSC_Assistant.Forms
{
    public partial class MainForm : Form
    {
        enum FormTypes { LogViewer, EzAltStarter, ItemBrowser }
        class ChildForms
        {
            Form parent;
            Dictionary<FormTypes, Form> children = new Dictionary<FormTypes, Form>();

            public ChildForms(Form parent)
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

        ChildForms childForms;


        public MainForm()
        {
            InitializeComponent();

            //Initialize child forms
            childForms = new ChildForms(this);
            childForms.Add<LogViewerForm>(FormTypes.LogViewer);
            childForms.Add<EzAltStarterForm>(FormTypes.EzAltStarter);
            childForms.Add<ItemBrowserForm>(FormTypes.ItemBrowser);

            WindowState = FormWindowState.Maximized;
        }

        private void CloseMi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemBrowserMi_Click(object sender, EventArgs e)
        {
            childForms.Show(FormTypes.ItemBrowser);
        }

        private void EzAltStarterMi_Click(object sender, EventArgs e)
        {
            childForms.Show(FormTypes.EzAltStarter);
        }

        private void LogViewerMi_Click(object sender, EventArgs e)
        {
            childForms.Show(FormTypes.LogViewer);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            LogViewerMi_Click(sender, e);
            ItemBrowserMi_Click(sender, e);
        }
    }
}