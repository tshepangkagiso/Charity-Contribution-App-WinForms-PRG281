using System.Windows.Forms;
using System;

namespace Charity_Contribution_App_Winforms
{
    partial class LearnMoreForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuBack;
        private Label lblLearnMore;
        private TextBox txtLearnMore;
        private Button btnClose;
        private Panel sideMenuPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLearnMore = new System.Windows.Forms.Label();
            this.txtLearnMore = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Black;
            this.menuStrip.ForeColor = System.Drawing.Color.White;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1231, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(54, 24);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // lblLearnMore
            // 
            this.lblLearnMore.AutoSize = true;
            this.lblLearnMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblLearnMore.ForeColor = System.Drawing.Color.Black;
            this.lblLearnMore.Location = new System.Drawing.Point(588, 49);
            this.lblLearnMore.Name = "lblLearnMore";
            this.lblLearnMore.Size = new System.Drawing.Size(146, 29);
            this.lblLearnMore.TabIndex = 1;
            this.lblLearnMore.Text = "Learn More";
            // 
            // txtLearnMore
            // 
            this.txtLearnMore.Location = new System.Drawing.Point(266, 103);
            this.txtLearnMore.Multiline = true;
            this.txtLearnMore.Name = "txtLearnMore";
            this.txtLearnMore.ReadOnly = true;
            this.txtLearnMore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLearnMore.Size = new System.Drawing.Size(912, 476);
            this.txtLearnMore.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(593, 599);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(183, 46);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 28);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(200, 629);
            this.sideMenuPanel.TabIndex = 4;
            // 
            // LearnMoreForm
            // 
            this.ClientSize = new System.Drawing.Size(1231, 657);
            this.Controls.Add(this.lblLearnMore);
            this.Controls.Add(this.txtLearnMore);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.sideMenuPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "LearnMoreForm";
            this.Text = "Learn More";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}