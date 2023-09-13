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
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using static LOAS.Controllers.FineController;


namespace LOAS
{
    public partial class FineDetail : Form
    {
        public FineDetail()
        {
            InitializeComponent();
            FillGrid(ChangeType.None,Int64.MinValue);
            StartFineTrigger();
        }

        private void FineDetail_Load(object sender, EventArgs e)
        {
            btnFinePaid.Enabled = false;
            // TODO: This line of code loads data into the 'fineDataSet.Fine' table. You can move, or remove it, as needed.
            this.fineTableAdapter.Fill(this.fineDataSet.Fine);

        }
        Fine fine = new Fine();

        private void dgvFine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int fineToFind = int.Parse(dgvFine.Rows[e.RowIndex].Cells["FineNumber"].Value.ToString());

                using (var db = new LibraryEntities())
                {
                    fine = db.Fines.Where(x => x.fine_number == fineToFind).First();
                }

                btnFinePaid.Enabled = true;
            }
        }

        private void btnFinePaid_Click(object sender, EventArgs e)
        {
            DeleteFine(fine);
            MessageBox.Show("Fine is marked Paid.");
        }

    #region TableDependency
        public class FineTrigger
        {

            public int fine_number { get; set; }
            public System.DateTime fine_date { get; set; }
            public int fined_member { get; set; }
            public int fined_issue { get; set; }

            public virtual Issue Issue { get; set; }
            public virtual Member Member { get; set; }
        }

        private SqlTableDependency<FineTrigger> _sqlTableDependency;
        private delegate void UiCallback(ChangeType pChangeType, Int64 Emp_SSN);

        private void StartFineTrigger()
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void StopFineTrigger()
        {
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
        }

        private void OnDatabaseEventChanged(object sender, RecordChangedEventArgs<FineTrigger> e)
        {
            if (!IsHandleCreated)
                this.CreateControl();
            Invoke(new UiCallback(FillGrid), e.ChangeType, e.Entity.fine_number);
        }

        private void FillGrid(ChangeType changetype, Int64 i)
        {
            this.fineTableAdapter.Fill(this.fineDataSet.Fine);
        }
        private void RegisterForDatabaseEvents()
        {
            _sqlTableDependency = new SqlTableDependency<FineTrigger>("Data source=DESKTOP-G1ENAU6;Initial Catalog=Library;Integrated Security=True", "Fine");
            _sqlTableDependency.OnChanged += OnDatabaseEventChanged;
            _sqlTableDependency.Start();

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            RegisterForDatabaseEvents();
        }
        #endregion

    }
}
