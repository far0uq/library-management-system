using LOAS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LOAS.Controllers.CopyController;

namespace LOAS
{
    public partial class CopyCatalog : Form
    {
        public CopyCatalog()
        {
            InitializeComponent();
            setBooksInGridView();
            setDataInGridView();
        }

        Book book = new Book();
        Copy copy = new Copy();

        private void Clear()
        {
            txtAuthorName.Text = string.Empty;
            txtISBN.Text = string.Empty;
            txtBookName.Text = string.Empty;
            comboCategory.SelectedItem = 0;

            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
        }
        private void setDataInGridView()
        {
            var db = new LibraryEntities();
            var copies = (from book in db.Books
                         join copy in db.Copies

                         on book.isbn equals copy.book_number

                         select new
                         {
                             copyid = copy.copy_id,
                             issuestatus = copy.issue_status,
                             booknumber = copy.book_number,

                         }).ToList();

            dgvCopy.Rows.Clear();
            dgvCopy.DataSource = null;
            foreach (var copy in copies)
            {
                int RowIndex = dgvCopy.Rows.Add();

                dgvCopy.Rows[RowIndex].Cells["CopyID"].Value = copy.copyid;
                dgvCopy.Rows[RowIndex].Cells["BookID"].Value = copy.booknumber;
                if (copy.issuestatus == true)
                    dgvCopy.Rows[RowIndex].Cells["IssueStatus"].Value = "Issued";
                else
                    dgvCopy.Rows[RowIndex].Cells["IssueStatus"].Value = "Available";

            }
            dgvCopy.Update();
            dgvCopy.Refresh();
        }
        private void dgvCopy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int isbnToFind;
                    isbnToFind = int.Parse(dgvCopy.Rows[e.RowIndex].Cells["BookID"].Value.ToString());

                    using (var db = new LibraryEntities())
                    {
                        book = db.Books.Where(x => x.isbn == isbnToFind).First();
                    }

                    txtISBN.Text = book.isbn.ToString();
                    txtBookName.Text = book.book_name;
                    comboCategory.Text = book.book_category.ToString();
                    txtAuthorName.Text = book.book_author.ToString();

                    txtISBN.Enabled = false;
                    txtBookName.Enabled = false;
                    comboCategory.Enabled = false;
                    txtAuthorName.Enabled = false;

                    btnAdd.Enabled = false;
                    btnDelete.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                copy.issue_status = false;
                copy.book_number = book.isbn;

                AddCopy(copy);

                Clear();
                setDataInGridView();
                MessageBox.Show("Copy saved successfully.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this copies record?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteCopy(copy);
                    Clear();
                    setDataInGridView();

                    MessageBox.Show("Copy Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            btnExit bookCatalog = new btnExit();
            Hide();
            bookCatalog.ShowDialog();
            Close();
        }

        private void setBooksInGridView()
        {
            var db = new LibraryEntities();
            var books = (from book in db.Books
                         join author in db.Authors

                         on book.book_author equals author.author_id

                         select new
                         {
                             isbn = book.isbn,
                             book_name = book.book_name,
                             book_category = book.book_category,
                             book_author = author.author_name,
                         }).ToList();

            dgvCatalog.Rows.Clear();
            dgvCatalog.DataSource = null;
            foreach (var book in books)
            {
                int RowIndex = dgvCatalog.Rows.Add();

                dgvCatalog.Rows[RowIndex].Cells["BookIsbn"].Value = book.isbn;
                dgvCatalog.Rows[RowIndex].Cells["BookTitle"].Value = book.book_name;
                dgvCatalog.Rows[RowIndex].Cells["BookCategory"].Value = book.book_category;
                dgvCatalog.Rows[RowIndex].Cells["BookAuthor"].Value = book.book_author;

            }
            dgvCatalog.Update();
            dgvCatalog.Refresh();
        }

        private void dgvCatalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int isbnToFind;
                    isbnToFind = int.Parse(dgvCatalog.Rows[e.RowIndex].Cells["BookIsbn"].Value.ToString());

                    using (var db = new LibraryEntities())
                    {
                        book = db.Books.Where(x => x.isbn == isbnToFind).First();
                    }

                    txtISBN.Text = dgvCatalog.Rows[e.RowIndex].Cells["BookIsbn"].Value.ToString();
                    txtBookName.Text = dgvCatalog.Rows[e.RowIndex].Cells["BookTitle"].Value.ToString();
                    comboCategory.Text = dgvCatalog.Rows[e.RowIndex].Cells["BookCategory"].Value.ToString();
                    txtAuthorName.Text = dgvCatalog.Rows[e.RowIndex].Cells["BookAuthor"].Value.ToString();

                    txtISBN.Enabled = false;
                    txtBookName.Enabled = false;
                    comboCategory.Enabled = false;
                    txtAuthorName.Enabled = false;

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnExit BC = new btnExit();
            BC.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAuthorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
