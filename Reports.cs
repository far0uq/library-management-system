using LOAS.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOAS
{
    public partial class Reports : Form
    {
        
        public Reports()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_rp_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admindashboard = new Admin_Dashboard();

            admindashboard.Show();

            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            
        }

        private void sidebar_timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBookRecordView_Click(object sender, EventArgs e)
        {
            BookRecord bookrecord = new BookRecord();

            crystalReportViewer1.ReportSource = null;

            crystalReportViewer1.ReportSource = bookrecord;

            crystalReportViewer1.Update();

            crystalReportViewer1.RefreshReport();
        }

        private void btnBookRecordView_MouseEnter(object sender, EventArgs e)
        {
            string output = (" This report will show you all the data record of books in your library ");

            richTextBox_rp.Text = output;

        }

        private void btnBookRecordView_MouseLeave(object sender, EventArgs e)
        {
            richTextBox_rp.Clear();
        }

        private void btnBooksIssuedView_MouseEnter(object sender, EventArgs e)
        {
            string output = ("This report will show you all the issued books");

            richTextBox_rp.Text = output;
        }

        private void btnBooksIssuedView_MouseLeave(object sender, EventArgs e)
        {
            richTextBox_rp.Clear();
        }

        private void btnFineView_Click(object sender, EventArgs e)
        {
            Fines bookrecord = new Fines();

            crystalReportViewer1.ReportSource = null;

            crystalReportViewer1.ReportSource = bookrecord;

            crystalReportViewer1.Update();

            crystalReportViewer1.RefreshReport();
        }

        private void btnFineView_MouseEnter(object sender, EventArgs e)
        {
            string output = (" this report will show you the numbre of fines generated and their status");

            richTextBox_rp.Text = output;
        }

        private void btnFineView_MouseLeave(object sender, EventArgs e)
        {
            richTextBox_rp.Clear();
        }

        private void btnMembersView_MouseEnter(object sender, EventArgs e)
        {
            string output = (" This report will show you how many members are there ");

            richTextBox_rp.Text =  output;
        }

        private void btnMembersView_MouseLeave(object sender, EventArgs e)
        {
            richTextBox_rp.Clear();
        }

        private void btnMaxFines_MouseEnter(object sender, EventArgs e)
        {
            string output = (" this report will show you the maximum number of fines of members ");

            richTextBox_rp.Text = output;
        }

        private void btnMaxFines_MouseLeave(object sender, EventArgs e)
        {
            richTextBox_rp.Clear();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admindashboard = new Admin_Dashboard();

            admindashboard.Show();

            this.Hide();

            this.Close();
        }

        private void fillPanel()
        {

        }
        private void btnBooksIssuedView_Click(object sender, EventArgs e)
        {
            BooksIssued bookrecord = new BooksIssued();

            crystalReportViewer1.ReportSource = null;

            crystalReportViewer1.ReportSource = bookrecord;

            crystalReportViewer1.Update();

            crystalReportViewer1.RefreshReport();
        }

        private void btnMembersView_Click(object sender, EventArgs e)
        {
            MembersRecord bookrecord = new MembersRecord();

            crystalReportViewer1.ReportSource = null;

            crystalReportViewer1.ReportSource = bookrecord;

            crystalReportViewer1.Update();

            crystalReportViewer1.RefreshReport();
        }

        private void btnMaxFines_Click(object sender, EventArgs e)
        {
            MaxFine bookrecord = new MaxFine();

            crystalReportViewer1.ReportSource = null;

            crystalReportViewer1.ReportSource = bookrecord;

            crystalReportViewer1.Update();

            crystalReportViewer1.RefreshReport();
        }
    }
}
