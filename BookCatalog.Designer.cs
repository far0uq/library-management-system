namespace LOAS
{
    partial class btnExit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.BookIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnManageCopies = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCopyBooks = new System.Windows.Forms.DataGridView();
            this.BookIsbnCopy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitleCopy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAuthorCopy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCategoryCopy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteCopy = new System.Windows.Forms.Button();
            this.btnAddCopy = new System.Windows.Forms.Button();
            this.comboCategoryCopy = new System.Windows.Forms.ComboBox();
            this.txtBookNameCopy = new System.Windows.Forms.TextBox();
            this.txtAuthorNameCopy = new System.Windows.Forms.TextBox();
            this.txtISBNCopy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvCopy = new System.Windows.Forms.DataGridView();
            this.CopyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopyBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.AllowUserToAddRows = false;
            this.dgvCatalog.AllowUserToDeleteRows = false;
            this.dgvCatalog.AllowUserToResizeColumns = false;
            this.dgvCatalog.AllowUserToResizeRows = false;
            this.dgvCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookIsbn,
            this.BookTitle,
            this.BookAuthor,
            this.BookCategory});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalog.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatalog.Location = new System.Drawing.Point(30, 413);
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.RowHeadersVisible = false;
            this.dgvCatalog.RowHeadersWidth = 62;
            this.dgvCatalog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCatalog.RowTemplate.Height = 28;
            this.dgvCatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalog.Size = new System.Drawing.Size(973, 392);
            this.dgvCatalog.TabIndex = 2;
            this.dgvCatalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Catalog";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(30, 156);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(212, 39);
            this.txtISBN.TabIndex = 0;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(536, 154);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(212, 39);
            this.txtAuthorName.TabIndex = 2;
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(283, 156);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(212, 39);
            this.txtBookName.TabIndex = 1;
            // 
            // comboCategory
            // 
            this.comboCategory.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboCategory.Location = new System.Drawing.Point(789, 154);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(212, 39);
            this.comboCategory.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(283, 236);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(212, 38);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(536, 237);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(212, 39);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Location = new System.Drawing.Point(30, 237);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(212, 39);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(789, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(212, 38);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(30, 322);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(736, 39);
            this.txtSearch.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "ISBN#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Book Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(787, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Category";
            // 
            // btnManageCopies
            // 
            this.btnManageCopies.BackColor = System.Drawing.Color.Black;
            this.btnManageCopies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageCopies.ForeColor = System.Drawing.Color.White;
            this.btnManageCopies.Location = new System.Drawing.Point(791, 322);
            this.btnManageCopies.Name = "btnManageCopies";
            this.btnManageCopies.Size = new System.Drawing.Size(212, 38);
            this.btnManageCopies.TabIndex = 9;
            this.btnManageCopies.Text = "Manage Copies";
            this.btnManageCopies.UseVisualStyleBackColor = false;
            this.btnManageCopies.Click += new System.EventHandler(this.btnManageCopies_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LOAS.Properties.Resources.icons8_search_30;
            this.pictureBox2.Location = new System.Drawing.Point(738, 328);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1054, 870);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAuthorName);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.dgvCatalog);
            this.tabPage1.Controls.Add(this.btnManageCopies);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtISBN);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtBookName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboCategory);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnRegister);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1046, 837);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book Catalog";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCopyBooks);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnDeleteCopy);
            this.tabPage2.Controls.Add(this.btnAddCopy);
            this.tabPage2.Controls.Add(this.comboCategoryCopy);
            this.tabPage2.Controls.Add(this.txtBookNameCopy);
            this.tabPage2.Controls.Add(this.txtAuthorNameCopy);
            this.tabPage2.Controls.Add(this.txtISBNCopy);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dgvCopy);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1046, 837);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Copy Catalog";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dgvCopyBooks
            // 
            this.dgvCopyBooks.AllowUserToAddRows = false;
            this.dgvCopyBooks.AllowUserToDeleteRows = false;
            this.dgvCopyBooks.AllowUserToResizeColumns = false;
            this.dgvCopyBooks.AllowUserToResizeRows = false;
            this.dgvCopyBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCopyBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCopyBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCopyBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopyBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookIsbnCopy,
            this.BookTitleCopy,
            this.BookAuthorCopy,
            this.BookCategoryCopy});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCopyBooks.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCopyBooks.Location = new System.Drawing.Point(46, 518);
            this.dgvCopyBooks.Name = "dgvCopyBooks";
            this.dgvCopyBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCopyBooks.RowHeadersVisible = false;
            this.dgvCopyBooks.RowHeadersWidth = 62;
            this.dgvCopyBooks.RowTemplate.Height = 28;
            this.dgvCopyBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCopyBooks.Size = new System.Drawing.Size(949, 287);
            this.dgvCopyBooks.TabIndex = 59;
            this.dgvCopyBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // BookIsbnCopy
            // 
            this.BookIsbnCopy.HeaderText = "ISBN";
            this.BookIsbnCopy.MinimumWidth = 8;
            this.BookIsbnCopy.Name = "BookIsbnCopy";
            // 
            // BookTitleCopy
            // 
            this.BookTitleCopy.HeaderText = "Title";
            this.BookTitleCopy.MinimumWidth = 8;
            this.BookTitleCopy.Name = "BookTitleCopy";
            // 
            // BookAuthorCopy
            // 
            this.BookAuthorCopy.HeaderText = "Author";
            this.BookAuthorCopy.MinimumWidth = 8;
            this.BookAuthorCopy.Name = "BookAuthorCopy";
            // 
            // BookCategoryCopy
            // 
            this.BookCategoryCopy.HeaderText = "Category";
            this.BookCategoryCopy.MinimumWidth = 8;
            this.BookCategoryCopy.Name = "BookCategoryCopy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(783, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 58;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 57;
            this.label7.Text = "Author";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(289, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 56;
            this.label8.Text = "Book Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 55;
            this.label9.Text = "ISBN#";
            // 
            // btnDeleteCopy
            // 
            this.btnDeleteCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCopy.Location = new System.Drawing.Point(559, 220);
            this.btnDeleteCopy.Name = "btnDeleteCopy";
            this.btnDeleteCopy.Size = new System.Drawing.Size(436, 38);
            this.btnDeleteCopy.TabIndex = 54;
            this.btnDeleteCopy.Text = "Delete Copy";
            this.btnDeleteCopy.UseVisualStyleBackColor = true;
            this.btnDeleteCopy.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAddCopy
            // 
            this.btnAddCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCopy.Location = new System.Drawing.Point(46, 219);
            this.btnAddCopy.Name = "btnAddCopy";
            this.btnAddCopy.Size = new System.Drawing.Size(436, 39);
            this.btnAddCopy.TabIndex = 53;
            this.btnAddCopy.Text = "Add New Copy";
            this.btnAddCopy.UseVisualStyleBackColor = true;
            this.btnAddCopy.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // comboCategoryCopy
            // 
            this.comboCategoryCopy.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategoryCopy.FormattingEnabled = true;
            this.comboCategoryCopy.Location = new System.Drawing.Point(787, 140);
            this.comboCategoryCopy.Name = "comboCategoryCopy";
            this.comboCategoryCopy.Size = new System.Drawing.Size(208, 39);
            this.comboCategoryCopy.TabIndex = 52;
            // 
            // txtBookNameCopy
            // 
            this.txtBookNameCopy.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookNameCopy.Location = new System.Drawing.Point(293, 140);
            this.txtBookNameCopy.Name = "txtBookNameCopy";
            this.txtBookNameCopy.Size = new System.Drawing.Size(208, 39);
            this.txtBookNameCopy.TabIndex = 51;
            // 
            // txtAuthorNameCopy
            // 
            this.txtAuthorNameCopy.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorNameCopy.Location = new System.Drawing.Point(540, 140);
            this.txtAuthorNameCopy.Name = "txtAuthorNameCopy";
            this.txtAuthorNameCopy.Size = new System.Drawing.Size(208, 39);
            this.txtAuthorNameCopy.TabIndex = 50;
            // 
            // txtISBNCopy
            // 
            this.txtISBNCopy.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBNCopy.Location = new System.Drawing.Point(46, 140);
            this.txtISBNCopy.Name = "txtISBNCopy";
            this.txtISBNCopy.Size = new System.Drawing.Size(208, 39);
            this.txtISBNCopy.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 37);
            this.label10.TabIndex = 48;
            this.label10.Text = "Copy Catalog";
            // 
            // dgvCopy
            // 
            this.dgvCopy.AllowUserToAddRows = false;
            this.dgvCopy.AllowUserToDeleteRows = false;
            this.dgvCopy.AllowUserToResizeColumns = false;
            this.dgvCopy.AllowUserToResizeRows = false;
            this.dgvCopy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCopy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(153)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCopy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CopyID,
            this.IssueStatus,
            this.BookID});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCopy.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCopy.Location = new System.Drawing.Point(46, 314);
            this.dgvCopy.Name = "dgvCopy";
            this.dgvCopy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCopy.RowHeadersVisible = false;
            this.dgvCopy.RowHeadersWidth = 62;
            this.dgvCopy.RowTemplate.Height = 28;
            this.dgvCopy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCopy.Size = new System.Drawing.Size(949, 170);
            this.dgvCopy.TabIndex = 47;
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
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // btnExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1078, 894);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btnExit";
            this.Text = "BookCatalog";
            this.Load += new System.EventHandler(this.btnExit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopyBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnManageCopies;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCategory;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvCopyBooks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteCopy;
        private System.Windows.Forms.Button btnAddCopy;
        private System.Windows.Forms.ComboBox comboCategoryCopy;
        private System.Windows.Forms.TextBox txtBookNameCopy;
        private System.Windows.Forms.TextBox txtAuthorNameCopy;
        private System.Windows.Forms.TextBox txtISBNCopy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvCopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIsbnCopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitleCopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookAuthorCopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCategoryCopy;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}