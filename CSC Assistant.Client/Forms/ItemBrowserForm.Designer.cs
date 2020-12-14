
namespace CSC_Assistant.Client.Forms
{
    partial class ItemBrowserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RefinesTreeView = new System.Windows.Forms.TreeView();
            this.ItemsGridView = new System.Windows.Forms.DataGridView();
            this.TreeViewsPanel = new System.Windows.Forms.Panel();
            this.CraftsGroupBox = new System.Windows.Forms.GroupBox();
            this.CraftsTreeView = new System.Windows.Forms.TreeView();
            this.RefinesGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemCellMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DataGridPanel = new System.Windows.Forms.Panel();
            this.ItemGridPanel = new System.Windows.Forms.Panel();
            this.ItemFilterPanel = new System.Windows.Forms.Panel();
            this.ItemNameFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemNameFilterTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            this.TreeViewsPanel.SuspendLayout();
            this.CraftsGroupBox.SuspendLayout();
            this.RefinesGroupBox.SuspendLayout();
            this.DataGridPanel.SuspendLayout();
            this.ItemGridPanel.SuspendLayout();
            this.ItemFilterPanel.SuspendLayout();
            this.ItemNameFilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefinesTreeView
            // 
            this.RefinesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefinesTreeView.Location = new System.Drawing.Point(3, 19);
            this.RefinesTreeView.Name = "RefinesTreeView";
            this.RefinesTreeView.Size = new System.Drawing.Size(276, 209);
            this.RefinesTreeView.TabIndex = 7;
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.AllowUserToAddRows = false;
            this.ItemsGridView.AllowUserToDeleteRows = false;
            this.ItemsGridView.AllowUserToOrderColumns = true;
            this.ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGridView.Location = new System.Drawing.Point(0, 0);
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.ReadOnly = true;
            this.ItemsGridView.RowTemplate.Height = 25;
            this.ItemsGridView.Size = new System.Drawing.Size(863, 464);
            this.ItemsGridView.TabIndex = 9;
            this.ItemsGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TestDBGridView_CellMouseDoubleClick);
            this.ItemsGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGridView_RowEnter);
            // 
            // TreeViewsPanel
            // 
            this.TreeViewsPanel.Controls.Add(this.CraftsGroupBox);
            this.TreeViewsPanel.Controls.Add(this.RefinesGroupBox);
            this.TreeViewsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TreeViewsPanel.Location = new System.Drawing.Point(863, 0);
            this.TreeViewsPanel.Name = "TreeViewsPanel";
            this.TreeViewsPanel.Size = new System.Drawing.Size(282, 513);
            this.TreeViewsPanel.TabIndex = 10;
            // 
            // CraftsGroupBox
            // 
            this.CraftsGroupBox.Controls.Add(this.CraftsTreeView);
            this.CraftsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CraftsGroupBox.Location = new System.Drawing.Point(0, 231);
            this.CraftsGroupBox.Name = "CraftsGroupBox";
            this.CraftsGroupBox.Size = new System.Drawing.Size(282, 282);
            this.CraftsGroupBox.TabIndex = 8;
            this.CraftsGroupBox.TabStop = false;
            this.CraftsGroupBox.Text = "Crafts";
            // 
            // CraftsTreeView
            // 
            this.CraftsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CraftsTreeView.Location = new System.Drawing.Point(3, 19);
            this.CraftsTreeView.Name = "CraftsTreeView";
            this.CraftsTreeView.Size = new System.Drawing.Size(276, 260);
            this.CraftsTreeView.TabIndex = 8;
            // 
            // RefinesGroupBox
            // 
            this.RefinesGroupBox.Controls.Add(this.RefinesTreeView);
            this.RefinesGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RefinesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RefinesGroupBox.Name = "RefinesGroupBox";
            this.RefinesGroupBox.Size = new System.Drawing.Size(282, 231);
            this.RefinesGroupBox.TabIndex = 2;
            this.RefinesGroupBox.TabStop = false;
            this.RefinesGroupBox.Text = "Refines";
            // 
            // ItemCellMenu
            // 
            this.ItemCellMenu.Name = "ItemCellMenu";
            this.ItemCellMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // DataGridPanel
            // 
            this.DataGridPanel.Controls.Add(this.ItemGridPanel);
            this.DataGridPanel.Controls.Add(this.ItemFilterPanel);
            this.DataGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridPanel.Location = new System.Drawing.Point(0, 0);
            this.DataGridPanel.Name = "DataGridPanel";
            this.DataGridPanel.Size = new System.Drawing.Size(863, 513);
            this.DataGridPanel.TabIndex = 11;
            // 
            // ItemGridPanel
            // 
            this.ItemGridPanel.Controls.Add(this.ItemsGridView);
            this.ItemGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemGridPanel.Location = new System.Drawing.Point(0, 49);
            this.ItemGridPanel.Name = "ItemGridPanel";
            this.ItemGridPanel.Size = new System.Drawing.Size(863, 464);
            this.ItemGridPanel.TabIndex = 11;
            // 
            // ItemFilterPanel
            // 
            this.ItemFilterPanel.Controls.Add(this.ItemNameFilterGroupBox);
            this.ItemFilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemFilterPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemFilterPanel.Name = "ItemFilterPanel";
            this.ItemFilterPanel.Size = new System.Drawing.Size(863, 49);
            this.ItemFilterPanel.TabIndex = 10;
            // 
            // ItemNameFilterGroupBox
            // 
            this.ItemNameFilterGroupBox.Controls.Add(this.ItemNameFilterTextBox);
            this.ItemNameFilterGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemNameFilterGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ItemNameFilterGroupBox.Name = "ItemNameFilterGroupBox";
            this.ItemNameFilterGroupBox.Size = new System.Drawing.Size(200, 49);
            this.ItemNameFilterGroupBox.TabIndex = 0;
            this.ItemNameFilterGroupBox.TabStop = false;
            this.ItemNameFilterGroupBox.Text = "Item Name Filter";
            // 
            // ItemNameFilterTextBox
            // 
            this.ItemNameFilterTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemNameFilterTextBox.Location = new System.Drawing.Point(3, 19);
            this.ItemNameFilterTextBox.Name = "ItemNameFilterTextBox";
            this.ItemNameFilterTextBox.Size = new System.Drawing.Size(194, 23);
            this.ItemNameFilterTextBox.TabIndex = 0;
            // 
            // ItemBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 513);
            this.Controls.Add(this.DataGridPanel);
            this.Controls.Add(this.TreeViewsPanel);
            this.Name = "ItemBrowserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Item Browser";
            this.Shown += new System.EventHandler(this.ItemBrowserForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            this.TreeViewsPanel.ResumeLayout(false);
            this.CraftsGroupBox.ResumeLayout(false);
            this.RefinesGroupBox.ResumeLayout(false);
            this.DataGridPanel.ResumeLayout(false);
            this.ItemGridPanel.ResumeLayout(false);
            this.ItemFilterPanel.ResumeLayout(false);
            this.ItemNameFilterGroupBox.ResumeLayout(false);
            this.ItemNameFilterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView RefinesTreeView;
        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.Panel TreeViewsPanel;
        private System.Windows.Forms.ContextMenuStrip ItemCellMenu;
        private System.Windows.Forms.GroupBox CraftsGroupBox;
        private System.Windows.Forms.GroupBox RefinesGroupBox;
        private System.Windows.Forms.TreeView CraftsTreeView;
        private System.Windows.Forms.Panel DataGridPanel;
        private System.Windows.Forms.Panel ItemFilterPanel;
        private System.Windows.Forms.GroupBox ItemNameFilterGroupBox;
        private System.Windows.Forms.TextBox ItemNameFilterTextBox;
        private System.Windows.Forms.Panel ItemGridPanel;
    }
}