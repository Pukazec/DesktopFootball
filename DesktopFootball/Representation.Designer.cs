namespace DesktopFootball
{
    partial class Representation
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
            this.label1 = new System.Windows.Forms.Label();
            this.ddlRepresentation = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFavoreteRepresentationError = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favorete representation:";
            // 
            // ddlRepresentation
            // 
            this.ddlRepresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlRepresentation.FormattingEnabled = true;
            this.ddlRepresentation.Location = new System.Drawing.Point(234, 13);
            this.ddlRepresentation.Name = "ddlRepresentation";
            this.ddlRepresentation.Size = new System.Drawing.Size(328, 32);
            this.ddlRepresentation.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(17, 67);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 40);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFavoreteRepresentationError
            // 
            this.lblFavoreteRepresentationError.AutoSize = true;
            this.lblFavoreteRepresentationError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoreteRepresentationError.ForeColor = System.Drawing.Color.Red;
            this.lblFavoreteRepresentationError.Location = new System.Drawing.Point(211, 75);
            this.lblFavoreteRepresentationError.Name = "lblFavoreteRepresentationError";
            this.lblFavoreteRepresentationError.Size = new System.Drawing.Size(258, 24);
            this.lblFavoreteRepresentationError.TabIndex = 14;
            this.lblFavoreteRepresentationError.Text = "Select favorete representation";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(475, 67);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 40);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Representation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 119);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblFavoreteRepresentationError);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ddlRepresentation);
            this.Controls.Add(this.label1);
            this.Name = "Representation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Representation";
            this.Load += new System.EventHandler(this.Representation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlRepresentation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFavoreteRepresentationError;
        private System.Windows.Forms.Button btnNext;
    }
}