namespace CSC_Assistant
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.LogViewerTab = new System.Windows.Forms.TabPage();
            this.LogTabControl = new System.Windows.Forms.TabControl();
            this.CombatLogTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ApplyCombatFiltersButton = new System.Windows.Forms.Button();
            this.CombatOmissionList = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CombatCollapsedCB = new System.Windows.Forms.CheckBox();
            this.CombatLogTB = new System.Windows.Forms.RichTextBox();
            this.MiningLogTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MiningRefreshViewButton = new System.Windows.Forms.Button();
            this.MiningOmissionList = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MiningCollapsedCB = new System.Windows.Forms.CheckBox();
            this.MiningLogTB = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ExeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LocateExeButton = new System.Windows.Forms.Button();
            this.MakeFilesButton = new System.Windows.Forms.Button();
            this.OutputFolderButton = new System.Windows.Forms.Button();
            this.OutputFolderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LogPollTimer = new System.Windows.Forms.Timer(this.components);
            this.FolderBrowserD = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileD = new System.Windows.Forms.OpenFileDialog();
            this.MainTabControl.SuspendLayout();
            this.LogViewerTab.SuspendLayout();
            this.LogTabControl.SuspendLayout();
            this.CombatLogTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MiningLogTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.LogViewerTab);
            this.MainTabControl.Controls.Add(this.tabPage2);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(856, 426);
            this.MainTabControl.TabIndex = 0;
            // 
            // LogViewerTab
            // 
            this.LogViewerTab.Controls.Add(this.LogTabControl);
            this.LogViewerTab.Location = new System.Drawing.Point(4, 24);
            this.LogViewerTab.Name = "LogViewerTab";
            this.LogViewerTab.Padding = new System.Windows.Forms.Padding(3);
            this.LogViewerTab.Size = new System.Drawing.Size(848, 398);
            this.LogViewerTab.TabIndex = 0;
            this.LogViewerTab.Text = "Log Viewer";
            this.LogViewerTab.UseVisualStyleBackColor = true;
            // 
            // LogTabControl
            // 
            this.LogTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTabControl.Controls.Add(this.CombatLogTab);
            this.LogTabControl.Controls.Add(this.MiningLogTab);
            this.LogTabControl.Location = new System.Drawing.Point(3, 3);
            this.LogTabControl.Name = "LogTabControl";
            this.LogTabControl.SelectedIndex = 0;
            this.LogTabControl.Size = new System.Drawing.Size(842, 392);
            this.LogTabControl.TabIndex = 1;
            // 
            // CombatLogTab
            // 
            this.CombatLogTab.Controls.Add(this.panel2);
            this.CombatLogTab.Controls.Add(this.CombatLogTB);
            this.CombatLogTab.Location = new System.Drawing.Point(4, 24);
            this.CombatLogTab.Name = "CombatLogTab";
            this.CombatLogTab.Padding = new System.Windows.Forms.Padding(3);
            this.CombatLogTab.Size = new System.Drawing.Size(834, 364);
            this.CombatLogTab.TabIndex = 0;
            this.CombatLogTab.Text = "Combat";
            this.CombatLogTab.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.ApplyCombatFiltersButton);
            this.panel2.Controls.Add(this.CombatOmissionList);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CombatCollapsedCB);
            this.panel2.Location = new System.Drawing.Point(709, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 358);
            this.panel2.TabIndex = 1;
            // 
            // ApplyCombatFiltersButton
            // 
            this.ApplyCombatFiltersButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyCombatFiltersButton.Location = new System.Drawing.Point(0, 325);
            this.ApplyCombatFiltersButton.Name = "ApplyCombatFiltersButton";
            this.ApplyCombatFiltersButton.Size = new System.Drawing.Size(122, 33);
            this.ApplyCombatFiltersButton.TabIndex = 0;
            this.ApplyCombatFiltersButton.Text = "Apply";
            this.ApplyCombatFiltersButton.UseVisualStyleBackColor = true;
            this.ApplyCombatFiltersButton.Click += new System.EventHandler(this.ApplyCombatFiltersButton_Click);
            // 
            // CombatOmissionList
            // 
            this.CombatOmissionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CombatOmissionList.Cursor = System.Windows.Forms.Cursors.Default;
            this.CombatOmissionList.Location = new System.Drawing.Point(0, 58);
            this.CombatOmissionList.Name = "CombatOmissionList";
            this.CombatOmissionList.Size = new System.Drawing.Size(122, 261);
            this.CombatOmissionList.TabIndex = 5;
            this.CombatOmissionList.Text = "Session\nValue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Omissions";
            // 
            // CombatCollapsedCB
            // 
            this.CombatCollapsedCB.AutoSize = true;
            this.CombatCollapsedCB.Checked = true;
            this.CombatCollapsedCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CombatCollapsedCB.Location = new System.Drawing.Point(0, 2);
            this.CombatCollapsedCB.Name = "CombatCollapsedCB";
            this.CombatCollapsedCB.Size = new System.Drawing.Size(78, 19);
            this.CombatCollapsedCB.TabIndex = 2;
            this.CombatCollapsedCB.Text = "Collapsed";
            this.CombatCollapsedCB.UseVisualStyleBackColor = true;
            // 
            // CombatLogTB
            // 
            this.CombatLogTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CombatLogTB.Location = new System.Drawing.Point(0, 3);
            this.CombatLogTB.Name = "CombatLogTB";
            this.CombatLogTB.Size = new System.Drawing.Size(703, 358);
            this.CombatLogTB.TabIndex = 0;
            this.CombatLogTB.Text = "";
            this.CombatLogTB.WordWrap = false;
            // 
            // MiningLogTab
            // 
            this.MiningLogTab.Controls.Add(this.panel3);
            this.MiningLogTab.Controls.Add(this.MiningLogTB);
            this.MiningLogTab.Location = new System.Drawing.Point(4, 24);
            this.MiningLogTab.Name = "MiningLogTab";
            this.MiningLogTab.Padding = new System.Windows.Forms.Padding(3);
            this.MiningLogTab.Size = new System.Drawing.Size(834, 364);
            this.MiningLogTab.TabIndex = 1;
            this.MiningLogTab.Text = "Mining";
            this.MiningLogTab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.MiningRefreshViewButton);
            this.panel3.Controls.Add(this.MiningOmissionList);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.MiningCollapsedCB);
            this.panel3.Location = new System.Drawing.Point(709, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 358);
            this.panel3.TabIndex = 1;
            // 
            // MiningRefreshViewButton
            // 
            this.MiningRefreshViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MiningRefreshViewButton.Location = new System.Drawing.Point(0, 325);
            this.MiningRefreshViewButton.Name = "MiningRefreshViewButton";
            this.MiningRefreshViewButton.Size = new System.Drawing.Size(122, 33);
            this.MiningRefreshViewButton.TabIndex = 0;
            this.MiningRefreshViewButton.Text = "Apply";
            this.MiningRefreshViewButton.UseVisualStyleBackColor = true;
            this.MiningRefreshViewButton.Click += new System.EventHandler(this.ApplyMiningFiltersButton_Click);
            // 
            // MiningOmissionList
            // 
            this.MiningOmissionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MiningOmissionList.Location = new System.Drawing.Point(0, 58);
            this.MiningOmissionList.Name = "MiningOmissionList";
            this.MiningOmissionList.Size = new System.Drawing.Size(122, 261);
            this.MiningOmissionList.TabIndex = 5;
            this.MiningOmissionList.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Omissions";
            // 
            // MiningCollapsedCB
            // 
            this.MiningCollapsedCB.AutoSize = true;
            this.MiningCollapsedCB.Location = new System.Drawing.Point(0, 2);
            this.MiningCollapsedCB.Name = "MiningCollapsedCB";
            this.MiningCollapsedCB.Size = new System.Drawing.Size(78, 19);
            this.MiningCollapsedCB.TabIndex = 2;
            this.MiningCollapsedCB.Text = "Collapsed";
            this.MiningCollapsedCB.UseVisualStyleBackColor = true;
            // 
            // MiningLogTB
            // 
            this.MiningLogTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MiningLogTB.Location = new System.Drawing.Point(1, 3);
            this.MiningLogTB.Name = "MiningLogTB";
            this.MiningLogTB.Size = new System.Drawing.Size(702, 326);
            this.MiningLogTB.TabIndex = 0;
            this.MiningLogTB.Text = "";
            this.MiningLogTB.WordWrap = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.ExeTextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.LocateExeButton);
            this.tabPage2.Controls.Add(this.MakeFilesButton);
            this.tabPage2.Controls.Add(this.OutputFolderButton);
            this.tabPage2.Controls.Add(this.OutputFolderTextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(848, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EZ Alt Starter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(842, 305);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // ExeTextBox
            // 
            this.ExeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExeTextBox.Location = new System.Drawing.Point(90, 314);
            this.ExeTextBox.Name = "ExeTextBox";
            this.ExeTextBox.Size = new System.Drawing.Size(723, 23);
            this.ExeTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "CSC exe file";
            // 
            // LocateExeButton
            // 
            this.LocateExeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LocateExeButton.Location = new System.Drawing.Point(819, 314);
            this.LocateExeButton.Name = "LocateExeButton";
            this.LocateExeButton.Size = new System.Drawing.Size(25, 23);
            this.LocateExeButton.TabIndex = 4;
            this.LocateExeButton.Text = "...";
            this.LocateExeButton.UseVisualStyleBackColor = true;
            this.LocateExeButton.Click += new System.EventHandler(this.LocateExeButton_Click);
            // 
            // MakeFilesButton
            // 
            this.MakeFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeFilesButton.Location = new System.Drawing.Point(732, 372);
            this.MakeFilesButton.Name = "MakeFilesButton";
            this.MakeFilesButton.Size = new System.Drawing.Size(113, 23);
            this.MakeFilesButton.TabIndex = 4;
            this.MakeFilesButton.Text = "Make EZ Files";
            this.MakeFilesButton.UseVisualStyleBackColor = true;
            this.MakeFilesButton.Click += new System.EventHandler(this.MakeFilesButton_Click);
            // 
            // OutputFolderButton
            // 
            this.OutputFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputFolderButton.Location = new System.Drawing.Point(819, 343);
            this.OutputFolderButton.Name = "OutputFolderButton";
            this.OutputFolderButton.Size = new System.Drawing.Size(25, 23);
            this.OutputFolderButton.TabIndex = 4;
            this.OutputFolderButton.Text = "...";
            this.OutputFolderButton.UseVisualStyleBackColor = true;
            this.OutputFolderButton.Click += new System.EventHandler(this.OutputFolderButton_Click);
            // 
            // OutputFolderTextBox
            // 
            this.OutputFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputFolderTextBox.Location = new System.Drawing.Point(90, 343);
            this.OutputFolderTextBox.Name = "OutputFolderTextBox";
            this.OutputFolderTextBox.Size = new System.Drawing.Size(723, 23);
            this.OutputFolderTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output Folder";
            // 
            // LogPollTimer
            // 
            this.LogPollTimer.Tick += new System.EventHandler(this.LogPollTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSC Assistant";
            this.MainTabControl.ResumeLayout(false);
            this.LogViewerTab.ResumeLayout(false);
            this.LogTabControl.ResumeLayout(false);
            this.CombatLogTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MiningLogTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage LogViewerTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer LogPollTimer;
        private System.Windows.Forms.TabControl LogTabControl;
        private System.Windows.Forms.TabPage CombatLogTab;
        private System.Windows.Forms.RichTextBox CombatLogTB;
        private System.Windows.Forms.TabPage MiningLogTab;
        private System.Windows.Forms.RichTextBox MiningLogTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox CombatCollapsedCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox CombatOmissionList;
        private System.Windows.Forms.Button ApplyCombatFiltersButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button MiningRefreshViewButton;
        private System.Windows.Forms.RichTextBox MiningOmissionList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox MiningCollapsedCB;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox ExeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LocateExeButton;
        private System.Windows.Forms.Button MakeFilesButton;
        private System.Windows.Forms.Button OutputFolderButton;
        private System.Windows.Forms.TextBox OutputFolderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserD;
        private System.Windows.Forms.OpenFileDialog OpenFileD;
    }
}