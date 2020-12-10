
namespace CSC_Assistant.Client.Forms
{
    partial class LogViewerForm
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
            this.ApplyMiningFiltersButton = new System.Windows.Forms.Button();
            this.MiningOmissionList = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MiningCollapsedCB = new System.Windows.Forms.CheckBox();
            this.MiningLogTB = new System.Windows.Forms.RichTextBox();
            this.LogPollTimer = new System.Windows.Forms.Timer(this.components);
            this.LogTabControl.SuspendLayout();
            this.CombatLogTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MiningLogTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogTabControl
            // 
            this.LogTabControl.Controls.Add(this.CombatLogTab);
            this.LogTabControl.Controls.Add(this.MiningLogTab);
            this.LogTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTabControl.Location = new System.Drawing.Point(0, 0);
            this.LogTabControl.Name = "LogTabControl";
            this.LogTabControl.SelectedIndex = 0;
            this.LogTabControl.Size = new System.Drawing.Size(1132, 237);
            this.LogTabControl.TabIndex = 2;
            // 
            // CombatLogTab
            // 
            this.CombatLogTab.Controls.Add(this.panel2);
            this.CombatLogTab.Controls.Add(this.CombatLogTB);
            this.CombatLogTab.Location = new System.Drawing.Point(4, 24);
            this.CombatLogTab.Name = "CombatLogTab";
            this.CombatLogTab.Padding = new System.Windows.Forms.Padding(3);
            this.CombatLogTab.Size = new System.Drawing.Size(1124, 209);
            this.CombatLogTab.TabIndex = 0;
            this.CombatLogTab.Text = "Combat";
            this.CombatLogTab.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ApplyCombatFiltersButton);
            this.panel2.Controls.Add(this.CombatOmissionList);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CombatCollapsedCB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(999, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 203);
            this.panel2.TabIndex = 1;
            // 
            // ApplyCombatFiltersButton
            // 
            this.ApplyCombatFiltersButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ApplyCombatFiltersButton.Location = new System.Drawing.Point(0, 170);
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
            this.CombatOmissionList.Location = new System.Drawing.Point(0, 37);
            this.CombatOmissionList.Name = "CombatOmissionList";
            this.CombatOmissionList.Size = new System.Drawing.Size(122, 127);
            this.CombatOmissionList.TabIndex = 5;
            this.CombatOmissionList.Text = "Session\nValue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 19);
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
            this.CombatCollapsedCB.Dock = System.Windows.Forms.DockStyle.Top;
            this.CombatCollapsedCB.Location = new System.Drawing.Point(0, 0);
            this.CombatCollapsedCB.Name = "CombatCollapsedCB";
            this.CombatCollapsedCB.Size = new System.Drawing.Size(122, 19);
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
            this.CombatLogTB.Size = new System.Drawing.Size(990, 198);
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
            this.MiningLogTab.Size = new System.Drawing.Size(1124, 209);
            this.MiningLogTab.TabIndex = 1;
            this.MiningLogTab.Text = "Mining";
            this.MiningLogTab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ApplyMiningFiltersButton);
            this.panel3.Controls.Add(this.MiningOmissionList);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.MiningCollapsedCB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(999, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 203);
            this.panel3.TabIndex = 1;
            // 
            // ApplyMiningFiltersButton
            // 
            this.ApplyMiningFiltersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyMiningFiltersButton.Location = new System.Drawing.Point(0, 170);
            this.ApplyMiningFiltersButton.Name = "ApplyMiningFiltersButton";
            this.ApplyMiningFiltersButton.Size = new System.Drawing.Size(122, 33);
            this.ApplyMiningFiltersButton.TabIndex = 0;
            this.ApplyMiningFiltersButton.Text = "Apply";
            this.ApplyMiningFiltersButton.UseVisualStyleBackColor = true;
            this.ApplyMiningFiltersButton.Click += new System.EventHandler(this.MiningRefreshViewButton_Click);
            // 
            // MiningOmissionList
            // 
            this.MiningOmissionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MiningOmissionList.Location = new System.Drawing.Point(0, 37);
            this.MiningOmissionList.Name = "MiningOmissionList";
            this.MiningOmissionList.Size = new System.Drawing.Size(122, 127);
            this.MiningOmissionList.TabIndex = 5;
            this.MiningOmissionList.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Omissions";
            // 
            // MiningCollapsedCB
            // 
            this.MiningCollapsedCB.AutoSize = true;
            this.MiningCollapsedCB.Dock = System.Windows.Forms.DockStyle.Top;
            this.MiningCollapsedCB.Location = new System.Drawing.Point(0, 0);
            this.MiningCollapsedCB.Name = "MiningCollapsedCB";
            this.MiningCollapsedCB.Size = new System.Drawing.Size(122, 19);
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
            this.MiningLogTB.Size = new System.Drawing.Size(992, 203);
            this.MiningLogTB.TabIndex = 0;
            this.MiningLogTB.Text = "";
            this.MiningLogTB.WordWrap = false;
            // 
            // LogPollTimer
            // 
            this.LogPollTimer.Tick += new System.EventHandler(this.LogPollTimer_Tick);
            // 
            // LogViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 237);
            this.Controls.Add(this.LogTabControl);
            this.Name = "LogViewerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Logs";
            this.Shown += new System.EventHandler(this.LogViewerForm_Shown);
            this.LogTabControl.ResumeLayout(false);
            this.CombatLogTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MiningLogTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LogTabControl;
        private System.Windows.Forms.TabPage CombatLogTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ApplyCombatFiltersButton;
        private System.Windows.Forms.RichTextBox CombatOmissionList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CombatCollapsedCB;
        private System.Windows.Forms.RichTextBox CombatLogTB;
        private System.Windows.Forms.TabPage MiningLogTab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ApplyMiningFiltersButton;
        private System.Windows.Forms.RichTextBox MiningOmissionList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox MiningCollapsedCB;
        private System.Windows.Forms.RichTextBox MiningLogTB;
        private System.Windows.Forms.Timer LogPollTimer;
    }
}