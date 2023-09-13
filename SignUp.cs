using LOAS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LOAS.Models.Login;

namespace LOAS
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.username = txtUsername.Text.Trim();
            login.password = txtPassword.Text.Trim();
            login.name = txtName.Text.Trim();
            login.librarian_id = null;

            using(var db = new LibraryEntities())
            {
                db.Logins.Add(login);
                db.SaveChanges();
            }

            MessageBox.Show("User Successfully Created.");
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
        //Clear data after submit
        private void ClearData()
        {
            txtName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtRetypePass.Text = "";
            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            /*// TODO: This line of code loads data into the 'libraryManagementSystemDataSet.SignUp' table. You can move, or remove it, as needed.
            this.signUpTableAdapter.Fill(this.libraryManagementSystemDataSet.SignUp);
*/


        }

        private void txtRetypePass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Clear();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void txtRetypePass_Click(object sender, EventArgs e)
        {
            txtRetypePass.Clear();
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoginPage li = new LoginPage();
            li.Show();
            this.Close();
        }
    }
 }

