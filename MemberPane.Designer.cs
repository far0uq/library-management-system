namespace LOAS
{
    partial class MemberPane
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberContact = new System.Windows.Forms.MaskedTextBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new LOAS.LibraryDataSet();
            this.memberTableAdapter = new LOAS.LibraryDataSetTableAdapters.MemberTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.memberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.memberDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberDataSet = new LOAS.MemberDataSet();
            this.memberTableAdapter1 = new LOAS.MemberDataSetTableAdapters.MemberTableAdapter();
            this.memberDataSet1 = new LOAS.MemberDataSet();
            this.memberBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membercontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Contact #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(238, 213);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(208, 39);
            this.txtMemberName.TabIndex = 40;
            // 
            // txtMemberContact
            // 
            this.txtMemberContact.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberContact.Location = new System.Drawing.Point(601, 213);
            this.txtMemberContact.Mask = "0000-0000000";
            this.txtMemberContact.Name = "txtMemberContact";
            this.txtMemberContact.Size = new System.Drawing.Size(208, 39);
            this.txtMemberContact.TabIndex = 44;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(784, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(212, 38);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete Member";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(69, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(212, 39);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Add Member";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(307, 314);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(212, 39);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Text = "Edit Member";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(545, 314);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(212, 39);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Update Member";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // memberBindingSource1
            // 
            this.memberBindingSource1.DataMember = "Member";
            this.memberBindingSource1.DataSource = this.memberDataSetBindingSource;
            // 
            // memberDataSetBindingSource
            // 
            this.memberDataSetBindingSource.DataSource = this.memberDataSet;
            this.memberDataSetBindingSource.Position = 0;
            // 
            // memberDataSet
            // 
            this.memberDataSet.DataSetName = "MemberDataSet";
            this.memberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // memberDataSet1
            // 
            this.memberDataSet1.DataSetName = "MemberDataSet";
            this.memberDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource2
            // 
            this.memberBindingSource2.DataMember = "Member";
            this.memberBindingSource2.DataSource = this.memberDataSet1;
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToAddRows = false;
            this.dgvMember.AllowUserToDeleteRows = false;
            this.dgvMember.AllowUserToResizeColumns = false;
            this.dgvMember.AllowUserToResizeRows = false;
            this.dgvMember.AutoGenerateColumns = false;
            this.dgvMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMember.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.membernameDataGridViewTextBoxColumn,
            this.membercontactDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dgvMember.DataSource = this.memberBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMember.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMember.Location = new System.Drawing.Point(69, 392);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersVisible = false;
            this.dgvMember.RowHeadersWidth = 120;
            this.dgvMember.RowTemplate.Height = 28;
            this.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMember.Size = new System.Drawing.Size(927, 430);
            this.dgvMember.TabIndex = 50;
            this.dgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellContentClick_2);
            // 
            // MemberID
            // 
            this.MemberID.DataPropertyName = "member_id";
            this.MemberID.HeaderText = "member_id";
            this.MemberID.MinimumWidth = 8;
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            this.MemberID.Visible = false;
            // 
            // membernameDataGridViewTextBoxColumn
            // 
            this.membernameDataGridViewTextBoxColumn.DataPropertyName = "member_name";
            this.membernameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.membernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.membernameDataGridViewTextBoxColumn.Name = "membernameDataGridViewTextBoxColumn";
            // 
            // membercontactDataGridViewTextBoxColumn
            // 
            this.membercontactDataGridViewTextBoxColumn.DataPropertyName = "member_contact";
            this.membercontactDataGridViewTextBoxColumn.HeaderText = "Contact #";
            this.membercontactDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.membercontactDataGridViewTextBoxColumn.Name = "membercontactDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "number_of_fines";
            this.dataGridViewTextBoxColumn1.HeaderText = "Number Of Fines";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 51;
            this.label1.Text = "Membership";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MemberPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1078, 894);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMemberContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemberName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberPane";
            this.Text = "MemberPane";
            this.Load += new System.EventHandler(this.MemberPane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.MaskedTextBox txtMemberContact;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private LibraryDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberoffinesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memberDataSetBindingSource;
        private MemberDataSet memberDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource1;
        private MemberDataSetTableAdapters.MemberTableAdapter memberTableAdapter1;
        private MemberDataSet memberDataSet1;
        private System.Windows.Forms.BindingSource memberBindingSource2;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn membernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membercontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}