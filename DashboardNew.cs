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
    public partial class DashboardNew : Form
    {
        public DashboardNew()
        {
            InitializeComponent();
            LoadForm(new Dashboard(this));
        }

        public DashboardNew(int i)
        {
            InitializeComponent();
            if (i == 1)
                LoadForm(new btnExit());
            else
                LoadForm(new MemberPane());
        }

        void LoadForm(object Form)
        {
            if(this.PnlMain.Controls.Count > 0)
            {  
                this.PnlMain.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PnlMain.Controls.Add(f);
            this.PnlMain.Tag = f;
            f.Show();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIssueForm_Click(object sender, EventArgs e)
        {
            LoadForm(new IssueForm());
        }

        public void btnCatalogForm_Click(object sender, EventArgs e)
        {
            LoadForm(new btnExit());
        }

        private void btnMembershipForm_Click(object sender, EventArgs e)
        {
            LoadForm(new MemberPane());
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            LoadForm(new FineDetail());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadForm(new Dashboard(this));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
