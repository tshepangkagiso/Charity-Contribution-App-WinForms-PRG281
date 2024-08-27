using System.Windows.Forms;
using System;

namespace Charity_Contribution_App_Winforms
{
    partial class DonationHistoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvDonationHistory;
        private Button btnBack;

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
            this.dgvDonationHistory = new DataGridView();
            this.btnBack = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDonationHistory)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvDonationHistory
            // 
            this.dgvDonationHistory.AllowUserToAddRows = false;
            this.dgvDonationHistory.AllowUserToDeleteRows = false;
            this.dgvDonationHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonationHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonationHistory.Dock = DockStyle.Fill;
            this.dgvDonationHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvDonationHistory.Name = "dgvDonationHistory";
            this.dgvDonationHistory.ReadOnly = true;
            this.dgvDonationHistory.Size = new System.Drawing.Size(800, 450);
            this.dgvDonationHistory.TabIndex = 0;

            // 
            // btnBack
            // 
            this.btnBack.Dock = DockStyle.Bottom;
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnBack.Text = "Back";
            this.btnBack.Height = 50;
            this.btnBack.Click += new System.EventHandler(this.mnuBack_Click);

            // 
            // DonationHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDonationHistory);
            this.Controls.Add(this.btnBack);
            this.Name = "DonationHistoryForm";
            this.Text = "Donation History";

            ((System.ComponentModel.ISupportInitialize)(this.dgvDonationHistory)).EndInit();
            this.ResumeLayout(false);
        }
    }
}