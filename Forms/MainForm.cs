using System.Windows.Forms;

namespace CSC_Assistant.Forms
{
    public partial class MainForm : Form
    {
        LogViewerForm logViewer;
        EzAltStarterForm ezAltStarter;
        ItemBrowserForm itemBrower;

        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            logViewer = new LogViewerForm();
            logViewer.MdiParent = this;
            logViewer.Show();

            ezAltStarter = new EzAltStarterForm();
            ezAltStarter.MdiParent = this;
            ezAltStarter.Show();

            itemBrower = new ItemBrowserForm();
            itemBrower.MdiParent = this;
            itemBrower.Show();
        }

        private void MainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
    }
}