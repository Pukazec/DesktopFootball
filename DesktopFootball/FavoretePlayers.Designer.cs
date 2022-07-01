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
            this.txtSearch.Location = new System.Drawing.Point(88, 47);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 20);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Search";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(16, 759);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 40);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Close";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(991, 759);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 40);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblFavoretePlayersError
            // 
            this.lblFavoretePlayersError.AutoSize = true;
            this.lblFavoretePlayersError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoretePlayersError.ForeColor = System.Drawing.Color.Red;
            this.lblFavoretePlayersError.Location = new System.Drawing.Point(739, 767);
            this.lblFavoretePlayersError.Name = "lblFavoretePlayersError";
            this.lblFavoretePlayersError.Size = new System.Drawing.Size(246, 24);
            this.lblFavoretePlayersError.TabIndex = 22;
            this.lblFavoretePlayersError.Text = "Not enough favorete players";
            this.lblFavoretePlayersError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(629, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Favorete players";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "All players";
            // 
            // pnlAllPlayers
            // 
            this.pnlAllPlayers.AllowDrop = true;
            this.pnlAllPlayers.AutoScroll = true;
            this.pnlAllPlayers.ContextMenuStrip = this.playerContextMenuStrip;
            this.pnlAllPlayers.Location = new System.Drawing.Point(16, 73);
            this.pnlAllPlayers.Name = "pnlAllPlayers";
            this.pnlAllPlayers.Size = new System.Drawing.Size(525, 681);
            this.pnlAllPlayers.TabIndex = 29;
            this.pnlAllPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlPlayers_DragDrop);
            this.pnlAllPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlPlayers_DragEnter);
            // 
            // playerContextMenuStrip
            // 
            this.playerContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToFavouretesToolStripMenuItem});
            this.playerContextMenuStrip.Name = "playerContextMenuStrip";
            this.playerContextMenuStrip.Size = new System.Drawing.Size(168, 26);
            this.playerContextMenuStrip.Opened += new System.EventHandler(this.playerContextMenuStrip_Opened);
            // 
            // moveToFavouretesToolStripMenuItem
            // 
            this.moveToFavouretesToolStripMenuItem.Name = "moveToFavouretesToolStripMenuItem";
            this.moveToFavouretesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.moveToFavouretesToolStripMenuItem.Text = "Move to other list";
            this.moveToFavouretesToolStripMenuItem.Click += new System.EventHandler(this.moveToOtherList_Click);
            // 
            // pnlFavoretePlayers
            // 
            this.pnlFavoretePlayers.AllowDrop = true;
            this.pnlFavoretePlayers.ContextMenuStrip = this.playerContextMenuStrip;
            this.pnlFavoretePlayers.Location = new System.Drawing.Point(553, 72);
            this.pnlFavoretePlayers.Name = "pnlFavoretePlayers";
            this.pnlFavoretePlayers.Size = new System.Drawing.Size(525, 681);
            this.pnlFavoretePlayers.TabIndex = 30;
            this.pnlFavoretePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlPlayers_DragDrop);
            this.pnlFavoretePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlPlayers_DragEnter);
            // 
            // FavoretePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 811);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FavoretePlayers";
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