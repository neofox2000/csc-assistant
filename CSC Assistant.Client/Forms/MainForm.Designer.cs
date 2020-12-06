namespace CSC_Assistant.Client.Forms
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LogViewerMi = new System.Windows.Forms.ToolStripMenuItem();
            this.EzAltStarterMi = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemBrowserMi = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileSubMenu,
            this.ToolsSubMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(880, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "menuStrip1";
            // 
            // FileSubMenu
            // 
            this.FileSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseMi});
            this.FileSubMenu.Name = "FileSubMenu";
            this.FileSubMenu.Size = new System.Drawing.Size(37, 20);
            this.FileSubMenu.Text = "File";
            // 
            // CloseMi
            // 
            this.CloseMi.Name = "CloseMi";
            this.CloseMi.Size = new System.Drawing.Size(103, 22);
            this.CloseMi.Text = "Close";
            this.CloseMi.Click += new System.EventHandler(this.CloseMi_Click);
            // 
            // ToolsSubMenu
            // 
            this.ToolsSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogViewerMi,
            this.EzAltStarterMi,
            this.ItemBrowserMi});
            this.ToolsSubMenu.Name = "ToolsSubMenu";
            this.ToolsSubMenu.Size = new System.Drawing.Size(46, 20);
            this.ToolsSubMenu.Text = "Tools";
            // 
            // LogViewerMi
            // 
            this.LogViewerMi.Name = "LogViewerMi";
            this.LogViewerMi.Size = new System.Drawing.Size(143, 22);
            this.LogViewerMi.Text = "Log Viewer";
            this.LogViewerMi.Click += new System.EventHandler(this.LogViewerMi_Click);
            // 
            // EzAltStarterMi
            // 
            this.EzAltStarterMi.Name = "EzAltStarterMi";
            this.EzAltStarterMi.Size = new System.Drawing.Size(143, 22);
            this.EzAltStarterMi.Text = "Ez Alt Starter";
            this.EzAltStarterMi.Click += new System.EventHandler(this.EzAltStarterMi_Click);
            // 
            // ItemBrowserMi
            // 
            this.ItemBrowserMi.Name = "ItemBrowserMi";
            this.ItemBrowserMi.Size = new System.Drawing.Size(143, 22);
            this.ItemBrowserMi.Text = "Item Browser";
            this.ItemBrowserMi.Click += new System.EventHandler(this.ItemBrowserMi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSC Assistant";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileSubMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseMi;
        private System.Windows.Forms.ToolStripMenuItem ToolsSubMenu;
        private System.Windows.Forms.ToolStripMenuItem LogViewerMi;
        private System.Windows.Forms.ToolStripMenuItem EzAltStarterMi;
        private System.Windows.Forms.ToolStripMenuItem ItemBrowserMi;
    }
}