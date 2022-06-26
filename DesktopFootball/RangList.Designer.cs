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
            this.tabControl.SuspendLayout();
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
            this.tabPlayers.Location = new System.Drawing.Point(4, 22);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.Size = new System.Drawing.Size(792, 424);
            this.tabPlayers.TabIndex = 0;
            this.tabPlayers.Text = "Player rankings";
            this.tabPlayers.UseVisualStyleBackColor = true;
            // 
            // tabMatches
            // 
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
            this.pnlMatches.Location = new System.Drawing.Point(0, 80);
            this.pnlMatches.Name = "pnlMatches";
            this.pnlMatches.Size = new System.Drawing.Size(376, 455);
            this.pnlMatches.TabIndex = 0;
            // 
            // RangList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.tabControl);
            this.Name = "RangList";
            this.Text = "Rang lists";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.tabMatches.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPlayers;
        private System.Windows.Forms.TabPage tabMatches;
        private System.Windows.Forms.FlowLayoutPanel pnlMatches;
    }
}