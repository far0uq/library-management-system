namespace LOAS
{
    partial class Reports
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBookRecordView = new System.Windows.Forms.Button();
            this.btnBooksIssuedView = new System.Windows.Forms.Button();
            this.btnFineView = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_rp = new System.Windows.Forms.RichTextBox();
            this.btnMembersView = new System.Windows.Forms.Button();
            this.btnMaxFines = new System.Windows.Forms.Button();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(490, 14);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(256, 55);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "REPORTS";
            // 
            // btnBookRecordView
            // 
            this.btnBookRecordView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookRecordView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRecordView.Location = new System.Drawing.Point(88, 129);
            this.btnBookRecordView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBookRecordView.Name = "btnBookRecordView";
            this.btnBookRecordView.Size = new System.Drawing.Size(219, 60);
            this.btnBookRecordView.TabIndex = 3;
            this.btnBookRecordView.Text = "Book Record";
            this.btnBookRecordView.UseVisualStyleBackColor = true;
            this.btnBookRecordView.Click += new System.EventHandler(this.btnBookRecordView_Click);
            this.btnBookRecordView.MouseEnter += new System.EventHandler(this.btnBookRecordView_MouseEnter);
            this.btnBookRecordView.MouseLeave += new System.EventHandler(this.btnBookRecordView_MouseLeave);
            // 
            // btnBooksIssuedView
            // 
            this.btnBooksIssuedView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBooksIssuedView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooksIssuedView.Location = new System.Drawing.Point(88, 226);
            this.btnBooksIssuedView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBooksIssuedView.Name = "btnBooksIssuedView";
            this.btnBooksIssuedView.Size = new System.Drawing.Size(219, 60);
            this.btnBooksIssuedView.TabIndex = 6;
            this.btnBooksIssuedView.Text = "Books Issued";
            this.btnBooksIssuedView.UseVisualStyleBackColor = true;
            this.btnBooksIssuedView.Click += new System.EventHandler(this.btnBooksIssuedView_Click);
            this.btnBooksIssuedView.MouseEnter += new System.EventHandler(this.btnBooksIssuedView_MouseEnter);
            this.btnBooksIssuedView.MouseLeave += new System.EventHandler(this.btnBooksIssuedView_MouseLeave);
            // 
            // btnFineView
            // 
            this.btnFineView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFineView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFineView.Location = new System.Drawing.Point(88, 320);
            this.btnFineView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFineView.Name = "btnFineView";
            this.btnFineView.Size = new System.Drawing.Size(219, 60);
            this.btnFineView.TabIndex = 7;
            this.btnFineView.Text = "Fine";
            this.btnFineView.UseVisualStyleBackColor = true;
            this.btnFineView.Click += new System.EventHandler(this.btnFineView_Click);
            this.btnFineView.MouseEnter += new System.EventHandler(this.btnFineView_MouseEnter);
            this.btnFineView.MouseLeave += new System.EventHandler(this.btnFineView_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_rp);
            this.groupBox1.Location = new System.Drawing.Point(88, 645);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1308, 157);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description of report button";
            // 
            // richTextBox_rp
            // 
            this.richTextBox_rp.BackColor = System.Drawing.Color.White;
            this.richTextBox_rp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_rp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_rp.Location = new System.Drawing.Point(4, 24);
            this.richTextBox_rp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox_rp.Name = "richTextBox_rp";
            this.richTextBox_rp.ReadOnly = true;
            this.richTextBox_rp.Size = new System.Drawing.Size(1300, 128);
            this.richTextBox_rp.TabIndex = 0;
            this.richTextBox_rp.Text = "";
            // 
            // btnMembersView
            // 
            this.btnMembersView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMembersView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembersView.Location = new System.Drawing.Point(88, 409);
            this.btnMembersView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMembersView.Name = "btnMembersView";
            this.btnMembersView.Size = new System.Drawing.Size(219, 65);
            this.btnMembersView.TabIndex = 9;
            this.btnMembersView.Text = "Members";
            this.btnMembersView.UseVisualStyleBackColor = true;
            this.btnMembersView.Click += new System.EventHandler(this.btnMembersView_Click);
            this.btnMembersView.MouseEnter += new System.EventHandler(this.btnMembersView_MouseEnter);
            this.btnMembersView.MouseLeave += new System.EventHandler(this.btnMembersView_MouseLeave);
            // 
            // btnMaxFines
            // 
            this.btnMaxFines.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaxFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxFines.Location = new System.Drawing.Point(88, 506);
            this.btnMaxFines.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaxFines.Name = "btnMaxFines";
            this.btnMaxFines.Size = new System.Drawing.Size(219, 65);
            this.btnMaxFines.TabIndex = 10;
            this.btnMaxFines.Text = "Max Fines";
            this.btnMaxFines.UseVisualStyleBackColor = true;
            this.btnMaxFines.Click += new System.EventHandler(this.btnMaxFines_Click);
            this.btnMaxFines.MouseEnter += new System.EventHandler(this.btnMaxFines_MouseEnter);
            this.btnMaxFines.MouseLeave += new System.EventHandler(this.btnMaxFines_MouseLeave);
            // 
            // pnlReport
            // 
            this.pnlReport.Controls.Add(this.crystalReportViewer1);
            this.pnlReport.Location = new System.Drawing.Point(398, 115);
            this.pnlReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(994, 526);
            this.pnlReport.TabIndex = 12;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(994, 526);
            this.crystalReportViewer1.TabIndex = 13;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1406, 808);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.btnMaxFines);
            this.Controls.Add(this.btnMembersView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFineView);
            this.Controls.Add(this.btnBooksIssuedView);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnBookRecordView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.groupBox1.ResumeLayout(false);
            this.pnlReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBookRecordView;
        private System.Windows.Forms.Button btnBooksIssuedView;
        private System.Windows.Forms.Button btnFineView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_rp;
        private System.Windows.Forms.Button btnMembersView;
        private System.Windows.Forms.Button btnMaxFines;
        private System.Windows.Forms.Panel pnlReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}