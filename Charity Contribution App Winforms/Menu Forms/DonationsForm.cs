using Charity_Contribution_App_Winforms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charity_Contribution_App_Winforms
{
    public partial class DonationsForm : Form
    {
        private MainPage mainPage;
        private User _currentUser;

        public DonationsForm(User currentUser, MainPage mainPage)
        {
            InitializeComponent();
            _currentUser = currentUser;
            this.mainPage = mainPage;
            LoadCharityNames();
            UpdateUserWalletDisplay();
        }

        private void LoadCharityNames()
        {
            // Populate the combo box with charity names
            foreach (var charity in CharityManager.ListOfCharities)
            {
                cmbCharityNames.Items.Add(charity.Name);
            }

            cmbCharityNames.SelectedIndex = 0; // Default to first item
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            string selectedCharity = cmbCharityNames.SelectedItem.ToString();
            if (decimal.TryParse(txtDonationAmount.Text, out decimal amount))
            {
                DonationProcessing.Donation(selectedCharity, amount, _currentUser);
           
                mainPage.ShowMainForm();
                mainPage.Refresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid donation amount.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainPage.ShowMainForm();
            mainPage.Refresh();
            this.Close();
        }

        private void btnAddFunds_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAddFunds.Text, out decimal additionalFunds))
            {
                _currentUser.Wallet += additionalFunds;
                User.SaveUserData();
                User.LoadUserData();
                MessageBox.Show($"Successfully added {additionalFunds:C} to your wallet.");
                UpdateUserWalletDisplay();

                mainPage.ShowMainForm();
                mainPage.Refresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount to add.");
            }
        }

        private void UpdateUserWalletDisplay()
        {
            lblUserWallet.Text = $"Wallet: {_currentUser.Wallet:C}";
        }
    }
}
