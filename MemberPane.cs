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
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using static LOAS.Controllers.MemberController;

namespace LOAS
{
    public partial class MemberPane : Form
    {
        public MemberPane()
        {
            InitializeComponent();
            FillGrid(ChangeType.None, Int64.MinValue);
            StartMemberTrigger();
        }

        private void MemberPane_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'memberDataSet1.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter1.Fill(this.memberDataSet1.Member);
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

        }
        Member member = new Member();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMemberName.Text == String.Empty)
                MessageBox.Show("Member Name is a required field.");

            else if (txtMemberContact.Text == String.Empty)
                MessageBox.Show("Member Contact already exists.");

            else if (txtMemberContact.Text.Length < 10)
                MessageBox.Show("Provide a ten digit phone number.");

            else
            {
                member.member_name = txtMemberName.Text.Trim();
                member.member_contact = txtMemberContact.Text.Trim();
                member.number_of_fines = 0;
                AddMember(member);
                FillGrid(ChangeType.None, Int64.MinValue);
                MessageBox.Show("Member Record Successfully Added!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMemberName.Enabled = true;
            txtMemberContact.Enabled = true;

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            member.member_name = txtMemberName.Text.Trim();
            member.member_contact = txtMemberContact.Text.Trim();
            UpdateMember(member);
            FillGrid(ChangeType.None, Int64.MinValue);
            MessageBox.Show("Member Record Successfully Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteMember(member);
            FillGrid(ChangeType.None, Int64.MinValue);
        }

        private void dgvMember_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int memberToFind = int.Parse(dgvMember.Rows[e.RowIndex].Cells["MemberID"].Value.ToString());

                using (var db = new LibraryEntities())
                {
                    member = db.Members.Where(x => x.member_id == memberToFind).First();
                }

                txtMemberContact.Text = member.member_contact.Replace("-", "");
                txtMemberName.Text = member.member_name;

                txtMemberContact.Enabled = false;
                txtMemberName.Enabled = false;
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        public class MemberTrigger
        {
            public int member_id { get; set; }
            public string member_name { get; set; }
            public string member_contact { get; set; }
            public int number_of_fines { get; set; }
            public virtual Fine Fines { get; set; }
            public virtual Issue Issues { get; set; }
        }

        private SqlTableDependency<MemberTrigger> _sqlTableDependency;
        private delegate void UiCallback(ChangeType pChangeType, Int64 Emp_SSN);

        private void StartMemberTrigger()
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void StopMemberTrigger()
        {
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
        }

        private void OnDatabaseEventChanged(object sender, RecordChangedEventArgs<MemberTrigger> e)
        {
            if (!IsHandleCreated)
                this.CreateControl();
            Invoke(new UiCallback(FillGrid), e.ChangeType, e.Entity.member_id);
        }

        private void FillGrid(ChangeType changetype, Int64 i)
        {
            this.memberTableAdapter1.Fill(this.memberDataSet1.Member);
        }
        private void RegisterForDatabaseEvents()
        {
            _sqlTableDependency = new SqlTableDependency<MemberTrigger>("Data source=DESKTOP-G1ENAU6;Initial Catalog=Library;Integrated Security=True", "Member");
            _sqlTableDependency.OnChanged += OnDatabaseEventChanged;
            _sqlTableDependency.Start();

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            RegisterForDatabaseEvents();
        }
    }
}
