using LOAS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LOAS.Controller.LibrarianController;

namespace LOAS
{
    public partial class registerLibrarian : Form
    {
        public registerLibrarian()
        {
            InitializeComponent();
        }

        private void registerLibrarian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementSystemDataSet1.Librarian' table. You can move, or remove it, as needed.
            btnCreate.Enabled = true;
            btnEdit.Enabled = false;
            btnErase.Enabled = false;
            btnUpdate.Enabled = false;

        }

        private void dataGridView1_RowDividerHeightChanged(object sender, DataGridViewRowEventArgs e)
        {

        }

        Librarian librarian = new Librarian();

        Login login = new Login();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            librarian.librarian_name = txtLibName.Text.Trim();

            login.username = txtLibUsername.Text.Trim();

            login.password = txtLibPassword.Text.Trim();

            /*using (var db = new LibraryEntities())
            {
                db.Librarians.Add(librarian);
                login.librarian_id = librarian.librarian_id;
                db.Logins.Add(login);
                db.SaveChanges();
            }*/

            AddLibrarian(librarian);
            MessageBox.Show("Librarian Record Successfully Added!");

        }

        private void txtLibName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLibName_MouseClick(object sender, MouseEventArgs e)
        {
            txtLibName.Clear();
        }

        private void txtLibUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtLibUsername.Clear();
        }

        private void txtLibPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtLibPassword.Clear();
        }

        private void txtLibRetypePass_MouseClick(object sender, MouseEventArgs e)
        {
            txtLibRetypePass.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtLibName.Enabled = true;
            txtLibUsername.Enabled = true;
            txtLibPassword.Enabled = true;
            txtLibRetypePass.Enabled = true;

        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            DeleteLibrarian(librarian);
            MessageBox.Show("Librarian Deleted Successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            librarian.librarian_name = txtLibName.Text.Trim();
            login.username = txtLibUsername.Text.Trim();

        }
    }
}
