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
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(3, 9);
            this.lblPlayerName.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(61, 24);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Name";
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNumber.Location = new System.Drawing.Point(3, 33);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(83, 54);
            this.lblPlayerNumber.TabIndex = 1;
            this.lblPlayerNumber.Text = "Nu";
            // 
            // lblPlayerPosition
            // 
            this.lblPlayerPosition.AutoSize = true;
            this.lblPlayerPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPosition.Location = new System.Drawing.Point(3, 87);
            this.lblPlayerPosition.Name = "lblPlayerPosition";
            this.lblPlayerPosition.Size = new System.Drawing.Size(76, 24);
            this.lblPlayerPosition.TabIndex = 2;
            this.lblPlayerPosition.Text = "Position";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(3, 111);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(80, 24);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Capetan";
            // 
            // lblPlayerCapetan
            // 
            this.lblPlayerCapetan.AutoSize = true;
            this.lblPlayerCapetan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCapetan.Location = new System.Drawing.Point(89, 111);
            this.lblPlayerCapetan.Name = "lblPlayerCapetan";
            this.lblPlayerCapetan.Size = new System.Drawing.Size(42, 24);
            this.lblPlayerCapetan.TabIndex = 6;
            this.lblPlayerCapetan.Text = "Yes";
            // 
            // lblFavorete
            // 
            this.lblFavorete.AutoSize = true;
            this.lblFavorete.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavorete.Location = new System.Drawing.Point(87, 33);
            this.lblFavorete.Name = "lblFavorete";
            this.lblFavorete.Size = new System.Drawing.Size(41, 54);
            this.lblFavorete.TabIndex = 9;
            this.lblFavorete.Text = "*";
            this.lblFavorete.Visible = false;
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::DesktopFootball.Properties.Resources.NoIcon;
            this.imgPlayer.Location = new System.Drawing.Point(137, 33);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(100, 102);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 7;
            this.imgPlayer.TabStop = false;
            this.imgPlayer.Click += new System.EventHandler(this.imgPlayer_Click);
            // 
            // PlayerSelectionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Size = new System.Drawing.Size(245, 141);
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
