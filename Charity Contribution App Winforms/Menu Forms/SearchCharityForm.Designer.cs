using System.Windows.Forms;
using System;

namespace Charity_Contribution_App_Winforms
{
    partial class SearchCharityForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuBack;
        private Label lblSearchCharity;
        private Label lblSearch;
        private ComboBox cmbCharityTypes;
        private Button btnSearch;
        private DataGridView dgvSearchResults;
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
            this.lblSearchCharity = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbCharityTypes = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(1201, 28);
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
            // lblSearchCharity
            // 
            this.lblSearchCharity.AutoSize = true;
            this.lblSearchCharity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblSearchCharity.ForeColor = System.Drawing.Color.Black;
            this.lblSearchCharity.Location = new System.Drawing.Point(530, 44);
            this.lblSearchCharity.Name = "lblSearchCharity";
            this.lblSearchCharity.Size = new System.Drawing.Size(221, 29);
            this.lblSearchCharity.TabIndex = 1;
            this.lblSearchCharity.Text = "Search for Charity";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(266, 153);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(127, 16);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Select Charity Type:";
            // 
            // cmbCharityTypes
            // 
            this.cmbCharityTypes.FormattingEnabled = true;
            this.cmbCharityTypes.Location = new System.Drawing.Point(463, 145);
            this.cmbCharityTypes.Name = "cmbCharityTypes";
            this.cmbCharityTypes.Size = new System.Drawing.Size(361, 24);
            this.cmbCharityTypes.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(943, 144);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new System.Drawing.Point(406, 212);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.RowHeadersWidth = 51;
            this.dgvSearchResults.Size = new System.Drawing.Size(507, 400);
            this.dgvSearchResults.TabIndex = 5;
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 28);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(200, 624);
            this.sideMenuPanel.TabIndex = 6;
            // 
            // SearchCharityForm
            // 
            this.ClientSize = new System.Drawing.Size(1201, 652);
            this.Controls.Add(this.lblSearchCharity);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cmbCharityTypes);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.sideMenuPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SearchCharityForm";
            this.Text = "Search for Charity";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}