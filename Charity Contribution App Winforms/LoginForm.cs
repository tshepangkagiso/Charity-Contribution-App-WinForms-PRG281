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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Classes.User.LoadUserData();
            Classes.CharityManager.LoadCharityData();
            Classes.DonationProcessing.LoadDonationData();
        }
        User user;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            //MessageBox.Show($"Input: username: {username} and password:{password}");
            user = User.ListOfUsers.Find(x => x.Username == username && x.Password == password);
            //MessageBox.Show($"Data: username: {user.Username} and password:{user.Password}");

            if (user != null)
            {
                MessageBox.Show($"Login successful, welcome: {user.Username}");
                MainPage mainForm = new MainPage(user);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {    
            this.Hide();
            // Open the registration form
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();

            // After registration, clear the fields and refocus on login
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }
}
