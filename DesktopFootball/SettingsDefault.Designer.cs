namespace DesktopFootball
{
    partial class SettingsDefault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDefault));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbChampionship = new System.Windows.Forms.GroupBox();
            this.Men = new System.Windows.Forms.RadioButton();
            this.Women = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.gbChampionship.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbChampionship
            // 
            this.gbChampionship.Controls.Add(this.Men);
            this.gbChampionship.Controls.Add(this.Women);
            resources.ApplyResources(this.gbChampionship, "gbChampionship");
            this.gbChampionship.Name = "gbChampionship";
            this.gbChampionship.TabStop = false;
            // 
            // Men
            // 
            resources.ApplyResources(this.Men, "Men");
            this.Men.Name = "Men";
            this.Men.UseVisualStyleBackColor = true;
            // 
            // Women
            // 
            this.Women.Checked = true;
            resources.ApplyResources(this.Women, "Women");
            this.Women.Name = "Women";
            this.Women.TabStop = true;
            this.Women.UseVisualStyleBackColor = true;
            // 
            // btnLanguage
            // 
            resources.ApplyResources(this.btnLanguage, "btnLanguage");
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // SettingsDefault
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.gbChampionship);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsDefault";
            this.gbChampionship.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbChampionship;
        private System.Windows.Forms.RadioButton Men;
        private System.Windows.Forms.RadioButton Women;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnLanguage;
    }
}

