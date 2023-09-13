namespace LOAS
{
    partial class FineDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFine = new System.Windows.Forms.DataGridView();
            this.FineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finedmemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finedissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fineDataSet = new LOAS.FineDataSet();
            this.btnFinePaid = new System.Windows.Forms.Button();
            this.libraryDataSet = new LOAS.LibraryDataSet();
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fineTableAdapter = new LOAS.FineDataSetTableAdapters.FineTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fines";
            // 
            // dgvFine
            // 
            this.dgvFine.AllowUserToAddRows = false;
            this.dgvFine.AllowUserToDeleteRows = false;
            this.dgvFine.AllowUserToResizeColumns = false;
            this.dgvFine.AllowUserToResizeRows = false;
            this.dgvFine.AutoGenerateColumns = false;
            this.dgvFine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.dgvFine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FineNumber,
            this.finedateDataGridViewTextBoxColumn,
            this.finedmemberDataGridViewTextBoxColumn,
            this.finedissueDataGridViewTextBoxColumn});
            this.dgvFine.DataSource = this.fineBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFine.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.dgvFine.Location = new System.Drawing.Point(103, 227);
            this.dgvFine.Name = "dgvFine";
            this.dgvFine.RowHeadersVisible = false;
            this.dgvFine.RowHeadersWidth = 62;
            this.dgvFine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFine.RowTemplate.Height = 28;
            this.dgvFine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFine.ShowCellErrors = false;
            this.dgvFine.ShowCellToolTips = false;
            this.dgvFine.ShowEditingIcon = false;
            this.dgvFine.ShowRowErrors = false;
            this.dgvFine.Size = new System.Drawing.Size(798, 493);
            this.dgvFine.TabIndex = 12;
            this.dgvFine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFine_CellContentClick);
            // 
            // FineNumber
            // 
            this.FineNumber.DataPropertyName = "fine_number";
            this.FineNumber.HeaderText = "Fine Number";
            this.FineNumber.MinimumWidth = 8;
            this.FineNumber.Name = "FineNumber";
            this.FineNumber.ReadOnly = true;
            // 
            // finedateDataGridViewTextBoxColumn
            // 
            this.finedateDataGridViewTextBoxColumn.DataPropertyName = "fine_date";
            this.finedateDataGridViewTextBoxColumn.HeaderText = "Date Issued";
            this.finedateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.finedateDataGridViewTextBoxColumn.Name = "finedateDataGridViewTextBoxColumn";
            // 
            // finedmemberDataGridViewTextBoxColumn
            // 
            this.finedmemberDataGridViewTextBoxColumn.DataPropertyName = "fined_member";
            this.finedmemberDataGridViewTextBoxColumn.HeaderText = "Member Fined";
            this.finedmemberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.finedmemberDataGridViewTextBoxColumn.Name = "finedmemberDataGridViewTextBoxColumn";
            // 
            // finedissueDataGridViewTextBoxColumn
            // 
            this.finedissueDataGridViewTextBoxColumn.DataPropertyName = "fined_issue";
            this.finedissueDataGridViewTextBoxColumn.HeaderText = "Fined for Issue";
            this.finedissueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.finedissueDataGridViewTextBoxColumn.Name = "finedissueDataGridViewTextBoxColumn";
            // 
            // fineBindingSource
            // 
            this.fineBindingSource.DataMember = "Fine";
            this.fineBindingSource.DataSource = this.fineDataSet;
            // 
            // fineDataSet
            // 
            this.fineDataSet.DataSetName = "FineDataSet";
            this.fineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFinePaid
            // 
            this.btnFinePaid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinePaid.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinePaid.Location = new System.Drawing.Point(512, 752);
            this.btnFinePaid.Name = "btnFinePaid";
            this.btnFinePaid.Size = new System.Drawing.Size(389, 39);
            this.btnFinePaid.TabIndex = 47;
            this.btnFinePaid.Text = "Fine Paid";
            this.btnFinePaid.UseVisualStyleBackColor = true;
            this.btnFinePaid.Click += new System.EventHandler(this.btnFinePaid_Click);
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // fineTableAdapter
            // 
            this.fineTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(103, 752);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(377, 39);
            this.button6.TabIndex = 48;
            this.button6.Text = "Generate Fine Report";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // FineDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1012, 894);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnFinePaid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FineDetail";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FineDetail";
            this.Load += new System.EventHandler(this.FineDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFine;
        private System.Windows.Forms.Button btnFinePaid;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private FineDataSet fineDataSet;
        private System.Windows.Forms.BindingSource fineBindingSource;
        private FineDataSetTableAdapters.FineTableAdapter fineTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn FineNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn finedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finedmemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finedissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}