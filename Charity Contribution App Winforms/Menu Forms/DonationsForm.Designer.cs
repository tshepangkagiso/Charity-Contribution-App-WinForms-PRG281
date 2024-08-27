using System.Windows.Forms;
using System;

namespace Charity_Contribution_App_Winforms
{
    partial class DonationsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbCharityNames;
        private System.Windows.Forms.TextBox txtDonationAmount;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUserWallet;
        private System.Windows.Forms.TextBox txtAddFunds;
        private System.Windows.Forms.Button btnAddFunds;

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
            this.cmbCharityNames = new System.Windows.Forms.ComboBox();
            this.txtDonationAmount = new System.Windows.Forms.TextBox();
            this.btnDonate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUserWallet = new System.Windows.Forms.Label();
            this.txtAddFunds = new System.Windows.Forms.TextBox();
            this.btnAddFunds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCharityNames
            // 
            this.cmbCharityNames.FormattingEnabled = true;
            this.cmbCharityNames.Location = new System.Drawing.Point(50, 50);
            this.cmbCharityNames.Name = "cmbCharityNames";
            this.cmbCharityNames.Size = new System.Drawing.Size(200, 21);
            this.cmbCharityNames.TabIndex = 0;
            // 
            // txtDonationAmount
            // 
            this.txtDonationAmount.Location = new System.Drawing.Point(50, 90);
            this.txtDonationAmount.Name = "txtDonationAmount";
            this.txtDonationAmount.Size = new System.Drawing.Size(200, 20);
            this.txtDonationAmount.TabIndex = 1;
            // 
            // btnDonate
            // 
            this.btnDonate.Location = new System.Drawing.Point(50, 130);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(90, 30);
            this.btnDonate.TabIndex = 2;
            this.btnDonate.Text = "Donate";
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(160, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUserWallet
            // 
            this.lblUserWallet.AutoSize = true;
            this.lblUserWallet.Location = new System.Drawing.Point(50, 180);
            this.lblUserWallet.Name = "lblUserWallet";
            this.lblUserWallet.Size = new System.Drawing.Size(80, 13);
            this.lblUserWallet.TabIndex = 4;
            this.lblUserWallet.Text = "Wallet: $0.00";
            // 
            // txtAddFunds
            // 
            this.txtAddFunds.Location = new System.Drawing.Point(50, 210);
            this.txtAddFunds.Name = "txtAddFunds";
            this.txtAddFunds.Size = new System.Drawing.Size(200, 20);
            this.txtAddFunds.TabIndex = 5;
            // 
            // btnAddFunds
            // 
            this.btnAddFunds.Location = new System.Drawing.Point(50, 240);
            this.btnAddFunds.Name = "btnAddFunds";
            this.btnAddFunds.Size = new System.Drawing.Size(90, 30);
            this.btnAddFunds.TabIndex = 6;
            this.btnAddFunds.Text = "Add Funds";
            this.btnAddFunds.UseVisualStyleBackColor = true;
            this.btnAddFunds.Click += new System.EventHandler(this.btnAddFunds_Click);
            // 
            // DonationsForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.cmbCharityNames);
            this.Controls.Add(this.txtDonationAmount);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblUserWallet);
            this.Controls.Add(this.txtAddFunds);
            this.Controls.Add(this.btnAddFunds);
            this.Name = "DonationsForm";
            this.Text = "Make a Donation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}