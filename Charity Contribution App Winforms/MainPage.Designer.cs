using System;
using System.Windows.Forms;

namespace Charity_Contribution_App_Winforms
{
    partial class MainPage
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuViewAllCharities;
        private ToolStripMenuItem mnuSearchCharities;
        private ToolStripMenuItem mnuDonate;
        private ToolStripMenuItem mnuLearnMore;
        private ToolStripMenuItem mnuGiveFeedback;
        private ToolStripMenuItem mnuViewDonationHistory;
        private ToolStripMenuItem mnuExit;
        private Panel sideMenuPanel;
        private Label lblUserName;
        private Label lblWalletBalance;
        private DataGridView dgvCharities;
        private Button btnViewAllCharities;
        private Button btnSearchCharities;
        private Button btnDonate;
        private Button btnLearnMore;
        private Button btnGiveFeedback;
        private Button btnViewDonationHistory;
        private Button btnExit;

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
            this.mnuViewAllCharities = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchCharities = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLearnMore = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiveFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewDonationHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblWalletBalance = new System.Windows.Forms.Label();
            this.btnViewAllCharities = new System.Windows.Forms.Button();
            this.btnSearchCharities = new System.Windows.Forms.Button();
            this.btnDonate = new System.Windows.Forms.Button();
            this.btnLearnMore = new System.Windows.Forms.Button();
            this.btnGiveFeedback = new System.Windows.Forms.Button();
            this.btnViewDonationHistory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvCharities = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            this.sideMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharities)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Black;
            this.menuStrip.ForeColor = System.Drawing.Color.White;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewAllCharities,
            this.mnuSearchCharities,
            this.mnuDonate,
            this.mnuLearnMore,
            this.mnuGiveFeedback,
            this.mnuViewDonationHistory,
            this.mnuExit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1000, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // mnuViewAllCharities
            // 
            this.mnuViewAllCharities.Name = "mnuViewAllCharities";
            this.mnuViewAllCharities.Size = new System.Drawing.Size(138, 24);
            this.mnuViewAllCharities.Text = "View All Charities";
            this.mnuViewAllCharities.Click += new System.EventHandler(this.mnuViewAllCharities_Click);
            // 
            // mnuSearchCharities
            // 
            this.mnuSearchCharities.Name = "mnuSearchCharities";
            this.mnuSearchCharities.Size = new System.Drawing.Size(128, 24);
            this.mnuSearchCharities.Text = "Search Charities";
            this.mnuSearchCharities.Click += new System.EventHandler(this.mnuSearchCharities_Click);
            // 
            // mnuDonate
            // 
            this.mnuDonate.Name = "mnuDonate";
            this.mnuDonate.Size = new System.Drawing.Size(72, 24);
            this.mnuDonate.Text = "Donate";
            this.mnuDonate.Click += new System.EventHandler(this.mnuDonate_Click);
            // 
            // mnuLearnMore
            // 
            this.mnuLearnMore.Name = "mnuLearnMore";
            this.mnuLearnMore.Size = new System.Drawing.Size(98, 24);
            this.mnuLearnMore.Text = "Learn More";
            this.mnuLearnMore.Click += new System.EventHandler(this.mnuLearnMore_Click);
            // 
            // mnuGiveFeedback
            // 
            this.mnuGiveFeedback.Name = "mnuGiveFeedback";
            this.mnuGiveFeedback.Size = new System.Drawing.Size(119, 24);
            this.mnuGiveFeedback.Text = "Give Feedback";
            this.mnuGiveFeedback.Click += new System.EventHandler(this.mnuGiveFeedback_Click);
            // 
            // mnuViewDonationHistory
            // 
            this.mnuViewDonationHistory.Name = "mnuViewDonationHistory";
            this.mnuViewDonationHistory.Size = new System.Drawing.Size(172, 24);
            this.mnuViewDonationHistory.Text = "View Donation History";
            this.mnuViewDonationHistory.Click += new System.EventHandler(this.mnuViewDonationHistory_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sideMenuPanel.Controls.Add(this.lblUserName);
            this.sideMenuPanel.Controls.Add(this.lblWalletBalance);
            this.sideMenuPanel.Controls.Add(this.btnViewAllCharities);
            this.sideMenuPanel.Controls.Add(this.btnSearchCharities);
            this.sideMenuPanel.Controls.Add(this.btnDonate);
            this.sideMenuPanel.Controls.Add(this.btnLearnMore);
            this.sideMenuPanel.Controls.Add(this.btnGiveFeedback);
            this.sideMenuPanel.Controls.Add(this.btnViewDonationHistory);
            this.sideMenuPanel.Controls.Add(this.btnExit);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 28);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(200, 572);
            this.sideMenuPanel.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(0, 346);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Padding = new System.Windows.Forms.Padding(10);
            this.lblUserName.Size = new System.Drawing.Size(200, 47);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = $"Logged in as: user";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWalletBalance
            // 
            this.lblWalletBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWalletBalance.ForeColor = System.Drawing.Color.White;
            this.lblWalletBalance.Location = new System.Drawing.Point(0, 300);
            this.lblWalletBalance.Name = "lblWalletBalance";
            this.lblWalletBalance.Padding = new System.Windows.Forms.Padding(10);
            this.lblWalletBalance.Size = new System.Drawing.Size(200, 46);
            this.lblWalletBalance.TabIndex = 1;
            this.lblWalletBalance.Text = $"Wallet Balance: 0.00";
            this.lblWalletBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewAllCharities
            // 
            this.btnViewAllCharities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnViewAllCharities.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewAllCharities.FlatAppearance.BorderSize = 0;
            this.btnViewAllCharities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllCharities.ForeColor = System.Drawing.Color.White;
            this.btnViewAllCharities.Location = new System.Drawing.Point(0, 250);
            this.btnViewAllCharities.Name = "btnViewAllCharities";
            this.btnViewAllCharities.Size = new System.Drawing.Size(200, 50);
            this.btnViewAllCharities.TabIndex = 2;
            this.btnViewAllCharities.Text = "View All Charities";
            this.btnViewAllCharities.UseVisualStyleBackColor = false;
            this.btnViewAllCharities.Click += new System.EventHandler(this.SideMenuButton_Click);
            // 
            // btnSearchCharities
            // 
            this.btnSearchCharities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSearchCharities.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchCharities.FlatAppearance.BorderSize = 0;
            this.btnSearchCharities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCharities.ForeColor = System.Drawing.Color.White;
            this.btnSearchCharities.Location = new System.Drawing.Point(0, 200);
            this.btnSearchCharities.Name = "btnSearchCharities";
            this.btnSearchCharities.Size = new System.Drawing.Size(200, 50);
            this.btnSearchCharities.TabIndex = 3;
            this.btnSearchCharities.Text = "Search Charities";
            this.btnSearchCharities.UseVisualStyleBackColor = false;
            this.btnSearchCharities.Click += new System.EventHandler(this.SideMenuButton_Click);
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDonate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonate.FlatAppearance.BorderSize = 0;
            this.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonate.ForeColor = System.Drawing.Color.White;
            this.btnDonate.Location = new System.Drawing.Point(0, 150);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(200, 50);
            this.btnDonate.TabIndex = 4;
            this.btnDonate.Text = "Donate";
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.SideMenuButton_Click);
            // 
            // btnLearnMore
            // 
            this.btnLearnMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLearnMore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLearnMore.FlatAppearance.BorderSize = 0;
            this.btnLearnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearnMore.ForeColor = System.Drawing.Color.White;
            this.btnLearnMore.Location = new System.Drawing.Point(0, 100);
            this.btnLearnMore.Name = "btnLearnMore";
            this.btnLearnMore.Size = new System.Drawing.Size(200, 50);
            this.btnLearnMore.TabIndex = 5;
            this.btnLearnMore.Text = "Learn More";
            this.btnLearnMore.UseVisualStyleBackColor = false;
            this.btnLearnMore.Click += new System.EventHandler(this.SideMenuButton_Click);
            // 
            // btnGiveFeedback
            // 
            this.btnGiveFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnGiveFeedback.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiveFeedback.FlatAppearance.BorderSize = 0;
            this.btnGiveFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiveFeedback.ForeColor = System.Drawing.Color.White;
            this.btnGiveFeedback.Location = new System.Drawing.Point(0, 50);
            this.btnGiveFeedback.Name = "btnGiveFeedback";
            this.btnGiveFeedback.Size = new System.Drawing.Size(200, 50);
            this.btnGiveFeedback.TabIndex = 6;
            this.btnGiveFeedback.Text = "Give Feedback";
            this.btnGiveFeedback.UseVisualStyleBackColor = false;
            this.btnGiveFeedback.Click += new System.EventHandler(this.SideMenuButton_Click);
            // 
            // btnViewDonationHistory
            // 
            this.btnViewDonationHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnViewDonationHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewDonationHistory.FlatAppearance.BorderSize = 0;
            this.btnViewDonationHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDonationHistory.ForeColor = System.Drawing.Color.White;
            this.btnViewDonationHistory.Location = new System.Drawing.Point(0, 0);
            this.btnViewDonationHistory.Name = "btnViewDonationHistory";
            this.btnViewDonationHistory.Size = new System.Drawing.Size(200, 50);
            this.btnViewDonationHistory.TabIndex = 7;
            this.btnViewDonationHistory.Text = "View Donation History";
            this.btnViewDonationHistory.UseVisualStyleBackColor = false;
            this.btnViewDonationHistory.Click += new System.EventHandler(this.SideMenuButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 522);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // dgvCharities
            // 
            this.dgvCharities.BackgroundColor = System.Drawing.Color.White;
            this.dgvCharities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCharities.Location = new System.Drawing.Point(200, 28);
            this.dgvCharities.Name = "dgvCharities";
            this.dgvCharities.RowHeadersWidth = 51;
            this.dgvCharities.Size = new System.Drawing.Size(800, 572);
            this.dgvCharities.TabIndex = 1;
            // 
            // MainPage
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dgvCharities);
            this.Controls.Add(this.sideMenuPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainPage";
            this.Text = "Charity Contribution App";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.sideMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SideMenuButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                switch (clickedButton.Text)
                {
                    case "View All Charities":
                        mnuViewAllCharities_Click(sender, e);
                        break;
                    case "Search Charities":
                        mnuSearchCharities_Click(sender, e);
                        break;
                    case "Donate":
                        mnuDonate_Click(sender, e);
                        break;
                    case "Learn More":
                        mnuLearnMore_Click(sender, e);
                        break;
                    case "Give Feedback":
                        mnuGiveFeedback_Click(sender, e);
                        break;
                    case "View Donation History":
                        mnuViewDonationHistory_Click(sender, e);
                        break;
                }
            }
        }
    }
}