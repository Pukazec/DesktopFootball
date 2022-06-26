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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblFavoretePlayersError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAllPlayers = new System.Windows.Forms.ListBox();
            this.lbFavoretePlayers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(111, 47);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 20);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Search";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(18, 545);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 40);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(691, 545);
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
            this.lblFavoretePlayersError.Location = new System.Drawing.Point(439, 553);
            this.lblFavoretePlayersError.Name = "lblFavoretePlayersError";
            this.lblFavoretePlayersError.Size = new System.Drawing.Size(246, 24);
            this.lblFavoretePlayersError.TabIndex = 22;
            this.lblFavoretePlayersError.Text = "Not enough favorete players";
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
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "All players";
            // 
            // lbAllPlayers
            // 
            this.lbAllPlayers.AllowDrop = true;
            this.lbAllPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllPlayers.FormattingEnabled = true;
            this.lbAllPlayers.ItemHeight = 18;
            this.lbAllPlayers.Location = new System.Drawing.Point(22, 72);
            this.lbAllPlayers.Name = "lbAllPlayers";
            this.lbAllPlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAllPlayers.Size = new System.Drawing.Size(359, 454);
            this.lbAllPlayers.TabIndex = 27;
            this.lbAllPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbAllPlayers_DragDrop);
            this.lbAllPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbAllPlayers_DragEnter);
            this.lbAllPlayers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // lbFavoretePlayers
            // 
            this.lbFavoretePlayers.AllowDrop = true;
            this.lbFavoretePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFavoretePlayers.FormattingEnabled = true;
            this.lbFavoretePlayers.ItemHeight = 18;
            this.lbFavoretePlayers.Location = new System.Drawing.Point(419, 72);
            this.lbFavoretePlayers.Name = "lbFavoretePlayers";
            this.lbFavoretePlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbFavoretePlayers.Size = new System.Drawing.Size(359, 454);
            this.lbFavoretePlayers.TabIndex = 28;
            this.lbFavoretePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbAllPlayers_DragDrop);
            this.lbFavoretePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbAllPlayers_DragEnter);
            this.lbFavoretePlayers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // FavoretePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.lbFavoretePlayers);
            this.Controls.Add(this.lbAllPlayers);
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
            this.Load += new System.EventHandler(this.FavoretePlayers_Load);
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
        private System.Windows.Forms.ListBox lbAllPlayers;
        private System.Windows.Forms.ListBox lbFavoretePlayers;
    }
}