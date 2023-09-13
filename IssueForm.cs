using LOAS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static LOAS.Controllers.CopyController;
using static System.Drawing.Color;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient;

namespace LOAS
{
    public partial class IssueForm : Form
    {
        public IssueForm()
        {
            InitializeComponent();
            StartIssueTrigger();
            FillGrid(ChangeType.None,Int64.MinValue);
        }


        private void IssueForm_Load(object sender, EventArgs e)
        {
            comboMemberID.SelectedIndex = -1;
            comboCopyID.SelectedIndex = -1;
            comboBookID.SelectedIndex = -1;
            txtBookName.Enabled = false;
            txtMemberName.Enabled = false;
            comboBookID.Enabled = false;
            comboCopyID.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnIssue.Enabled = false;
            btnMarkReturn.Enabled = false;

            // TODO: This line of code loads data into the 'memberDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.memberDataSet.Member);
            // TODO: This line of code loads data into the 'bookDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.bookDataSet.Book);
            // TODO: This line of code loads data into the 'issueDataSet.Issue' table. You can move, or remove it, as needed.
            this.issueTableAdapter.Fill(this.issueDataSet.Issue);

        }
        static DataTable bookTable = new DataTable();
        static DataTable memberTable = new DataTable();


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string memberName;
            // i here refers to the variable in a for loop. you can do whatever you want before like using loop, fetch a specific row or create an array..etc but this is the way to get the data that you want

            memberTable = memberTableAdapter.GetData();
            memberName = (string)memberTable.Rows[comboMemberID.SelectedIndex].ItemArray[1];
            txtMemberName.Text = memberName;
            comboBookID.Enabled = true;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bookName;
            // i here refers to the variable in a for loop. you can do whatever you want before like using loop, fetch a specific row or create an array..etc but this is the way to get the data that you want

            bookTable = bookTableAdapter.GetData();
            bookName = (string)bookTable.Rows[comboBookID.SelectedIndex].ItemArray[1];
            txtBookName.Text = bookName;
            comboCopyID.Enabled = true;
            fillCopyCombo();
        }


        void fillCopyCombo()
        {
            #region FillCopyComboBox
            try
            {
                using (var db = new LibraryEntities())
                {
                    comboCopyID.Items.Clear();

                    int soughtBookID = int.Parse((bookTable.Rows[comboBookID.SelectedIndex].ItemArray[0]).ToString());

                    var copies = (from book in db.Books
                                  join copy in db.Copies
                                  on book.isbn equals copy.book_number
                                  where book.isbn == soughtBookID
                                  select new
                                  {
                                      copy.copy_id,
                                      copy.issued_in
                                  }
                    ).ToList();
                    foreach (var copy in copies)
                    {
                        if (copy.issued_in == null)
                        {
                            comboCopyID.Items.Add((copy.copy_id).ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.copyTableAdapter.FillBy(this.copyDataSet.Copy);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }

        Book book = new Book();
        Copy copy = new Copy();
        Member member = new Member();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            member.member_id = int.Parse(comboMemberID.SelectedValue.ToString());
            book.isbn = int.Parse(comboBookID.SelectedValue.ToString());
            book.book_name = txtBookName.Text;
            copy.copy_id = int.Parse(comboCopyID.GetItemText(comboCopyID.SelectedItem));

            if (CopyInGrid(copy.copy_id.ToString()) == false)
            {
                dgvCurrentIssue.Rows.Add(book.isbn, book.book_name, copy.copy_id);


                dgvCurrentIssue.Update();
                dgvCurrentIssue.Refresh();
            }
            else
                MessageBox.Show("Copy already in issued list.");
            btnIssue.Enabled = true;

        }

        static int currentCell;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvCurrentIssue.Rows.RemoveAt(currentCell);
        }

        private void comboCopyID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        //Sets comboCopyID's values
        private bool CopyInGrid(string copyIDToFind)
        {
            foreach (DataGridViewRow row in dgvCurrentIssue.Rows)
            {
                if (row.Cells[2].Value.ToString() == copyIDToFind)
                {
                    return true;
                }
            }
            return false;
        }

        private void dgvCurrentIssue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    currentCell = e.RowIndex;
                    int isbnToFind;
                    isbnToFind = int.Parse(dgvCurrentIssue.Rows[e.RowIndex].Cells["BookID"].Value.ToString());

                    using (var db = new LibraryEntities())
                    {
                        book = db.Books.Where(x => x.isbn == isbnToFind).First();
                    }


                    comboBookID.Text = dgvCurrentIssue.Rows[e.RowIndex].Cells["BookID"].Value.ToString();
                    txtBookName.Text = dgvCurrentIssue.Rows[e.RowIndex].Cells["BookName"].Value.ToString();
                    comboCopyID.Text = dgvCurrentIssue.Rows[e.RowIndex].Cells["CopyID"].Value.ToString();

                    comboBookID.Enabled = false;
                    txtBookName.Enabled = false;
                    comboCopyID.Enabled = false;

                    btnAdd.Enabled = false;
                    btnDelete.Enabled = true;
                    btnIssue.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            MakeIssue();
        }

        private void BindCopiesToIssue(Issue issue)
        {
            try
            {
                int copyWhoseDataToGet;
                foreach (DataGridViewRow row in dgvCurrentIssue.Rows)
                {
                    copyWhoseDataToGet = int.Parse(row.Cells[2].Value.ToString());
                    using (var db = new LibraryEntities())
                    {
                        copy = db.Copies.Where(x => x.copy_id == copyWhoseDataToGet).First();
                    }
                    copy.issue_status = true;
                    copy.issued_in = issue.issue_number;

                    UpdateCopy(copy);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void MakeIssue()
        {
            Issue issue = new Issue();
            issue.issue_date = DateTime.Today;

            issue.return_date = dtpReturnDate.Value.Date;
            issue.issued_by = member.member_id;

            try
            {
                using (var db = new LibraryEntities())
                {
                    db.Issues.Add(issue);
                    db.SaveChanges();
                    BindCopiesToIssue(issue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            ClearForm();
            MessageBox.Show("Issued Succesfully!");
        }

        private void ClearForm()
        {
            txtMemberName.Text = String.Empty;
            txtBookName.Text = String.Empty;
            comboMemberID.Text = String.Empty;
            comboBookID.Text = String.Empty;
            comboCopyID.Text = String.Empty;

            comboBookID.Enabled = false;
            comboCopyID.Enabled = false;

            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnIssue.Enabled = false;

            dgvCurrentIssue.Rows.Clear();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvIssueList.Rows)
            {
                if ((row.Cells[1].Value.ToString()) == (row.Cells[2].Value.ToString()))
                {
                    ColorConverter converter = new ColorConverter();
                    Color color = (Color)converter.ConvertFromString("#eab676");
                    row.DefaultCellStyle.BackColor = color;
                }
            }
        }

        //Highlight those records in IssueList due today.
        private void HighlightDueToday()
        {
            foreach (DataGridViewRow row in dgvIssueList.Rows)
            {
                if ((row.Cells[1].Value.ToString()) == (row.Cells[2].Value.ToString()))
                {
                    ColorConverter converter = new ColorConverter();
                    Color color = (Color)converter.ConvertFromString("#eab676");
                    row.DefaultCellStyle.BackColor = color;
                }
            }
        }

        static int storeCellValueForButton;
        private void dgvIssueList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnMarkReturn.Enabled = true;
            storeCellValueForButton = e.RowIndex;
        }

        private void btnMarkReturn_Click(object sender, EventArgs e)
        {
            //If it gives error on run, stop app and run again and try
            Issue issue = new Issue();
            int issueToFind = int.Parse(dgvIssueList.Rows[storeCellValueForButton].Cells[0].Value.ToString());

            using (var db = new LibraryEntities())
            {
                issue = db.Issues.Where(x => x.issue_number == issueToFind).First();
                foreach (Copy copy in db.Copies)
                {
                    if(issue.issue_number == copy.issued_in)
                    {
                        copy.issued_in = null;
                        copy.issue_status = false;
                    }
                }
                db.Issues.Remove(issue);
                db.SaveChanges();
                MessageBox.Show("Books Succesfully Returned!");
                this.issueTableAdapter.Fill(this.issueDataSet.Issue);
            }
        }

        #region tableDependency
        public class IssueTrigger
        {
            public int issue_number { get; set; }
            public System.DateTime issue_date { get; set; }
            public System.DateTime return_date { get; set; }
            public int issued_by { get; set; }
        }

        private SqlTableDependency<IssueTrigger> _sqlTableDependency;
        private delegate void UiCallback(ChangeType pChangeType, Int64 Emp_SSN);

        private void StartIssueTrigger()
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void StopIssueTrigger()
        {
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
        }

        private void OnDatabaseEventChanged(object sender, RecordChangedEventArgs<IssueTrigger> e)
        {
            if (!IsHandleCreated)
                this.CreateControl();
            Invoke(new UiCallback(FillGrid), e.ChangeType, e.Entity.issue_number);
        }

        private void FillGrid(ChangeType changetype, Int64 i)
        {
            
            this.issueTableAdapter.Fill(this.issueDataSet.Issue);
            HighlightDueToday();
        }
        private void RegisterForDatabaseEvents()
        {
            _sqlTableDependency = new SqlTableDependency<IssueTrigger>("Data source=DESKTOP-G1ENAU6;Initial Catalog=Library;Integrated Security=True", "Issue");
            _sqlTableDependency.OnChanged += OnDatabaseEventChanged;
            _sqlTableDependency.Start();

        }
        #endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            RegisterForDatabaseEvents();
        }
    }
}
