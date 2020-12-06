
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.TestDBGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TestDBGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.treeView1.Location = new System.Drawing.Point(976, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(162, 594);
            this.treeView1.TabIndex = 7;
            this.treeView1.Visible = false;
            // 
            // TestDBGridView
            // 
            this.TestDBGridView.AllowUserToAddRows = false;
            this.TestDBGridView.AllowUserToDeleteRows = false;
            this.TestDBGridView.AllowUserToOrderColumns = true;
            this.TestDBGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestDBGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestDBGridView.Location = new System.Drawing.Point(0, 0);
            this.TestDBGridView.Name = "TestDBGridView";
            this.TestDBGridView.ReadOnly = true;
            this.TestDBGridView.RowTemplate.Height = 25;
            this.TestDBGridView.Size = new System.Drawing.Size(976, 594);
            this.TestDBGridView.TabIndex = 9;
            // 
            // ItemBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 594);
            this.Controls.Add(this.TestDBGridView);
            this.Controls.Add(this.treeView1);
            this.Name = "ItemBrowserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ItemBrowser";
            this.Shown += new System.EventHandler(this.ItemBrowserForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TestDBGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView TestDBGridView;
    }
}