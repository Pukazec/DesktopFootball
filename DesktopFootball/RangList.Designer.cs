namespace DesktopFootball
{
    partial class RangList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangList));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.lblError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlPlayersSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.tabMatches = new System.Windows.Forms.TabPage();
            this.ddlMatchSorter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMatches = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabPlayers.SuspendLayout();
            this.tabMatches.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabPlayers);
            this.tabControl.Controls.Add(this.tabMatches);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabPlayers
            // 
            resources.ApplyResources(this.tabPlayers, "tabPlayers");
            this.tabPlayers.Controls.Add(this.lblError);
            this.tabPlayers.Controls.Add(this.label6);
            this.tabPlayers.Controls.Add(this.label5);
            this.tabPlayers.Controls.Add(this.label4);
            this.tabPlayers.Controls.Add(this.label3);
            this.tabPlayers.Controls.Add(this.ddlPlayersSort);
            this.tabPlayers.Controls.Add(this.label2);
            this.tabPlayers.Controls.Add(this.pnlPlayers);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Name = "lblError";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ddlPlayersSort
            // 
            resources.ApplyResources(this.ddlPlayersSort, "ddlPlayersSort");
            this.ddlPlayersSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPlayersSort.FormattingEnabled = true;
            this.ddlPlayersSort.Name = "ddlPlayersSort";
            this.ddlPlayersSort.SelectedIndexChanged += new System.EventHandler(this.ddlPlayersSort_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pnlPlayers
            // 
            resources.ApplyResources(this.pnlPlayers, "pnlPlayers");
            this.pnlPlayers.Name = "pnlPlayers";
            // 
            // tabMatches
            // 
            resources.ApplyResources(this.tabMatches, "tabMatches");
            this.tabMatches.Controls.Add(this.ddlMatchSorter);
            this.tabMatches.Controls.Add(this.label1);
            this.tabMatches.Controls.Add(this.pnlMatches);
            this.tabMatches.Name = "tabMatches";
            this.tabMatches.UseVisualStyleBackColor = true;
            // 
            // ddlMatchSorter
            // 
            resources.ApplyResources(this.ddlMatchSorter, "ddlMatchSorter");
            this.ddlMatchSorter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMatchSorter.FormattingEnabled = true;
            this.ddlMatchSorter.Name = "ddlMatchSorter";
            this.ddlMatchSorter.SelectedIndexChanged += new System.EventHandler(this.ddlMatchSorter_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pnlMatches
            // 
            resources.ApplyResources(this.pnlMatches, "pnlMatches");
            this.pnlMatches.Name = "pnlMatches";
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.printToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.saveSettingsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.editSettings_Click);
            // 
            // saveSettingsToolStripMenuItem
            // 
            resources.ApplyResources(this.saveSettingsToolStripMenuItem, "saveSettingsToolStripMenuItem");
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageSettingsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem1});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            // 
            // pageSettingsToolStripMenuItem
            // 
            resources.ApplyResources(this.pageSettingsToolStripMenuItem, "pageSettingsToolStripMenuItem");
            this.pageSettingsToolStripMenuItem.Name = "pageSettingsToolStripMenuItem";
            this.pageSettingsToolStripMenuItem.Click += new System.EventHandler(this.pageSettings_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.printerSelection_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            resources.ApplyResources(this.printPreviewToolStripMenuItem, "printPreviewToolStripMenuItem");
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreview_Click);
            // 
            // printToolStripMenuItem1
            // 
            resources.ApplyResources(this.printToolStripMenuItem1, "printToolStripMenuItem1");
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.print_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            resources.ApplyResources(this.printPreviewDialog, "printPreviewDialog");
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.UseAntiAlias = true;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // contextMenuStrip
            // 
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addImageToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Opened += new System.EventHandler(this.contextMenuStrip_Opened);
            // 
            // addImageToolStripMenuItem
            // 
            resources.ApplyResources(this.addImageToolStripMenuItem, "addImageToolStripMenuItem");
            this.addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
            this.addImageToolStripMenuItem.Click += new System.EventHandler(this.addImageToolStripMenuItem_Click);
            // 
            // RangList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "RangList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RangList_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPlayers.ResumeLayout(false);
            this.tabPlayers.PerformLayout();
            this.tabMatches.ResumeLayout(false);
            this.tabMatches.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPlayers;
        private System.Windows.Forms.TabPage tabMatches;
        private System.Windows.Forms.FlowLayoutPanel pnlMatches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlMatchSorter;
        private System.Windows.Forms.ComboBox ddlPlayersSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel pnlPlayers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addImageToolStripMenuItem;
        private System.Windows.Forms.Label lblError;
    }
}