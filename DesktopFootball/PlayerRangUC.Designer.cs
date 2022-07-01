namespace DesktopFootball
{
    partial class PlayerRangUC
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
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblApearences = new System.Windows.Forms.Label();
            this.lblGoalsScored = new System.Windows.Forms.Label();
            this.lblYellowCard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::DataLibrary.PictureResources.NoIcon;
            this.imgPlayer.Location = new System.Drawing.Point(0, 0);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(35, 35);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 8;
            this.imgPlayer.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(41, 8);
            this.lblName.MinimumSize = new System.Drawing.Size(170, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(170, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "First Name Last Name";
            // 
            // lblApearences
            // 
            this.lblApearences.AutoSize = true;
            this.lblApearences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApearences.Location = new System.Drawing.Point(217, 8);
            this.lblApearences.MaximumSize = new System.Drawing.Size(50, 0);
            this.lblApearences.Name = "lblApearences";
            this.lblApearences.Size = new System.Drawing.Size(38, 20);
            this.lblApearences.TabIndex = 10;
            this.lblApearences.Text = "Ape";
            // 
            // lblGoalsScored
            // 
            this.lblGoalsScored.AutoSize = true;
            this.lblGoalsScored.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalsScored.Location = new System.Drawing.Point(261, 8);
            this.lblGoalsScored.MaximumSize = new System.Drawing.Size(50, 0);
            this.lblGoalsScored.Name = "lblGoalsScored";
            this.lblGoalsScored.Size = new System.Drawing.Size(37, 20);
            this.lblGoalsScored.TabIndex = 11;
            this.lblGoalsScored.Text = "Sco";
            // 
            // lblYellowCard
            // 
            this.lblYellowCard.AutoSize = true;
            this.lblYellowCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYellowCard.Location = new System.Drawing.Point(304, 8);
            this.lblYellowCard.MaximumSize = new System.Drawing.Size(50, 0);
            this.lblYellowCard.Name = "lblYellowCard";
            this.lblYellowCard.Size = new System.Drawing.Size(35, 20);
            this.lblYellowCard.TabIndex = 12;
            this.lblYellowCard.Text = "Yell";
            // 
            // PlayerRangUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.lblYellowCard);
            this.Controls.Add(this.lblGoalsScored);
            this.Controls.Add(this.lblApearences);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.imgPlayer);
            this.Name = "PlayerRangUC";
            this.Size = new System.Drawing.Size(350, 35);
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblApearences;
        private System.Windows.Forms.Label lblGoalsScored;
        private System.Windows.Forms.Label lblYellowCard;
    }
}
