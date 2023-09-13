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
    public partial class Admin_Dashboard : Form
    {
        bool sidebar_Expands;

        bool reports_Collapse;

        bool members_Collapse;
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginPage loginpage = new LoginPage();

            loginpage.Show();

            this.Close();
        }

        private void sidebar_timer_Tick(object sender, EventArgs e)
        {
            if(sidebar_Expands)
            {
                sidebar_AdminDash.Width -= 10; 
                if(sidebar_AdminDash.Width == sidebar_AdminDash.MinimumSize.Width)
                {
                    sidebar_Expands = false;
                    sidebar_timer.Stop();
                }
            }

            else
            {
                sidebar_AdminDash.Width += 10;
                if(sidebar_AdminDash.Width == sidebar_AdminDash.MaximumSize.Width)
                {
                    sidebar_Expands = true;
                    sidebar_timer.Stop();
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            sidebar_timer.Start();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reports_timer_Tick(object sender, EventArgs e)
        {
            if(reports_Collapse)
            {
                reportsContainer.Height += 10;
                if (reportsContainer.Height == reportsContainer.MaximumSize.Height)
                {
                    reports_Collapse = false;
                    reports_timer.Stop();
                }
            }
            else
            {
                reportsContainer.Height -= 10;
                if(reportsContainer.Height == reportsContainer.MinimumSize.Height)
                {
                    reports_Collapse = true;
                    reports_timer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebar_timer.Start();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            reports_timer.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            members_timer.Start();
        }

        private void members_timer_Tick(object sender, EventArgs e)
        {
            if (members_Collapse)
            {
                LibrarianContainer.Height += 10;
                if (LibrarianContainer.Height == LibrarianContainer.MaximumSize.Height)
                {
                    members_Collapse = false;
                    members_timer.Stop();
                }
            }
            else
            {
                LibrarianContainer.Height -= 10;
                if (LibrarianContainer.Height == LibrarianContainer.MinimumSize.Height)
                {
                    members_Collapse = true;
                    members_timer.Stop();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadForm(new Reports());
        }

        private void btnMenu_MouseHover(object sender, EventArgs e)
        {
                            
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            /*txtName.Text = LoginPage.recby;*/
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadForm(Form form)
        {
            if(this.pnlAdminDash.Controls.Count > 0 )
            {
                this.pnlAdminDash.Controls.RemoveAt(0);
            }

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlAdminDash.Controls.Add(f);
            this.pnlAdminDash.Tag = f;
            f.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadForm(new registerLibrarian());
        }
    }
}
