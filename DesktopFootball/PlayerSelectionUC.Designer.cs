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
            this.lblCapetan = new System.Windows.Forms.Label();
            this.lblPlayerFavorete = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerCapetana = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(7, 0);
            this.lblPlayerName.MaximumSize = new System.Drawing.Size(140, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(61, 24);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Name";
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNumber.Location = new System.Drawing.Point(5, 50);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(71, 31);
            this.lblPlayerNumber.TabIndex = 1;
            this.lblPlayerNumber.Text = "Num";
            // 
            // lblPlayerPosition
            // 
            this.lblPlayerPosition.AutoSize = true;
            this.lblPlayerPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPosition.Location = new System.Drawing.Point(7, 121);
            this.lblPlayerPosition.Name = "lblPlayerPosition";
            this.lblPlayerPosition.Size = new System.Drawing.Size(76, 24);
            this.lblPlayerPosition.TabIndex = 2;
            this.lblPlayerPosition.Text = "Position";
            // 
            // lblCapetan
            // 
            this.lblCapetan.AutoSize = true;
            this.lblCapetan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapetan.Location = new System.Drawing.Point(7, 185);
            this.lblCapetan.Name = "lblCapetan";
            this.lblCapetan.Size = new System.Drawing.Size(80, 24);
            this.lblCapetan.TabIndex = 3;
            this.lblCapetan.Text = "Capetan";
            // 
            // lblPlayerFavorete
            // 
            this.lblPlayerFavorete.AutoSize = true;
            this.lblPlayerFavorete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerFavorete.Location = new System.Drawing.Point(175, 221);
            this.lblPlayerFavorete.Name = "lblPlayerFavorete";
            this.lblPlayerFavorete.Size = new System.Drawing.Size(25, 31);
            this.lblPlayerFavorete.TabIndex = 4;
            this.lblPlayerFavorete.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Favorete player";
            // 
            // lblPlayerCapetana
            // 
            this.lblPlayerCapetana.AutoSize = true;
            this.lblPlayerCapetana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCapetana.Location = new System.Drawing.Point(177, 185);
            this.lblPlayerCapetana.Name = "lblPlayerCapetana";
            this.lblPlayerCapetana.Size = new System.Drawing.Size(35, 24);
            this.lblPlayerCapetana.TabIndex = 6;
            this.lblPlayerCapetana.Text = "No";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(181, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // PlayerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPlayerCapetana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayerFavorete);
            this.Controls.Add(this.lblCapetan);
            this.Controls.Add(this.lblPlayerPosition);
            this.Controls.Add(this.lblPlayerNumber);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "PlayerUC";
            this.Size = new System.Drawing.Size(363, 261);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.Label lblPlayerPosition;
        private System.Windows.Forms.Label lblCapetan;
        private System.Windows.Forms.Label lblPlayerFavorete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerCapetana;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
