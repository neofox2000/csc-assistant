
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
            this.PartsTreeView = new System.Windows.Forms.TreeView();
            this.ItemsGridView = new System.Windows.Forms.DataGridView();
            this.TreeViewsPanel = new System.Windows.Forms.Panel();
            this.CraftTreeSplitter = new System.Windows.Forms.Splitter();
            this.MakesGroupBox = new System.Windows.Forms.GroupBox();
            this.MakesTreeView = new System.Windows.Forms.TreeView();
            this.PartsGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemCellMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DataGridPanel = new System.Windows.Forms.Panel();
            this.ItemGridPanel = new System.Windows.Forms.Panel();
            this.ItemFilterPanel = new System.Windows.Forms.Panel();
            this.UseShopStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.UseShopStatsCheckBox = new System.Windows.Forms.CheckBox();
            this.BaseYieldGroupBox = new System.Windows.Forms.GroupBox();
            this.BaseYeildNUD = new System.Windows.Forms.NumericUpDown();
            this.InputModifierGroupBox = new System.Windows.Forms.GroupBox();
            this.InputModifierNUD = new System.Windows.Forms.NumericUpDown();
            this.YieldModifierGroupBox = new System.Windows.Forms.GroupBox();
            this.YieldModifierNUD = new System.Windows.Forms.NumericUpDown();
            this.QuantityGroupBox = new System.Windows.Forms.GroupBox();
            this.QuantityNUD = new System.Windows.Forms.NumericUpDown();
            this.ItemNameFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemNameFilterTextBox = new System.Windows.Forms.TextBox();
            this.MainSplitter = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            this.TreeViewsPanel.SuspendLayout();
            this.MakesGroupBox.SuspendLayout();
            this.PartsGroupBox.SuspendLayout();
            this.DataGridPanel.SuspendLayout();
            this.ItemGridPanel.SuspendLayout();
            this.ItemFilterPanel.SuspendLayout();
            this.UseShopStatsGroupBox.SuspendLayout();
            this.BaseYieldGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseYeildNUD)).BeginInit();
            this.InputModifierGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputModifierNUD)).BeginInit();
            this.YieldModifierGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YieldModifierNUD)).BeginInit();
            this.QuantityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNUD)).BeginInit();
            this.ItemNameFilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PartsTreeView
            // 
            this.PartsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartsTreeView.Location = new System.Drawing.Point(3, 19);
            this.PartsTreeView.Name = "PartsTreeView";
            this.PartsTreeView.Size = new System.Drawing.Size(276, 209);
            this.PartsTreeView.TabIndex = 7;
            this.PartsTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PartsTreeView_MouseDoubleClick);
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
            this.TreeViewsPanel.Controls.Add(this.CraftTreeSplitter);
            this.TreeViewsPanel.Controls.Add(this.MakesGroupBox);
            this.TreeViewsPanel.Controls.Add(this.PartsGroupBox);
            this.TreeViewsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TreeViewsPanel.Location = new System.Drawing.Point(863, 0);
            this.TreeViewsPanel.Name = "TreeViewsPanel";
            this.TreeViewsPanel.Size = new System.Drawing.Size(282, 513);
            this.TreeViewsPanel.TabIndex = 10;
            // 
            // CraftTreeSplitter
            // 
            this.CraftTreeSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.CraftTreeSplitter.Location = new System.Drawing.Point(0, 231);
            this.CraftTreeSplitter.Name = "CraftTreeSplitter";
            this.CraftTreeSplitter.Size = new System.Drawing.Size(282, 5);
            this.CraftTreeSplitter.TabIndex = 9;
            this.CraftTreeSplitter.TabStop = false;
            // 
            // MakesGroupBox
            // 
            this.MakesGroupBox.Controls.Add(this.MakesTreeView);
            this.MakesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MakesGroupBox.Location = new System.Drawing.Point(0, 231);
            this.MakesGroupBox.Name = "MakesGroupBox";
            this.MakesGroupBox.Size = new System.Drawing.Size(282, 282);
            this.MakesGroupBox.TabIndex = 8;
            this.MakesGroupBox.TabStop = false;
            this.MakesGroupBox.Text = "Makes";
            // 
            // MakesTreeView
            // 
            this.MakesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MakesTreeView.Location = new System.Drawing.Point(3, 19);
            this.MakesTreeView.Name = "MakesTreeView";
            this.MakesTreeView.Size = new System.Drawing.Size(276, 260);
            this.MakesTreeView.TabIndex = 8;
            // 
            // PartsGroupBox
            // 
            this.PartsGroupBox.Controls.Add(this.PartsTreeView);
            this.PartsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PartsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.PartsGroupBox.Name = "PartsGroupBox";
            this.PartsGroupBox.Size = new System.Drawing.Size(282, 231);
            this.PartsGroupBox.TabIndex = 2;
            this.PartsGroupBox.TabStop = false;
            this.PartsGroupBox.Text = "Parts";
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
            this.ItemFilterPanel.Controls.Add(this.UseShopStatsGroupBox);
            this.ItemFilterPanel.Controls.Add(this.BaseYieldGroupBox);
            this.ItemFilterPanel.Controls.Add(this.InputModifierGroupBox);
            this.ItemFilterPanel.Controls.Add(this.YieldModifierGroupBox);
            this.ItemFilterPanel.Controls.Add(this.QuantityGroupBox);
            this.ItemFilterPanel.Controls.Add(this.ItemNameFilterGroupBox);
            this.ItemFilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemFilterPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemFilterPanel.Name = "ItemFilterPanel";
            this.ItemFilterPanel.Size = new System.Drawing.Size(863, 49);
            this.ItemFilterPanel.TabIndex = 10;
            // 
            // UseShopStatsGroupBox
            // 
            this.UseShopStatsGroupBox.Controls.Add(this.UseShopStatsCheckBox);
            this.UseShopStatsGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.UseShopStatsGroupBox.Location = new System.Drawing.Point(535, 0);
            this.UseShopStatsGroupBox.Name = "UseShopStatsGroupBox";
            this.UseShopStatsGroupBox.Size = new System.Drawing.Size(27, 49);
            this.UseShopStatsGroupBox.TabIndex = 6;
            this.UseShopStatsGroupBox.TabStop = false;
            this.UseShopStatsGroupBox.Text = ">";
            // 
            // UseShopStatsCheckBox
            // 
            this.UseShopStatsCheckBox.AutoSize = true;
            this.UseShopStatsCheckBox.Checked = true;
            this.UseShopStatsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseShopStatsCheckBox.Location = new System.Drawing.Point(6, 23);
            this.UseShopStatsCheckBox.Name = "UseShopStatsCheckBox";
            this.UseShopStatsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.UseShopStatsCheckBox.TabIndex = 0;
            this.UseShopStatsCheckBox.UseVisualStyleBackColor = true;
            this.UseShopStatsCheckBox.CheckedChanged += new System.EventHandler(this.UseShopStatsCheckBox_CheckedChanged);
            // 
            // BaseYieldGroupBox
            // 
            this.BaseYieldGroupBox.Controls.Add(this.BaseYeildNUD);
            this.BaseYieldGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.BaseYieldGroupBox.Location = new System.Drawing.Point(562, 0);
            this.BaseYieldGroupBox.Name = "BaseYieldGroupBox";
            this.BaseYieldGroupBox.Size = new System.Drawing.Size(74, 49);
            this.BaseYieldGroupBox.TabIndex = 5;
            this.BaseYieldGroupBox.TabStop = false;
            this.BaseYieldGroupBox.Text = "Base Yield";
            // 
            // BaseYeildNUD
            // 
            this.BaseYeildNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseYeildNUD.DecimalPlaces = 2;
            this.BaseYeildNUD.Location = new System.Drawing.Point(6, 19);
            this.BaseYeildNUD.Name = "BaseYeildNUD";
            this.BaseYeildNUD.Size = new System.Drawing.Size(62, 23);
            this.BaseYeildNUD.TabIndex = 2;
            this.BaseYeildNUD.Value = new decimal(new int[] {
            9897,
            0,
            0,
            131072});
            // 
            // InputModifierGroupBox
            // 
            this.InputModifierGroupBox.Controls.Add(this.InputModifierNUD);
            this.InputModifierGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.InputModifierGroupBox.Location = new System.Drawing.Point(636, 0);
            this.InputModifierGroupBox.Name = "InputModifierGroupBox";
            this.InputModifierGroupBox.Size = new System.Drawing.Size(77, 49);
            this.InputModifierGroupBox.TabIndex = 3;
            this.InputModifierGroupBox.TabStop = false;
            this.InputModifierGroupBox.Text = "Input Aug";
            // 
            // InputModifierNUD
            // 
            this.InputModifierNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputModifierNUD.DecimalPlaces = 2;
            this.InputModifierNUD.Location = new System.Drawing.Point(9, 19);
            this.InputModifierNUD.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.InputModifierNUD.Name = "InputModifierNUD";
            this.InputModifierNUD.Size = new System.Drawing.Size(62, 23);
            this.InputModifierNUD.TabIndex = 1;
            this.InputModifierNUD.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // YieldModifierGroupBox
            // 
            this.YieldModifierGroupBox.Controls.Add(this.YieldModifierNUD);
            this.YieldModifierGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.YieldModifierGroupBox.Location = new System.Drawing.Point(713, 0);
            this.YieldModifierGroupBox.Name = "YieldModifierGroupBox";
            this.YieldModifierGroupBox.Size = new System.Drawing.Size(74, 49);
            this.YieldModifierGroupBox.TabIndex = 4;
            this.YieldModifierGroupBox.TabStop = false;
            this.YieldModifierGroupBox.Text = "Yield Aug";
            // 
            // YieldModifierNUD
            // 
            this.YieldModifierNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YieldModifierNUD.DecimalPlaces = 2;
            this.YieldModifierNUD.Location = new System.Drawing.Point(6, 19);
            this.YieldModifierNUD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.YieldModifierNUD.Name = "YieldModifierNUD";
            this.YieldModifierNUD.Size = new System.Drawing.Size(62, 23);
            this.YieldModifierNUD.TabIndex = 2;
            this.YieldModifierNUD.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // QuantityGroupBox
            // 
            this.QuantityGroupBox.Controls.Add(this.QuantityNUD);
            this.QuantityGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.QuantityGroupBox.Location = new System.Drawing.Point(787, 0);
            this.QuantityGroupBox.Name = "QuantityGroupBox";
            this.QuantityGroupBox.Size = new System.Drawing.Size(76, 49);
            this.QuantityGroupBox.TabIndex = 1;
            this.QuantityGroupBox.TabStop = false;
            this.QuantityGroupBox.Text = "Quantity";
            // 
            // QuantityNUD
            // 
            this.QuantityNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantityNUD.Location = new System.Drawing.Point(7, 19);
            this.QuantityNUD.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.QuantityNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityNUD.Name = "QuantityNUD";
            this.QuantityNUD.Size = new System.Drawing.Size(62, 23);
            this.QuantityNUD.TabIndex = 0;
            this.QuantityNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityNUD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.QuantityNUD_KeyUp);
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
            this.ItemNameFilterTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ItemNameFilterTextBox_KeyUp);
            // 
            // MainSplitter
            // 
            this.MainSplitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainSplitter.Location = new System.Drawing.Point(858, 0);
            this.MainSplitter.Name = "MainSplitter";
            this.MainSplitter.Size = new System.Drawing.Size(5, 513);
            this.MainSplitter.TabIndex = 12;
            this.MainSplitter.TabStop = false;
            // 
            // ItemBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 513);
            this.Controls.Add(this.MainSplitter);
            this.Controls.Add(this.DataGridPanel);
            this.Controls.Add(this.TreeViewsPanel);
            this.Name = "ItemBrowserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Item Browser";
            this.Shown += new System.EventHandler(this.ItemBrowserForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            this.TreeViewsPanel.ResumeLayout(false);
            this.MakesGroupBox.ResumeLayout(false);
            this.PartsGroupBox.ResumeLayout(false);
            this.DataGridPanel.ResumeLayout(false);
            this.ItemGridPanel.ResumeLayout(false);
            this.ItemFilterPanel.ResumeLayout(false);
            this.UseShopStatsGroupBox.ResumeLayout(false);
            this.UseShopStatsGroupBox.PerformLayout();
            this.BaseYieldGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseYeildNUD)).EndInit();
            this.InputModifierGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InputModifierNUD)).EndInit();
            this.YieldModifierGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YieldModifierNUD)).EndInit();
            this.QuantityGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNUD)).EndInit();
            this.ItemNameFilterGroupBox.ResumeLayout(false);
            this.ItemNameFilterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView PartsTreeView;
        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.Panel TreeViewsPanel;
        private System.Windows.Forms.ContextMenuStrip ItemCellMenu;
        private System.Windows.Forms.GroupBox MakesGroupBox;
        private System.Windows.Forms.GroupBox PartsGroupBox;
        private System.Windows.Forms.TreeView MakesTreeView;
        private System.Windows.Forms.Panel DataGridPanel;
        private System.Windows.Forms.Panel ItemFilterPanel;
        private System.Windows.Forms.GroupBox ItemNameFilterGroupBox;
        private System.Windows.Forms.TextBox ItemNameFilterTextBox;
        private System.Windows.Forms.Panel ItemGridPanel;
        private System.Windows.Forms.GroupBox QuantityGroupBox;
        private System.Windows.Forms.NumericUpDown QuantityNUD;
        private System.Windows.Forms.Splitter MainSplitter;
        private System.Windows.Forms.Splitter CraftTreeSplitter;
        private System.Windows.Forms.GroupBox BaseYieldGroupBox;
        private System.Windows.Forms.NumericUpDown BaseYeildNUD;
        private System.Windows.Forms.GroupBox YieldModifierGroupBox;
        private System.Windows.Forms.NumericUpDown YieldModifierNUD;
        private System.Windows.Forms.GroupBox InputModifierGroupBox;
        private System.Windows.Forms.NumericUpDown InputModifierNUD;
        private System.Windows.Forms.GroupBox UseShopStatsGroupBox;
        private System.Windows.Forms.CheckBox UseShopStatsCheckBox;
    }
}