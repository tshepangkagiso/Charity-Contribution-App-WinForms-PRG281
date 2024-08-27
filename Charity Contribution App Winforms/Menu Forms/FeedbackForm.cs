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
    public partial class FeedbackForm : Form
    {
        private MainPage mainPage;
        public FeedbackForm(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            mainPage.ShowMainForm();
            this.Close();
        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            string feedback = txtFeedback.Text;
            //MessageBox.Show(feedback);
            MessageBox.Show("Thank you for your feedback. It will be processed indefinetly.");
            mainPage.ShowMainForm();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainPage.ShowMainForm();
            this.Close();
        }
    }
}
