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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Representation));
            this.label1 = new System.Windows.Forms.Label();
            this.ddlRepresentation = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFavoreteRepresentationError = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ddlRepresentation
            // 
            resources.ApplyResources(this.ddlRepresentation, "ddlRepresentation");
            this.ddlRepresentation.FormattingEnabled = true;
            this.ddlRepresentation.Name = "ddlRepresentation";
            this.ddlRepresentation.Sorted = true;
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFavoreteRepresentationError
            // 
            resources.ApplyResources(this.lblFavoreteRepresentationError, "lblFavoreteRepresentationError");
            this.lblFavoreteRepresentationError.ForeColor = System.Drawing.Color.Red;
            this.lblFavoreteRepresentationError.Name = "lblFavoreteRepresentationError";
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Representation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblFavoreteRepresentationError);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ddlRepresentation);
            this.Controls.Add(this.label1);
            this.Name = "Representation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Representation_FormClosing);
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