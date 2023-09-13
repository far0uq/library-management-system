namespace LOAS
{
    partial class registerLibrarian
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
            this.dgvLibrarian = new System.Windows.Forms.DataGridView();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.librarianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarianidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librariannameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLibRetypePass = new System.Windows.Forms.TextBox();
            this.txtLibName = new System.Windows.Forms.TextBox();
            this.txtLibPassword = new System.Windows.Forms.TextBox();
            this.txtLibUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrarian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibrarian
            // 
            this.dgvLibrarian.AllowUserToAddRows = false;
            this.dgvLibrarian.AllowUserToDeleteRows = false;
            this.dgvLibrarian.AllowUserToResizeColumns = false;
            this.dgvLibrarian.AllowUserToResizeRows = false;
            this.dgvLibrarian.AutoGenerateColumns = false;
            this.dgvLibrarian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibrarian.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvLibrarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLibrarian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.librarianidDataGridViewTextBoxColumn,
            this.librariannameDataGridViewTextBoxColumn});
            this.dgvLibrarian.DataSource = this.librarianBindingSource;
            this.dgvLibrarian.Location = new System.Drawing.Point(265, 75);
            this.dgvLibrarian.Name = "dgvLibrarian";
            this.dgvLibrarian.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLibrarian.RowHeadersVisible = false;
            this.dgvLibrarian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibrarian.Size = new System.Drawing.Size(651, 342);
            this.dgvLibrarian.TabIndex = 0;
            this.dgvLibrarian.RowDividerHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_RowDividerHeightChanged);
            // 
            // btnErase
            // 
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErase.Location = new System.Drawing.Point(778, 432);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(146, 42);
            this.btnErase.TabIndex = 14;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(436, 432);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(146, 42);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(607, 432);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 42);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(265, 432);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(146, 42);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
           
            // librarianidDataGridViewTextBoxColumn
            // 
            this.librarianidDataGridViewTextBoxColumn.DataPropertyName = "librarian_id";
            this.librarianidDataGridViewTextBoxColumn.HeaderText = "librarian_id";
            this.librarianidDataGridViewTextBoxColumn.Name = "librarianidDataGridViewTextBoxColumn";
            this.librarianidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // librariannameDataGridViewTextBoxColumn
            // 
            this.librariannameDataGridViewTextBoxColumn.DataPropertyName = "librarian_name";
            this.librariannameDataGridViewTextBoxColumn.HeaderText = "librarian_name";
            this.librariannameDataGridViewTextBoxColumn.Name = "librariannameDataGridViewTextBoxColumn";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(21, 298);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 3);
            this.panel4.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(21, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 3);
            this.panel3.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(21, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 3);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(21, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 3);
            this.panel1.TabIndex = 20;
            // 
            // txtLibRetypePass
            // 
            this.txtLibRetypePass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLibRetypePass.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibRetypePass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLibRetypePass.Location = new System.Drawing.Point(21, 268);
            this.txtLibRetypePass.Margin = new System.Windows.Forms.Padding(2);
            this.txtLibRetypePass.Name = "txtLibRetypePass";
            this.txtLibRetypePass.Size = new System.Drawing.Size(189, 28);
            this.txtLibRetypePass.TabIndex = 18;
            this.txtLibRetypePass.Text = "Retype Password";
            this.txtLibRetypePass.UseSystemPasswordChar = true;
            this.txtLibRetypePass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLibRetypePass_MouseClick);
            // 
            // txtLibName
            // 
            this.txtLibName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLibName.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLibName.Location = new System.Drawing.Point(21, 79);
            this.txtLibName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLibName.Name = "txtLibName";
            this.txtLibName.Size = new System.Drawing.Size(189, 28);
            this.txtLibName.TabIndex = 15;
            this.txtLibName.Text = "Name";
            this.txtLibName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLibName_MouseClick);
            this.txtLibName.TextChanged += new System.EventHandler(this.txtLibName_TextChanged);
            // 
            // txtLibPassword
            // 
            this.txtLibPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLibPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLibPassword.Location = new System.Drawing.Point(21, 205);
            this.txtLibPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtLibPassword.Name = "txtLibPassword";
            this.txtLibPassword.Size = new System.Drawing.Size(189, 28);
            this.txtLibPassword.TabIndex = 17;
            this.txtLibPassword.Text = "Password";
            this.txtLibPassword.UseSystemPasswordChar = true;
            this.txtLibPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLibPassword_MouseClick);
            // 
            // txtLibUsername
            // 
            this.txtLibUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLibUsername.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibUsername.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLibUsername.Location = new System.Drawing.Point(21, 142);
            this.txtLibUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtLibUsername.Name = "txtLibUsername";
            this.txtLibUsername.Size = new System.Drawing.Size(189, 28);
            this.txtLibUsername.TabIndex = 16;
            this.txtLibUsername.Text = "Username";
            this.txtLibUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLibUsername_MouseClick);
            // 
            // registerLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 486);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLibRetypePass);
            this.Controls.Add(this.txtLibName);
            this.Controls.Add(this.txtLibPassword);
            this.Controls.Add(this.txtLibUsername);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvLibrarian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registerLibrarian";
            this.Text = "registerLibrarian";
            this.Load += new System.EventHandler(this.registerLibrarian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrarian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarianBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibrarian;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.BindingSource librarianBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarianidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn librariannameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLibRetypePass;
        private System.Windows.Forms.TextBox txtLibName;
        private System.Windows.Forms.TextBox txtLibPassword;
        private System.Windows.Forms.TextBox txtLibUsername;
    }
}