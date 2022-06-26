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
            this.lblPlayerFavorete = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblPlayerCapetan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(7, 0);
            this.lblPlayerName.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(61, 24);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Name";
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNumber.Location = new System.Drawing.Point(12, 33);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(71, 31);
            this.lblPlayerNumber.TabIndex = 1;
            this.lblPlayerNumber.Text = "Num";
            // 
            // lblPlayerPosition
            // 
            this.lblPlayerPosition.AutoSize = true;
            this.lblPlayerPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPosition.Location = new System.Drawing.Point(14, 77);
            this.lblPlayerPosition.Name = "lblPlayerPosition";
            this.lblPlayerPosition.Size = new System.Drawing.Size(76, 24);
            this.lblPlayerPosition.TabIndex = 2;
            this.lblPlayerPosition.Text = "Position";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(139, 40);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(80, 24);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Capetan";
            // 
            // lblPlayerFavorete
            // 
            this.lblPlayerFavorete.AutoSize = true;
            this.lblPlayerFavorete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerFavorete.Location = new System.Drawing.Point(285, 77);
            this.lblPlayerFavorete.Name = "lblPlayerFavorete";
            this.lblPlayerFavorete.Size = new System.Drawing.Size(25, 31);
            this.lblPlayerFavorete.TabIndex = 4;
            this.lblPlayerFavorete.Text = "*";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(139, 77);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(140, 24);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Favorete player";
            // 
            // lblPlayerCapetan
            // 
            this.lblPlayerCapetan.AutoSize = true;
            this.lblPlayerCapetan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCapetan.Location = new System.Drawing.Point(268, 40);
            this.lblPlayerCapetan.Name = "lblPlayerCapetan";
            this.lblPlayerCapetan.Size = new System.Drawing.Size(42, 24);
            this.lblPlayerCapetan.TabIndex = 6;
            this.lblPlayerCapetan.Text = "Yes";
            // 
            // PlayerSelectionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.lblPlayerCapetan);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblPlayerFavorete);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblPlayerPosition);
            this.Controls.Add(this.lblPlayerNumber);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "PlayerSelectionUC";
            this.Size = new System.Drawing.Size(323, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.Label lblPlayerPosition;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblPlayerFavorete;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblPlayerCapetan;
    }
}
