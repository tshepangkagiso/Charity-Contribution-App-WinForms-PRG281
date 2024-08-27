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
    public partial class SearchCharityForm : Form
    {
        private MainPage mainPage;

        public SearchCharityForm(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
            LoadCharityTypes();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            mainPage.ShowMainForm();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedType = cmbCharityTypes.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedType))
            {
                MessageBox.Show("Please select a charity type.");
                return;
            }

            List<SpecificCharity> filteredCharities = CharityManager.ListOfCharities
                .Where(c => c.CharityType.Equals(selectedType, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (filteredCharities.Any())
            {
                dgvSearchResults.DataSource = filteredCharities;
            }
            else
            {
                MessageBox.Show("No charities found for the selected type.");
                dgvSearchResults.DataSource = null;
            }
        }

        private void LoadCharityTypes()
        {
            // Populate the combo box with unique charity types
            var charityTypes = CharityManager.ListOfCharities
                .Select(c => c.CharityType)
                .Distinct()
                .OrderBy(type => type)
                .ToList();

            cmbCharityTypes.DataSource = charityTypes;
            cmbCharityTypes.SelectedIndex = 0; // Default to the first item
        }
    }
}
