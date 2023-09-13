namespace LOAS
{
    partial class IssueForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issueDataSet = new LOAS.IssueDataSet();
            this.issueTableAdapter = new LOAS.IssueDataSetTableAdapters.IssueTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.IssuePage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dgvCurrentIssue = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.comboCopyID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBookID = new System.Windows.Forms.ComboBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDataSet = new LOAS.BookDataSet();
            this.comboMemberID = new System.Windows.Forms.ComboBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberDataSet = new LOAS.MemberDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMarkReturn = new System.Windows.Forms.Button();
            this.dgvIssueList = new System.Windows.Forms.DataGridView();
            this.issuenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineTableAdapter1 = new LOAS.FineDataSetTableAdapters.FineTableAdapter();
            this.bookTableAdapter = new LOAS.BookDataSetTableAdapters.BookTableAdapter();
            this.memberTableAdapter = new LOAS.MemberDataSetTableAdapters.MemberTableAdapter();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.IssuePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentIssue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueList)).BeginInit();
            this.SuspendLayout();
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.DataMember = "Issue";
            this.issueBindingSource.DataSource = this.issueDataSet;
            // 
            // issueDataSet
            // 
            this.issueDataSet.DataSetName = "IssueDataSet";
            this.issueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issueTableAdapter
            // 
            this.issueTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Member ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Member Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(540, 142);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(395, 39);
            this.txtMemberName.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Book ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.IssuePage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(22, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 9);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 835);
            this.tabControl1.TabIndex = 49;
            // 
            // IssuePage
            // 
            this.IssuePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IssuePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IssuePage.Controls.Add(this.label7);
            this.IssuePage.Controls.Add(this.label6);
            this.IssuePage.Controls.Add(this.dtpReturnDate);
            this.IssuePage.Controls.Add(this.dgvCurrentIssue);
            this.IssuePage.Controls.Add(this.btnIssue);
            this.IssuePage.Controls.Add(this.btnDelete);
            this.IssuePage.Controls.Add(this.btnAdd);
            this.IssuePage.Controls.Add(this.txtBookName);
            this.IssuePage.Controls.Add(this.comboCopyID);
            this.IssuePage.Controls.Add(this.label5);
            this.IssuePage.Controls.Add(this.label4);
            this.IssuePage.Controls.Add(this.comboBookID);
            this.IssuePage.Controls.Add(this.comboMemberID);
            this.IssuePage.Controls.Add(this.label3);
            this.IssuePage.Controls.Add(this.label2);
            this.IssuePage.Controls.Add(this.txtMemberName);
            this.IssuePage.Controls.Add(this.label1);
            this.IssuePage.Location = new System.Drawing.Point(4, 42);
            this.IssuePage.Name = "IssuePage";
            this.IssuePage.Padding = new System.Windows.Forms.Padding(3);
            this.IssuePage.Size = new System.Drawing.Size(1013, 789);
            this.IssuePage.TabIndex = 0;
            this.IssuePage.Text = "Issue";
            this.IssuePage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 37);
            this.label7.TabIndex = 63;
            this.label7.Text = "Issue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 62;
            this.label6.Text = "Return Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnDate.Location = new System.Drawing.Point(540, 282);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(395, 39);
            this.dtpReturnDate.TabIndex = 61;
            this.dtpReturnDate.Value = new System.DateTime(2022, 11, 26, 22, 43, 23, 0);
            // 
            // dgvCurrentIssue
            // 
            this.dgvCurrentIssue.AllowUserToAddRows = false;
            this.dgvCurrentIssue.AllowUserToDeleteRows = false;
            this.dgvCurrentIssue.AllowUserToResizeColumns = false;
            this.dgvCurrentIssue.AllowUserToResizeRows = false;
            this.dgvCurrentIssue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurrentIssue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.dgvCurrentIssue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCurrentIssue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCurrentIssue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrentIssue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurrentIssue.ColumnHeadersHeight = 30;
            this.dgvCurrentIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCurrentIssue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.CopyID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurrentIssue.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurrentIssue.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCurrentIssue.Location = new System.Drawing.Point(90, 491);
            this.dgvCurrentIssue.Name = "dgvCurrentIssue";
            this.dgvCurrentIssue.RowHeadersVisible = false;
            this.dgvCurrentIssue.RowHeadersWidth = 62;
            this.dgvCurrentIssue.RowTemplate.Height = 30;
            this.dgvCurrentIssue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentIssue.ShowCellErrors = false;
            this.dgvCurrentIssue.ShowCellToolTips = false;
            this.dgvCurrentIssue.ShowEditingIcon = false;
            this.dgvCurrentIssue.ShowRowErrors = false;
            this.dgvCurrentIssue.Size = new System.Drawing.Size(849, 226);
            this.dgvCurrentIssue.TabIndex = 60;
            this.dgvCurrentIssue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentIssue_CellContentClick);
            // 
            // BookID
            // 
            this.BookID.HeaderText = "Book #";
            this.BookID.MinimumWidth = 8;
            this.BookID.Name = "BookID";
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Book";
            this.BookName.MinimumWidth = 8;
            this.BookName.Name = "BookName";
            // 
            // CopyID
            // 
            this.CopyID.HeaderText = "Copy #";
            this.CopyID.MinimumWidth = 8;
            this.CopyID.Name = "CopyID";
            // 
            // btnIssue
            // 
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssue.Location = new System.Drawing.Point(90, 421);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(848, 39);
            this.btnIssue.TabIndex = 59;
            this.btnIssue.Text = "Issue Books";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(540, 352);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(395, 38);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Remove Copy";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(90, 352);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(395, 38);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "Add Copy";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(540, 212);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(395, 39);
            this.txtBookName.TabIndex = 55;
            // 
            // comboCopyID
            // 
            this.comboCopyID.DisplayMember = "copy_id";
            this.comboCopyID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCopyID.FormattingEnabled = true;
            this.comboCopyID.Location = new System.Drawing.Point(90, 283);
            this.comboCopyID.Name = "comboCopyID";
            this.comboCopyID.Size = new System.Drawing.Size(393, 39);
            this.comboCopyID.TabIndex = 54;
            this.comboCopyID.ValueMember = "copy_id";
            this.comboCopyID.SelectedIndexChanged += new System.EventHandler(this.comboCopyID_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Copy ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(538, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Book Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBookID
            // 
            this.comboBookID.DataSource = this.bookBindingSource;
            this.comboBookID.DisplayMember = "isbn";
            this.comboBookID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBookID.FormattingEnabled = true;
            this.comboBookID.Location = new System.Drawing.Point(90, 212);
            this.comboBookID.MaxDropDownItems = 20;
            this.comboBookID.Name = "comboBookID";
            this.comboBookID.Size = new System.Drawing.Size(393, 39);
            this.comboBookID.TabIndex = 50;
            this.comboBookID.ValueMember = "isbn";
            this.comboBookID.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.bookDataSet;
            // 
            // bookDataSet
            // 
            this.bookDataSet.DataSetName = "BookDataSet";
            this.bookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboMemberID
            // 
            this.comboMemberID.DataSource = this.memberBindingSource;
            this.comboMemberID.DisplayMember = "member_id";
            this.comboMemberID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMemberID.FormattingEnabled = true;
            this.comboMemberID.Location = new System.Drawing.Point(90, 142);
            this.comboMemberID.Name = "comboMemberID";
            this.comboMemberID.Size = new System.Drawing.Size(393, 39);
            this.comboMemberID.TabIndex = 49;
            this.comboMemberID.ValueMember = "member_id";
            this.comboMemberID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.memberDataSet;
            // 
            // memberDataSet
            // 
            this.memberDataSet.DataSetName = "MemberDataSet";
            this.memberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnMarkReturn);
            this.tabPage2.Controls.Add(this.dgvIssueList);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1013, 789);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Issue List";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 37);
            this.label8.TabIndex = 64;
            this.label8.Text = "Issue List";
            // 
            // btnMarkReturn
            // 
            this.btnMarkReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnMarkReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarkReturn.Location = new System.Drawing.Point(70, 676);
            this.btnMarkReturn.Name = "btnMarkReturn";
            this.btnMarkReturn.Size = new System.Drawing.Size(873, 45);
            this.btnMarkReturn.TabIndex = 1;
            this.btnMarkReturn.Text = "Books Returned";
            this.btnMarkReturn.UseVisualStyleBackColor = false;
            this.btnMarkReturn.Click += new System.EventHandler(this.btnMarkReturn_Click);
            // 
            // dgvIssueList
            // 
            this.dgvIssueList.AllowUserToAddRows = false;
            this.dgvIssueList.AllowUserToDeleteRows = false;
            this.dgvIssueList.AllowUserToResizeColumns = false;
            this.dgvIssueList.AllowUserToResizeRows = false;
            this.dgvIssueList.AutoGenerateColumns = false;
            this.dgvIssueList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssueList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssueList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIssueList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssueList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issuenumberDataGridViewTextBoxColumn,
            this.issuedateDataGridViewTextBoxColumn,
            this.returndateDataGridViewTextBoxColumn,
            this.issuedbyDataGridViewTextBoxColumn});
            this.dgvIssueList.DataSource = this.issueBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssueList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIssueList.Location = new System.Drawing.Point(70, 154);
            this.dgvIssueList.Name = "dgvIssueList";
            this.dgvIssueList.RowHeadersVisible = false;
            this.dgvIssueList.RowHeadersWidth = 62;
            this.dgvIssueList.RowTemplate.Height = 28;
            this.dgvIssueList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssueList.Size = new System.Drawing.Size(873, 475);
            this.dgvIssueList.TabIndex = 0;
            this.dgvIssueList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssueList_CellContentClick);
            // 
            // issuenumberDataGridViewTextBoxColumn
            // 
            this.issuenumberDataGridViewTextBoxColumn.DataPropertyName = "issue_number";
            this.issuenumberDataGridViewTextBoxColumn.HeaderText = "Issue #";
            this.issuenumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.issuenumberDataGridViewTextBoxColumn.Name = "issuenumberDataGridViewTextBoxColumn";
            this.issuenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issuedateDataGridViewTextBoxColumn
            // 
            this.issuedateDataGridViewTextBoxColumn.DataPropertyName = "issue_date";
            this.issuedateDataGridViewTextBoxColumn.HeaderText = "Issue Date";
            this.issuedateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.issuedateDataGridViewTextBoxColumn.Name = "issuedateDataGridViewTextBoxColumn";
            // 
            // returndateDataGridViewTextBoxColumn
            // 
            this.returndateDataGridViewTextBoxColumn.DataPropertyName = "return_date";
            this.returndateDataGridViewTextBoxColumn.HeaderText = "Return Date";
            this.returndateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.returndateDataGridViewTextBoxColumn.Name = "returndateDataGridViewTextBoxColumn";
            // 
            // issuedbyDataGridViewTextBoxColumn
            // 
            this.issuedbyDataGridViewTextBoxColumn.DataPropertyName = "issued_by";
            this.issuedbyDataGridViewTextBoxColumn.HeaderText = "Issued To Member";
            this.issuedbyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.issuedbyDataGridViewTextBoxColumn.Name = "issuedbyDataGridViewTextBoxColumn";
            // 
            // fineTableAdapter1
            // 
            this.fineTableAdapter1.ClearBeforeFill = true;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // IssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 894);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueForm";
            this.Text = "IssueForm";
            this.Load += new System.EventHandler(this.IssueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.IssuePage.ResumeLayout(false);
            this.IssuePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentIssue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private IssueDataSet issueDataSet;
        private System.Windows.Forms.BindingSource issueBindingSource;
        private IssueDataSetTableAdapters.IssueTableAdapter issueTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage IssuePage;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.ComboBox comboCopyID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBookID;
        private System.Windows.Forms.ComboBox comboMemberID;
        private System.Windows.Forms.TabPage tabPage2;
        private FineDataSetTableAdapters.FineTableAdapter fineTableAdapter1;
        private BookDataSet bookDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private BookDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private MemberDataSet memberDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private MemberDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridView dgvCurrentIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopyID;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvIssueList;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMarkReturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}