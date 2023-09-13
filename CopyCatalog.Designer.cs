namespace LOAS
{
    partial class CopyCatalog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCopy = new System.Windows.Forms.DataGridView();
            this.CopyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.BookIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(731, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "Category";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Author";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Book Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "ISBN#";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(507, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(436, 38);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete Copy";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(51, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(436, 39);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add New Copy";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboCategory
            // 
            this.comboCategory.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(735, 177);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(208, 39);
            this.comboCategory.TabIndex = 32;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(279, 177);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(208, 39);
            this.txtBookName.TabIndex = 31;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(507, 177);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(208, 39);
            this.txtAuthorName.TabIndex = 30;
            this.txtAuthorName.TextChanged += new System.EventHandler(this.txtAuthorName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Copy Catalog";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvCopy
            // 
            this.dgvCopy.AllowUserToAddRows = false;
            this.dgvCopy.AllowUserToDeleteRows = false;
            this.dgvCopy.AllowUserToResizeColumns = false;
            this.dgvCopy.AllowUserToResizeRows = false;
            this.dgvCopy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCopy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCopy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CopyID,
            this.IssueStatus,
            this.BookID});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCopy.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCopy.Location = new System.Drawing.Point(51, 351);
            this.dgvCopy.Name = "dgvCopy";
            this.dgvCopy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCopy.RowHeadersVisible = false;
            this.dgvCopy.RowHeadersWidth = 62;
            this.dgvCopy.RowTemplate.Height = 28;
            this.dgvCopy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCopy.Size = new System.Drawing.Size(892, 170);
            this.dgvCopy.TabIndex = 27;
            this.dgvCopy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCopy_CellContentClick);
            // 
            // CopyID
            // 
            this.CopyID.HeaderText = "Copy No.";
            this.CopyID.MinimumWidth = 8;
            this.CopyID.Name = "CopyID";
            // 
            // IssueStatus
            // 
            this.IssueStatus.HeaderText = "Issue Status";
            this.IssueStatus.MinimumWidth = 8;
            this.IssueStatus.Name = "IssueStatus";
            // 
            // BookID
            // 
            this.BookID.HeaderText = "Book No.";
            this.BookID.MinimumWidth = 8;
            this.BookID.Name = "BookID";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(51, 177);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(208, 39);
            this.txtISBN.TabIndex = 29;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.AllowUserToAddRows = false;
            this.dgvCatalog.AllowUserToDeleteRows = false;
            this.dgvCatalog.AllowUserToResizeColumns = false;
            this.dgvCatalog.AllowUserToResizeRows = false;
            this.dgvCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookIsbn,
            this.BookTitle,
            this.BookAuthor,
            this.BookCategory});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalog.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCatalog.Location = new System.Drawing.Point(51, 555);
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCatalog.RowHeadersVisible = false;
            this.dgvCatalog.RowHeadersWidth = 62;
            this.dgvCatalog.RowTemplate.Height = 28;
            this.dgvCatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalog.Size = new System.Drawing.Size(892, 331);
            this.dgvCatalog.TabIndex = 46;
            this.dgvCatalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalog_CellContentClick);
            // 
            // BookIsbn
            // 
            this.BookIsbn.HeaderText = "ISBN";
            this.BookIsbn.MinimumWidth = 8;
            this.BookIsbn.Name = "BookIsbn";
            // 
            // BookTitle
            // 
            this.BookTitle.HeaderText = "Title";
            this.BookTitle.MinimumWidth = 8;
            this.BookTitle.Name = "BookTitle";
            // 
            // BookAuthor
            // 
            this.BookAuthor.HeaderText = "Author";
            this.BookAuthor.MinimumWidth = 8;
            this.BookAuthor.Name = "BookAuthor";
            // 
            // BookCategory
            // 
            this.BookCategory.HeaderText = "Category";
            this.BookCategory.MinimumWidth = 8;
            this.BookCategory.Name = "BookCategory";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 47);
            this.panel1.TabIndex = 47;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(937, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 31);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CopyCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(996, 928);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCatalog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CopyCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CopyCatalog";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCopy;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
    }
}