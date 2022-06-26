namespace DesktopFootball
{
    partial class RangList
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.tabMatches = new System.Windows.Forms.TabPage();
            this.pnlMatches = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlMatchSorter = new System.Windows.Forms.ComboBox();
            this.pnlPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.ddlPlayersSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPlayers.SuspendLayout();
            this.tabMatches.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPlayers);
            this.tabControl.Controls.Add(this.tabMatches);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(384, 561);
            this.tabControl.TabIndex = 0;
            // 
            // tabPlayers
            // 
            this.tabPlayers.Controls.Add(this.label6);
            this.tabPlayers.Controls.Add(this.label5);
            this.tabPlayers.Controls.Add(this.label4);
            this.tabPlayers.Controls.Add(this.label3);
            this.tabPlayers.Controls.Add(this.ddlPlayersSort);
            this.tabPlayers.Controls.Add(this.label2);
            this.tabPlayers.Controls.Add(this.pnlPlayers);
            this.tabPlayers.Location = new System.Drawing.Point(4, 22);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.Size = new System.Drawing.Size(376, 535);
            this.tabPlayers.TabIndex = 0;
            this.tabPlayers.Text = "Player rankings";
            this.tabPlayers.UseVisualStyleBackColor = true;
            // 
            // tabMatches
            // 
            this.tabMatches.Controls.Add(this.ddlMatchSorter);
            this.tabMatches.Controls.Add(this.label1);
            this.tabMatches.Controls.Add(this.pnlMatches);
            this.tabMatches.Location = new System.Drawing.Point(4, 22);
            this.tabMatches.Name = "tabMatches";
            this.tabMatches.Size = new System.Drawing.Size(376, 535);
            this.tabMatches.TabIndex = 0;
            this.tabMatches.Text = "Match rankings";
            this.tabMatches.UseVisualStyleBackColor = true;
            // 
            // pnlMatches
            // 
            this.pnlMatches.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMatches.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMatches.Location = new System.Drawing.Point(0, 23);
            this.pnlMatches.Name = "pnlMatches";
            this.pnlMatches.Size = new System.Drawing.Size(376, 512);
            this.pnlMatches.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sort by:";
            // 
            // ddlMatchSorter
            // 
            this.ddlMatchSorter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMatchSorter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlMatchSorter.FormattingEnabled = true;
            this.ddlMatchSorter.Location = new System.Drawing.Point(206, 0);
            this.ddlMatchSorter.Name = "ddlMatchSorter";
            this.ddlMatchSorter.Size = new System.Drawing.Size(170, 24);
            this.ddlMatchSorter.TabIndex = 2;
            this.ddlMatchSorter.SelectedIndexChanged += new System.EventHandler(this.ddlMatchSorter_SelectedIndexChanged);
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.AutoScroll = true;
            this.pnlPlayers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPlayers.Location = new System.Drawing.Point(0, 64);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(376, 471);
            this.pnlPlayers.TabIndex = 0;
            // 
            // ddlPlayersSort
            // 
            this.ddlPlayersSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPlayersSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlPlayersSort.FormattingEnabled = true;
            this.ddlPlayersSort.Location = new System.Drawing.Point(206, 0);
            this.ddlPlayersSort.Name = "ddlPlayersSort";
            this.ddlPlayersSort.Size = new System.Drawing.Size(170, 24);
            this.ddlPlayersSort.TabIndex = 4;
            this.ddlPlayersSort.SelectedIndexChanged += new System.EventHandler(this.ddlPlayersSort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sort by:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apearences";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 27);
            this.label5.MaximumSize = new System.Drawing.Size(55, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "Goals scored";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 27);
            this.label6.MaximumSize = new System.Drawing.Size(50, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "Yellow cards";
            // 
            // RangList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.tabControl);
            this.Name = "RangList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rang lists";
            this.Load += new System.EventHandler(this.RangList_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPlayers.ResumeLayout(false);
            this.tabPlayers.PerformLayout();
            this.tabMatches.ResumeLayout(false);
            this.tabMatches.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPlayers;
        private System.Windows.Forms.TabPage tabMatches;
        private System.Windows.Forms.FlowLayoutPanel pnlMatches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlMatchSorter;
        private System.Windows.Forms.ComboBox ddlPlayersSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel pnlPlayers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}