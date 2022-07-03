namespace DesktopFootball
{
    partial class PlayerSelectionUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerSelectionUC));
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.lblPlayerPosition = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblPlayerCapetan = new System.Windows.Forms.Label();
            this.lblFavorete = new System.Windows.Forms.Label();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            resources.ApplyResources(this.lblPlayerName, "lblPlayerName");
            this.lblPlayerName.Name = "lblPlayerName";
            // 
            // lblPlayerNumber
            // 
            resources.ApplyResources(this.lblPlayerNumber, "lblPlayerNumber");
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            // 
            // lblPlayerPosition
            // 
            resources.ApplyResources(this.lblPlayerPosition, "lblPlayerPosition");
            this.lblPlayerPosition.Name = "lblPlayerPosition";
            // 
            // lbl1
            // 
            resources.ApplyResources(this.lbl1, "lbl1");
            this.lbl1.Name = "lbl1";
            // 
            // lblPlayerCapetan
            // 
            resources.ApplyResources(this.lblPlayerCapetan, "lblPlayerCapetan");
            this.lblPlayerCapetan.Name = "lblPlayerCapetan";
            // 
            // lblFavorete
            // 
            resources.ApplyResources(this.lblFavorete, "lblFavorete");
            this.lblFavorete.Name = "lblFavorete";
            // 
            // imgPlayer
            // 
            resources.ApplyResources(this.imgPlayer, "imgPlayer");
            this.imgPlayer.Image = global::DesktopFootball.Properties.Resources.NoIcon;
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.TabStop = false;
            this.imgPlayer.Click += new System.EventHandler(this.imgPlayer_Click);
            // 
            // PlayerSelectionUC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.lblFavorete);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.lblPlayerCapetan);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblPlayerPosition);
            this.Controls.Add(this.lblPlayerNumber);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "PlayerSelectionUC";
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.Label lblPlayerPosition;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblPlayerCapetan;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.Label lblFavorete;
    }
}
