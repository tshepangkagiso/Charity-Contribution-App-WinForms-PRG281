using Charity_Contribution_App_Winforms.Classes;
using System;
using System.Windows.Forms;

namespace Charity_Contribution_App_Winforms
{
    public partial class RegistrationForm : Form
    {

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegUsername.Text;
            string password = txtRegPassword.Text;
            string confirmPassword = txtRegConfirmPassword.Text;
            decimal walletAmount;

            // Password confirmation check
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Wallet amount validation
            if (!decimal.TryParse(txtWallet.Text, out walletAmount))
            {
                MessageBox.Show("Please enter a valid wallet amount", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If registration is successful, create a new User object
            User RegisteredUser = new User
            {
                Username = username,
                Password = password,
                Wallet = walletAmount
            };

            User.ListOfUsers.Add(RegisteredUser);
            User.SaveUserData();
            User.LoadUserData();
            User userCheck = User.ListOfUsers.Find(x => x.Username == username && x.Password == password);

            if (userCheck != null)
            {
                MessageBox.Show($"Registration successful: {userCheck.Username}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration unsuccessful");
                this.Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
