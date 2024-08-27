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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Charity_Contribution_App_Winforms
{
    public partial class MainPage : Form
    {
        public User _currentUser;

        public MainPage(User user)
        {
            InitializeComponent();
            User.LoadUserData();
            _currentUser = user;
            LoadCharities();
            UpdateUserName();
            UpdateUserInfo(_currentUser.Username, _currentUser.Wallet);
        }

        public void ShowMainForm()
        {
            this.Show();
        }

        private void LoadCharities()
        {
            dgvCharities.DataSource = CharityManager.ListOfCharities;
        }

        private void UpdateUserName()
        {
            lblUserName.Text = $"Logged in as: {_currentUser.Username}";
        }
        public void UpdateUserInfo(string userName, decimal walletBalance)
        {
            lblUserName.Text = $"Logged in as: {userName}";
            User user = User.ListOfUsers.Find(x => x.Username == userName);

            lblWalletBalance.Text = $"Wallet Balance: ${user.Wallet:F2}";
        }

        private void mnuViewAllCharities_Click(object sender, EventArgs e)
        {
            LoadCharities(); 
        }

        private void mnuSearchCharities_Click(object sender, EventArgs e)
        {
            SearchCharityForm searchCharityForm = new SearchCharityForm(this);
            searchCharityForm.Show();
            this.Hide();
        }

        private void mnuDonate_Click(object sender, EventArgs e)
        {
            DonationsForm donationsForm = new DonationsForm(_currentUser,this);
            donationsForm.Show();
            this.Hide();
        }

        private void mnuLearnMore_Click(object sender, EventArgs e)
        {
            LearnMoreForm learnMoreForm = new LearnMoreForm(this);
            learnMoreForm.Show();
            this.Hide();

        }

        private void mnuGiveFeedback_Click(object sender, EventArgs e)
        {
            FeedbackForm feedbackForm = new FeedbackForm(this);
            feedbackForm.Show();
            this.Hide();
        }

        private void mnuViewDonationHistory_Click(object sender, EventArgs e)
        {
            DonationHistoryForm donationHistoryForm = new DonationHistoryForm(this);
            donationHistoryForm.Show();
            this.Hide();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
