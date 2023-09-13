using System;
using LOAS.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LOAS
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        Login login = new Login();

        public static string urname;

        public static string recby
        {
            get{ return urname; }
            set { urname = value; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5MJR171;Initial Catalog=libraryManagementSystem;Integrated Security=True");
             SqlCommand cmd = new SqlCommand("select * from User_Info where username=@username and password =@password and usertype = @usertype" , con);
             cmd.Parameters.AddWithValue("@username", txtUsername.Text);
             cmd.Parameters.AddWithValue("@password", txtPassword.Text);
             SqlDataAdapter sda = new SqlDataAdapter(cmd);

             DataTable dt = new DataTable();
             sda.Fill(dt);
             con.Open();
             int i = cmd.ExecuteNonQuery();
             con.Close();

             if (dt.Rows.Count > 0)
             {
                 if("@usertype" == ("Admin"))
                 {
                     Admin_Dashboard admindash = new Admin_Dashboard();
                     admindash.Show();

                     this.Close();

                 }
                 else
                 {
                     Dashboard dashboard = new Dashboard();
                     dashboard.Show();
                 }




             }

             else
             {

                 MessageBox.Show("Please enter Correct Username and Password");
             }

             this.Hide();

         }*/




            if (txtUsername.Text.Trim() == String.Empty)
                MessageBox.Show("Must Enter a Username");
            else if(txtPassword.Text.Trim() == String.Empty)
                MessageBox.Show("Must Enter a Password");
            else
            {
                HashCode hc = new HashCode();

                using (var db = new LibraryEntities())
                {
                    login = db.Logins.Where(x => x.username == txtUsername.Text.Trim()).FirstOrDefault();
                }
                if (login == null)
                {
                    MessageBox.Show("Incorrect Username");
                }
                else
                {
                    if (login.librarian_id == null)
                    {
                        MessageBox.Show(txtPassword.Text.Trim());
                        MessageBox.Show(login.password.Trim());
                        if (txtPassword.Text.Trim() == login.password.Trim())
                        {
                            Admin_Dashboard admindash = new Admin_Dashboard();

                            admindash.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Please type correct Password");
                        }
                    }
                    else
                    {
                        if (txtPassword.Text.Trim() == login.password.Trim())
                        {
                            DashboardNew dash = new DashboardNew();

                            dash.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Please type correct Password");
                        }

                    }
                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCloseLoginPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
            this.Hide();
        }
    }
}
