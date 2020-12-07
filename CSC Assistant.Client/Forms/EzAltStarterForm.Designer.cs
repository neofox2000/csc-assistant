
namespace CSC_Assistant.Client.Forms
{
    partial class EzAltStarterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EzAltStarterForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LocateExeButton = new System.Windows.Forms.Button();
            this.MakeFilesButton = new System.Windows.Forms.Button();
            this.OutputFolderButton = new System.Windows.Forms.Button();
            this.OutputFolderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OpenFileD = new System.Windows.Forms.OpenFileDialog();
            this.FolderBrowserD = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(870, 305);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExeTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LocateExeButton);
            this.panel1.Controls.Add(this.MakeFilesButton);
            this.panel1.Controls.Add(this.OutputFolderButton);
            this.panel1.Controls.Add(this.OutputFolderTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 139);
            this.panel1.TabIndex = 2;
            // 
            // ExeTextBox
            // 
            this.ExeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExeTextBox.Location = new System.Drawing.Point(101, 29);
            this.ExeTextBox.Name = "ExeTextBox";
            this.ExeTextBox.Size = new System.Drawing.Size(723, 23);
            this.ExeTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "CSC exe file";
            // 
            // LocateExeButton
            // 
            this.LocateExeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LocateExeButton.Location = new System.Drawing.Point(830, 29);
            this.LocateExeButton.Name = "LocateExeButton";
            this.LocateExeButton.Size = new System.Drawing.Size(25, 23);
            this.LocateExeButton.TabIndex = 9;
            this.LocateExeButton.Text = "...";
            this.LocateExeButton.UseVisualStyleBackColor = true;
            this.LocateExeButton.Click += new System.EventHandler(this.LocateExeButton_Click);
            // 
            // MakeFilesButton
            // 
            this.MakeFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeFilesButton.Location = new System.Drawing.Point(743, 87);
            this.MakeFilesButton.Name = "MakeFilesButton";
            this.MakeFilesButton.Size = new System.Drawing.Size(113, 23);
            this.MakeFilesButton.TabIndex = 10;
            this.MakeFilesButton.Text = "Make EZ Files";
            this.MakeFilesButton.UseVisualStyleBackColor = true;
            this.MakeFilesButton.Click += new System.EventHandler(this.MakeFilesButton_Click);
            // 
            // OutputFolderButton
            // 
            this.OutputFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputFolderButton.Location = new System.Drawing.Point(830, 58);
            this.OutputFolderButton.Name = "OutputFolderButton";
            this.OutputFolderButton.Size = new System.Drawing.Size(25, 23);
            this.OutputFolderButton.TabIndex = 11;
            this.OutputFolderButton.Text = "...";
            this.OutputFolderButton.UseVisualStyleBackColor = true;
            this.OutputFolderButton.Click += new System.EventHandler(this.OutputFolderButton_Click);
            // 
            // OutputFolderTextBox
            // 
            this.OutputFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputFolderTextBox.Location = new System.Drawing.Point(101, 58);
            this.OutputFolderTextBox.Name = "OutputFolderTextBox";
            this.OutputFolderTextBox.Size = new System.Drawing.Size(723, 23);
            this.OutputFolderTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output Folder";
            // 
            // EzAltStarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "EzAltStarterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EZ Alt Starter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ExeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LocateExeButton;
        private System.Windows.Forms.Button MakeFilesButton;
        private System.Windows.Forms.Button OutputFolderButton;
        private System.Windows.Forms.TextBox OutputFolderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog OpenFileD;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserD;
    }
}