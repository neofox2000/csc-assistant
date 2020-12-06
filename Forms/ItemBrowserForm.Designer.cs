
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
            this.TestDBGridView = new System.Windows.Forms.DataGridView();
            this.TestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TestDBGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TestDBGridView
            // 
            this.TestDBGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestDBGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TestDBGridView.Location = new System.Drawing.Point(0, 41);
            this.TestDBGridView.Name = "TestDBGridView";
            this.TestDBGridView.RowTemplate.Height = 25;
            this.TestDBGridView.Size = new System.Drawing.Size(833, 409);
            this.TestDBGridView.TabIndex = 3;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(12, 12);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 2;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // ItemBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.TestDBGridView);
            this.Controls.Add(this.TestButton);
            this.Name = "ItemBrowser";
            this.Text = "ItemBrowser";
            ((System.ComponentModel.ISupportInitialize)(this.TestDBGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TestDBGridView;
        private System.Windows.Forms.Button TestButton;
    }
}