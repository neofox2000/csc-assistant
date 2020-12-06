
namespace CSC_Assistant.Forms
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TestButton = new System.Windows.Forms.Button();
            this.TestDBGridView = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestDBGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.TestButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1138, 29);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(3, 3);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 3;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // TestDBGridView
            // 
            this.TestDBGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestDBGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestDBGridView.Location = new System.Drawing.Point(0, 29);
            this.TestDBGridView.Name = "TestDBGridView";
            this.TestDBGridView.RowTemplate.Height = 25;
            this.TestDBGridView.Size = new System.Drawing.Size(976, 565);
            this.TestDBGridView.TabIndex = 6;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.treeView1.Location = new System.Drawing.Point(976, 29);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(162, 565);
            this.treeView1.TabIndex = 7;
            this.treeView1.Visible = false;
            // 
            // ItemBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 594);
            this.Controls.Add(this.TestDBGridView);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ItemBrowserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ItemBrowser";
            this.Shown += new System.EventHandler(this.ItemBrowserForm_Shown);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestDBGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.DataGridView TestDBGridView;
        private System.Windows.Forms.TreeView treeView1;
    }
}