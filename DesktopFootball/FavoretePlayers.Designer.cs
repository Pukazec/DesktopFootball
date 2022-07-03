namespace DesktopFootball
{
    partial class FavoretePlayers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoretePlayers));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblFavoretePlayersError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAllPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.playerContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveToFavouretesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFavoretePlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.playerContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblFavoretePlayersError
            // 
            resources.ApplyResources(this.lblFavoretePlayersError, "lblFavoretePlayersError");
            this.lblFavoretePlayersError.ForeColor = System.Drawing.Color.Red;
            this.lblFavoretePlayersError.Name = "lblFavoretePlayersError";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pnlAllPlayers
            // 
            resources.ApplyResources(this.pnlAllPlayers, "pnlAllPlayers");
            this.pnlAllPlayers.AllowDrop = true;
            this.pnlAllPlayers.ContextMenuStrip = this.playerContextMenuStrip;
            this.pnlAllPlayers.Name = "pnlAllPlayers";
            this.pnlAllPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlPlayers_DragDrop);
            this.pnlAllPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlPlayers_DragEnter);
            // 
            // playerContextMenuStrip
            // 
            resources.ApplyResources(this.playerContextMenuStrip, "playerContextMenuStrip");
            this.playerContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToFavouretesToolStripMenuItem});
            this.playerContextMenuStrip.Name = "playerContextMenuStrip";
            this.playerContextMenuStrip.Opened += new System.EventHandler(this.playerContextMenuStrip_Opened);
            // 
            // moveToFavouretesToolStripMenuItem
            // 
            resources.ApplyResources(this.moveToFavouretesToolStripMenuItem, "moveToFavouretesToolStripMenuItem");
            this.moveToFavouretesToolStripMenuItem.Name = "moveToFavouretesToolStripMenuItem";
            this.moveToFavouretesToolStripMenuItem.Click += new System.EventHandler(this.moveToOtherList_Click);
            // 
            // pnlFavoretePlayers
            // 
            resources.ApplyResources(this.pnlFavoretePlayers, "pnlFavoretePlayers");
            this.pnlFavoretePlayers.AllowDrop = true;
            this.pnlFavoretePlayers.ContextMenuStrip = this.playerContextMenuStrip;
            this.pnlFavoretePlayers.Name = "pnlFavoretePlayers";
            this.pnlFavoretePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlPlayers_DragDrop);
            this.pnlFavoretePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlPlayers_DragEnter);
            // 
            // FavoretePlayers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlFavoretePlayers);
            this.Controls.Add(this.pnlAllPlayers);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblFavoretePlayersError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FavoretePlayers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FavoretePlayers_FormClosing);
            this.playerContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblFavoretePlayersError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlAllPlayers;
        private System.Windows.Forms.FlowLayoutPanel pnlFavoretePlayers;
        private System.Windows.Forms.ContextMenuStrip playerContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem moveToFavouretesToolStripMenuItem;
    }
}