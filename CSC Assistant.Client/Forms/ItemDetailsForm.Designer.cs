﻿
namespace CSC_Assistant.Client.Forms
{
    partial class ItemDetailsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GDStatValues = new System.Windows.Forms.Label();
            this.GDStatNames = new System.Windows.Forms.Label();
            this.ItemStatNamesLabel = new System.Windows.Forms.Label();
            this.ItemStatValuesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.GDStatValues, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.GDStatNames, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ItemStatNamesLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemStatValuesLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 50);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // GDStatValues
            // 
            this.GDStatValues.AutoSize = true;
            this.GDStatValues.Location = new System.Drawing.Point(159, 25);
            this.GDStatValues.Name = "GDStatValues";
            this.GDStatValues.Padding = new System.Windows.Forms.Padding(2);
            this.GDStatValues.Size = new System.Drawing.Size(58, 19);
            this.GDStatValues.TabIndex = 9;
            this.GDStatValues.Text = "GD Value";
            // 
            // GDStatNames
            // 
            this.GDStatNames.AutoSize = true;
            this.GDStatNames.Location = new System.Drawing.Point(8, 25);
            this.GDStatNames.Name = "GDStatNames";
            this.GDStatNames.Padding = new System.Windows.Forms.Padding(2);
            this.GDStatNames.Size = new System.Drawing.Size(50, 19);
            this.GDStatNames.TabIndex = 8;
            this.GDStatNames.Text = "GD Stat";
            // 
            // ItemStatNamesLabel
            // 
            this.ItemStatNamesLabel.AutoSize = true;
            this.ItemStatNamesLabel.Location = new System.Drawing.Point(8, 5);
            this.ItemStatNamesLabel.Name = "ItemStatNamesLabel";
            this.ItemStatNamesLabel.Padding = new System.Windows.Forms.Padding(2);
            this.ItemStatNamesLabel.Size = new System.Drawing.Size(43, 19);
            this.ItemStatNamesLabel.TabIndex = 5;
            this.ItemStatNamesLabel.Text = "Name";
            // 
            // ItemStatValuesLabel
            // 
            this.ItemStatValuesLabel.AutoSize = true;
            this.ItemStatValuesLabel.Location = new System.Drawing.Point(159, 5);
            this.ItemStatValuesLabel.Name = "ItemStatValuesLabel";
            this.ItemStatValuesLabel.Padding = new System.Windows.Forms.Padding(2);
            this.ItemStatValuesLabel.Size = new System.Drawing.Size(39, 19);
            this.ItemStatValuesLabel.TabIndex = 4;
            this.ItemStatValuesLabel.Text = "Value";
            // 
            // ItemDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(334, 50);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ItemDetailsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Item Details";
            this.Leave += new System.EventHandler(this.ItemDetailsForm_Leave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ItemStatValuesLabel;
        private System.Windows.Forms.Label ItemStatNamesLabel;
        private System.Windows.Forms.Label GDStatNames;
        private System.Windows.Forms.Label GDStatValues;
    }
}