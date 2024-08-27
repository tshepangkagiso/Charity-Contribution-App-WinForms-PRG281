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
    public partial class DonationHistoryForm : Form
    {
        private MainPage _mainPage;

        public DonationHistoryForm(MainPage mainPage)
        {
            InitializeComponent();
            _mainPage = mainPage;
            LoadDonationHistory();
        }

        private void LoadDonationHistory()
        {
            // Bind the ListOfDonations to the DataGridView
            dgvDonationHistory.DataSource = DonationProcessing.ListOfDonations.Select(d => new
            {
                CharityName = d.CharityName,
                Username = d.Username,
                DonatedFunds = d.DonatedFunds,
                DateOfDonation = d.DateOfDonation
            }).ToList();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            _mainPage.Show();
            this.Close();
        }
    }
}
