using LOAS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient;
using static LOAS.Controllers.CatalogController;
using static LOAS.Controllers.CopyController;
using static LOAS.FineDetail;

namespace LOAS
{
    public partial class btnExit : Form
    {
        public btnExit()
        {
            InitializeComponent();
        }

        Book book = new Book();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                    btnUpdate.Enabled = false;
                    btnRegister.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ClearData()
        {
            txtAuthorName.Text = string.Empty;
            txtISBN.Text = string.Empty;
            txtBookName.Text = string.Empty;
            comboCategory.SelectedIndex = 0;

            btnRegister.Enabled = true;
            btnEdit.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void setDataInGridView()
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            #region AddBookInfo
            if(txtISBN.Text == String.Empty)
                MessageBox.Show("ISBN is a required field.");

            else if(CheckISBN(txtISBN.Text))
                MessageBox.Show("ISBN already exists.");

            else if (txtBookName.Text == String.Empty)
                MessageBox.Show("Book Name is a required field.");

            else if (txtAuthorName.Text == String.Empty)
                MessageBox.Show("Äuthor Name is a required field.");

            else if(comboCategory.Text == String.Empty)
                MessageBox.Show("Category is a required field.");

            else
            {
                try
                {
                    book.isbn = int.Parse(txtISBN.Text.Trim());
                    book.book_name = txtBookName.Text.Trim();
                    book.book_category = int.Parse(comboCategory.SelectedItem.ToString());

                    // Registering the author object
                    Author auth = new Author();
                    auth.author_name = txtAuthorName.Text.Trim();

                    AddAuthor(auth);

                    using (var db = new LibraryEntities())
                    {
                        Author authorIDGet = new Author();
                        authorIDGet = db.Authors.Where(x => x.author_name == auth.author_name).FirstOrDefault();
                        auth.author_id = authorIDGet.author_id;
                    }

                    book.book_author = auth.author_id;

                    AddBook(book);

                    ClearData();
                    setDataInGridView();
                    MessageBox.Show("Book Successfully Registered!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
#endregion
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            #region EditBookInfo
            txtAuthorName.Enabled = false;
            txtBookName.Enabled = true;
            txtISBN.Enabled = true;
            comboCategory.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            txtSearch.Enabled = false;
            btnRegister.Enabled = false;
            btnEdit.Enabled = false;
            #endregion
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                book.isbn = int.Parse(txtISBN.Text.Trim());
                book.book_name = txtBookName.Text.Trim();
                book.book_category = int.Parse(comboCategory.SelectedItem.ToString());

                UpdateBook(book);
                
                ClearData();
                setDataInGridView();
                MessageBox.Show("Book Info Updated Successfully!");
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
                if (MessageBox.Show("Are you sure you want to delete this record? The corresponding copies shall also be deleted.", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteBook(book);
                    ClearData();
                    setDataInGridView();

                    MessageBox.Show("Record Deleted Successfully", "Deleted ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnManageCopies_Click(object sender, EventArgs e)
        {
            CopyCatalog CC = new CopyCatalog();
            CC.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        // for copy catalog


        Book bookForCopy = new Book();
        Copy copy = new Copy();

        private void ClearCopy()
        {
            txtAuthorNameCopy.Text = string.Empty;
            txtISBNCopy.Text = string.Empty;
            txtBookNameCopy.Text = string.Empty;
            comboCategoryCopy.SelectedItem = 0;

            btnAddCopy.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                copy.issue_status = false;
                copy.book_number = bookForCopy.isbn;

                AddCopy(copy);

                ClearCopy();
                setCopyDataInGridView();
                MessageBox.Show("Copy saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this copies record?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteCopy(copy);
                    ClearCopy();
                    setCopyDataInGridView();

                    MessageBox.Show("Copy Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCopy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int copyToFind;
                    copyToFind = int.Parse(dgvCopy.Rows[e.RowIndex].Cells["CopyID"].Value.ToString());
                    
                    using (var db = new LibraryEntities())
                    {
                        copy = db.Copies.Where(x => x.copy_id == copyToFind).First();
                    }


                    btnAddCopy.Enabled = false;
                    btnDeleteCopy.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int isbnToFind;
                    isbnToFind = int.Parse(dgvCopyBooks.Rows[e.RowIndex].Cells["BookIsbnCopy"].Value.ToString());

                    using (var db = new LibraryEntities())
                    {
                        bookForCopy = db.Books.Where(x => x.isbn == isbnToFind).First();
                    }

                    txtISBNCopy.Text = dgvCopyBooks.Rows[e.RowIndex].Cells["BookIsbnCopy"].Value.ToString();
                    txtBookNameCopy.Text = dgvCopyBooks.Rows[e.RowIndex].Cells["BookTitleCopy"].Value.ToString();
                    comboCategoryCopy.Text = dgvCopyBooks.Rows[e.RowIndex].Cells["BookCategoryCopy"].Value.ToString();
                    txtAuthorNameCopy.Text = dgvCopyBooks.Rows[e.RowIndex].Cells["BookAuthorCopy"].Value.ToString();

                    txtISBNCopy.Enabled = false;
                    txtBookNameCopy.Enabled = false;
                    comboCategoryCopy.Enabled = false;
                    txtAuthorNameCopy.Enabled = false;

                    btnAddCopy.Enabled = true;
                    btnDeleteCopy.Enabled = false;

                }
                setCopyDataInGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

            dgvCopyBooks.Rows.Clear();
            dgvCopyBooks.DataSource = null;
            foreach (var book in books)
            {
                int RowIndex = dgvCopyBooks.Rows.Add();

                dgvCopyBooks.Rows[RowIndex].Cells["BookIsbnCopy"].Value = book.isbn;
                dgvCopyBooks.Rows[RowIndex].Cells["BookTitleCopy"].Value = book.book_name;
                dgvCopyBooks.Rows[RowIndex].Cells["BookCategoryCopy"].Value = book.book_category;
                dgvCopyBooks.Rows[RowIndex].Cells["BookAuthorCopy"].Value = book.book_author;

            }
            dgvCopyBooks.Update();
            dgvCopyBooks.Refresh();
        }

        private void setCopyDataInGridView()
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
                if(copy.booknumber == bookForCopy.isbn)
                {
                    int RowIndex = dgvCopy.Rows.Add();

                    dgvCopy.Rows[RowIndex].Cells["CopyID"].Value = copy.copyid;
                    dgvCopy.Rows[RowIndex].Cells["BookID"].Value = copy.booknumber;
                    if (copy.issuestatus == true)
                        dgvCopy.Rows[RowIndex].Cells["IssueStatus"].Value = "Issued";
                    else
                        dgvCopy.Rows[RowIndex].Cells["IssueStatus"].Value = "Available";

                }
            }
            dgvCopy.Update();
            dgvCopy.Refresh();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            dgvCopy.Rows.Clear();
        }

        #region TableDependencyforBooks
        public class BookTrigger
        {
            public int isbn { get; set; }
            public string book_name { get; set; }
            public int number_of_copies { get; set; }
            public int book_category { get; set; }
            public int book_author { get; set; }

            public virtual Author Author { get; set; }
        }

        private SqlTableDependency<BookTrigger> _sqlTableDependency;
        private delegate void UiCallback(ChangeType pChangeType, Int64 Emp_SSN);

        private void StartBookTrigger()
        {
            if (!backgroundWorker2.IsBusy)
                backgroundWorker2.RunWorkerAsync();
        }
        private void StopBookTrigger()
        {
            if (backgroundWorker2.IsBusy)
                backgroundWorker2.CancelAsync();
        }

        private void OnDatabaseEventChanged(object sender, RecordChangedEventArgs<BookTrigger> e)
        {
            try
            {
                if (!IsHandleCreated)
                    this.CreateControl();
                Invoke(new UiCallback(FillGrid), e.ChangeType, e.Entity.isbn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "SQL Table Dependency Issue.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void FillGrid(ChangeType changetype, Int64 i)
        {
            setBooksInGridView();
            setDataInGridView();
        }
        private void RegisterForDatabaseEvents()
        {
            _sqlTableDependency = new SqlTableDependency<BookTrigger>("Data source=DESKTOP-G1ENAU6;Initial Catalog=Library;Integrated Security=True", "Book");
            _sqlTableDependency.OnChanged += OnDatabaseEventChanged;
            _sqlTableDependency.Start();

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        #endregion

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            RegisterForDatabaseEvents();
        }

        private void btnExit_Load(object sender, EventArgs e)
        {
            StartBookTrigger();
            FillGrid(ChangeType.None, Int64.MinValue);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int bookNameToDisplay = int.Parse(txtSearch.Text.Trim());

            using (var db = new LibraryEntities())
            {
                var books = (from book in db.Books
                            where book.isbn == bookNameToDisplay
                            join author in db.Authors

                            on book.book_author equals author.author_id

                            select new
                            {
                                isbn = book.isbn,
                                book_name = book.book_name,
                                book_category = book.book_category,
                                book_author = author.author_name,
                            }).ToList();

                if (books.Count != 0)
                {
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
                else
                {
                    MessageBox.Show("No ISBN Matched your search.");
                    setDataInGridView();
                }
            }
        }
    }
}
