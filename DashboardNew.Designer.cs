namespace LOAS
{
    partial class DashboardNew
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PnlSide = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMembershipForm = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCatalogForm = new System.Windows.Forms.Button();
            this.btnIssueForm = new System.Windows.Forms.Button();
            this.btnFines = new System.Windows.Forms.Button();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1084F));
            this.tableLayoutPanel1.Controls.Add(this.PnlSide, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PnlMain, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1364, 900);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PnlSide
            // 
            this.PnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.PnlSide.Controls.Add(this.button10);
            this.PnlSide.Controls.Add(this.label2);
            this.PnlSide.Controls.Add(this.btnMembershipForm);
            this.PnlSide.Controls.Add(this.btnHome);
            this.PnlSide.Controls.Add(this.btnCatalogForm);
            this.PnlSide.Controls.Add(this.btnIssueForm);
            this.PnlSide.Controls.Add(this.btnFines);
            this.PnlSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSide.Location = new System.Drawing.Point(3, 3);
            this.PnlSide.Name = "PnlSide";
            this.PnlSide.Size = new System.Drawing.Size(274, 894);
            this.PnlSide.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Image = global::LOAS.Properties.Resources.icons8_home_page_24;
            this.button10.Location = new System.Drawing.Point(63, 780);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(157, 76);
            this.button10.TabIndex = 40;
            this.button10.Text = "Log Out";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 37);
            this.label2.TabIndex = 35;
            this.label2.Text = "LOAS";
            // 
            // btnMembershipForm
            // 
            this.btnMembershipForm.FlatAppearance.BorderSize = 0;
            this.btnMembershipForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembershipForm.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembershipForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMembershipForm.Image = global::LOAS.Properties.Resources.icons8_add_male_user_group_24;
            this.btnMembershipForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembershipForm.Location = new System.Drawing.Point(63, 379);
            this.btnMembershipForm.Name = "btnMembershipForm";
            this.btnMembershipForm.Size = new System.Drawing.Size(157, 37);
            this.btnMembershipForm.TabIndex = 39;
            this.btnMembershipForm.Text = "      Membership";
            this.btnMembershipForm.UseVisualStyleBackColor = true;
            this.btnMembershipForm.Click += new System.EventHandler(this.btnMembershipForm_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Image = global::LOAS.Properties.Resources.icons8_home_page_24;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(63, 214);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(157, 37);
            this.btnHome.TabIndex = 34;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCatalogForm
            // 
            this.btnCatalogForm.FlatAppearance.BorderSize = 0;
            this.btnCatalogForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogForm.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCatalogForm.Image = global::LOAS.Properties.Resources.icons8_magazine_24;
            this.btnCatalogForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogForm.Location = new System.Drawing.Point(63, 324);
            this.btnCatalogForm.Name = "btnCatalogForm";
            this.btnCatalogForm.Size = new System.Drawing.Size(157, 37);
            this.btnCatalogForm.TabIndex = 37;
            this.btnCatalogForm.Text = "Catalog";
            this.btnCatalogForm.UseVisualStyleBackColor = true;
            this.btnCatalogForm.Click += new System.EventHandler(this.btnCatalogForm_Click);
            // 
            // btnIssueForm
            // 
            this.btnIssueForm.FlatAppearance.BorderSize = 0;
            this.btnIssueForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueForm.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIssueForm.Image = global::LOAS.Properties.Resources.icons8_book_and_pencil_24;
            this.btnIssueForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueForm.Location = new System.Drawing.Point(63, 269);
            this.btnIssueForm.Name = "btnIssueForm";
            this.btnIssueForm.Size = new System.Drawing.Size(157, 37);
            this.btnIssueForm.TabIndex = 36;
            this.btnIssueForm.Text = "Issue";
            this.btnIssueForm.UseVisualStyleBackColor = true;
            this.btnIssueForm.Click += new System.EventHandler(this.btnIssueForm_Click);
            // 
            // btnFines
            // 
            this.btnFines.FlatAppearance.BorderSize = 0;
            this.btnFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFines.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFines.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFines.Image = global::LOAS.Properties.Resources.icons8_dollar_coin_24;
            this.btnFines.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnFines.Location = new System.Drawing.Point(63, 434);
            this.btnFines.Name = "btnFines";
            this.btnFines.Size = new System.Drawing.Size(157, 37);
            this.btnFines.TabIndex = 38;
            this.btnFines.Text = "Fines";
            this.btnFines.UseVisualStyleBackColor = true;
            this.btnFines.Click += new System.EventHandler(this.btnFines_Click);
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(283, 3);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(1078, 894);
            this.PnlMain.TabIndex = 1;
            // 
            // DashboardNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 900);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardNew";
            this.Text = "DashboardNew";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PnlSide.ResumeLayout(false);
            this.PnlSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PnlSide;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMembershipForm;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCatalogForm;
        private System.Windows.Forms.Button btnIssueForm;
        private System.Windows.Forms.Button btnFines;
        private System.Windows.Forms.Panel PnlMain;
    }
}