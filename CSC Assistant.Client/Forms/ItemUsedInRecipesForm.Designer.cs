
namespace CSC_Assistant.Client.Forms
{
    partial class ItemUsedInRecipesForm
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
            this.ItemTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // ItemTreeView
            // 
            this.ItemTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemTreeView.Location = new System.Drawing.Point(0, 0);
            this.ItemTreeView.Name = "ItemTreeView";
            this.ItemTreeView.Size = new System.Drawing.Size(950, 593);
            this.ItemTreeView.TabIndex = 0;
            // 
            // ItemUsedInRecipesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 593);
            this.Controls.Add(this.ItemTreeView);
            this.Name = "ItemUsedInRecipesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Item used in the following recipes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ItemTreeView;
    }
}