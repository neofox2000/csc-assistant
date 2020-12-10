using System;
using System.Windows.Forms;
using NioFox.Utils;

namespace CSC_Assistant.Client.Forms
{
    public partial class MainForm : Form
    {
        MdiChildFormManager childFormManager;

        public MainForm()
        {
            InitializeComponent();

            //Initialize child forms
            childFormManager = new MdiChildFormManager(this);
            childFormManager.Add<LogViewerForm>(FormTypes.LogViewer);
            childFormManager.Add<EzAltStarterForm>(FormTypes.EzAltStarter);
            childFormManager.Add<ItemBrowserForm>(FormTypes.ItemBrowser);
            childFormManager.Add<ItemDetailsForm>(FormTypes.ItemDetails);
            childFormManager.Add<ItemUsedInRecipesForm>(FormTypes.ItemUsedIn);

            WindowState = FormWindowState.Maximized;
        }

        private void CloseMi_Click(object sender, EventArgs e)
        {
            childFormManager.HideAll();
            Application.Exit();
        }

        private void ItemBrowserMi_Click(object sender, EventArgs e)
        {
            childFormManager.Show(FormTypes.ItemBrowser);
        }

        private void EzAltStarterMi_Click(object sender, EventArgs e)
        {
            childFormManager.Show(FormTypes.EzAltStarter);
        }

        private void LogViewerMi_Click(object sender, EventArgs e)
        {
            childFormManager.Show(FormTypes.LogViewer);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            LogViewerMi_Click(sender, e);
            ItemBrowserMi_Click(sender, e);
        }
    }
}