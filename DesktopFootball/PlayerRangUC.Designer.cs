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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblApearences = new System.Windows.Forms.Label();
            this.lblGoalsScored = new System.Windows.Forms.Label();
            this.lblYellowCard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(41, 4);
            this.lblName.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 24);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "First Name Last Name";
            // 
            // lblApearences
            // 
            this.lblApearences.AutoSize = true;
            this.lblApearences.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApearences.Location = new System.Drawing.Point(247, 4);
            this.lblApearences.MaximumSize = new System.Drawing.Size(50, 0);
            this.lblApearences.Name = "lblApearences";
            this.lblApearences.Size = new System.Drawing.Size(45, 24);
            this.lblApearences.TabIndex = 10;
            this.lblApearences.Text = "Ape";
            // 
            // lblGoalsScored
            // 
            this.lblGoalsScored.AutoSize = true;
            this.lblGoalsScored.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalsScored.Location = new System.Drawing.Point(298, 4);
            this.lblGoalsScored.MaximumSize = new System.Drawing.Size(50, 0);
            this.lblGoalsScored.Name = "lblGoalsScored";
            this.lblGoalsScored.Size = new System.Drawing.Size(43, 24);
            this.lblGoalsScored.TabIndex = 11;
            this.lblGoalsScored.Text = "Sco";
            // 
            // lblYellowCard
            // 
            this.lblYellowCard.AutoSize = true;
            this.lblYellowCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYellowCard.Location = new System.Drawing.Point(347, 4);
            this.lblYellowCard.MaximumSize = new System.Drawing.Size(50, 0);
            this.lblYellowCard.Name = "lblYellowCard";
            this.lblYellowCard.Size = new System.Drawing.Size(41, 24);
            this.lblYellowCard.TabIndex = 12;
            this.lblYellowCard.Text = "Yell";
            // 
            // PlayerRangUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblYellowCard);
            this.Controls.Add(this.lblGoalsScored);
            this.Controls.Add(this.lblApearences);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PlayerRangUC";
            this.Size = new System.Drawing.Size(395, 35);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblApearences;
        private System.Windows.Forms.Label lblGoalsScored;
        private System.Windows.Forms.Label lblYellowCard;
    }
}
