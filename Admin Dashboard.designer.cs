namespace LOAS
{
    partial class Admin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            this.sidebar_AdminDash = new System.Windows.Forms.FlowLayoutPanel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.homeSidebarPanel = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.reportsContainer = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.LibrarianContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.sidebar_timer = new System.Windows.Forms.Timer(this.components);
            this.reports_timer = new System.Windows.Forms.Timer(this.components);
            this.members_timer = new System.Windows.Forms.Timer(this.components);
            this.pnlAdminDash = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.sidebar_AdminDash.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.homeSidebarPanel.SuspendLayout();
            this.reportsContainer.SuspendLayout();
            this.panelView.SuspendLayout();
            this.LibrarianContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_AdminDash
            // 
            this.sidebar_AdminDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.sidebar_AdminDash.Controls.Add(this.menuPanel);
            this.sidebar_AdminDash.Controls.Add(this.homeSidebarPanel);
            this.sidebar_AdminDash.Controls.Add(this.reportsContainer);
            this.sidebar_AdminDash.Controls.Add(this.LibrarianContainer);
            this.sidebar_AdminDash.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar_AdminDash.Location = new System.Drawing.Point(0, 0);
            this.sidebar_AdminDash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidebar_AdminDash.MaximumSize = new System.Drawing.Size(420, 980);
            this.sidebar_AdminDash.MinimumSize = new System.Drawing.Size(147, 980);
            this.sidebar_AdminDash.Name = "sidebar_AdminDash";
            this.sidebar_AdminDash.Size = new System.Drawing.Size(147, 980);
            this.sidebar_AdminDash.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.btnMenu);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Location = new System.Drawing.Point(4, 5);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(416, 154);
            this.menuPanel.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(36, 42);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(72, 74);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            this.btnMenu.MouseHover += new System.EventHandler(this.btnMenu_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu";
            // 
            // homeSidebarPanel
            // 
            this.homeSidebarPanel.Controls.Add(this.btnHome);
            this.homeSidebarPanel.Location = new System.Drawing.Point(4, 169);
            this.homeSidebarPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeSidebarPanel.MinimumSize = new System.Drawing.Size(411, 102);
            this.homeSidebarPanel.Name = "homeSidebarPanel";
            this.homeSidebarPanel.Size = new System.Drawing.Size(416, 102);
            this.homeSidebarPanel.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(411, 105);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "  Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // reportsContainer
            // 
            this.reportsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.reportsContainer.Controls.Add(this.btnReports);
            this.reportsContainer.Controls.Add(this.panelView);
            this.reportsContainer.Location = new System.Drawing.Point(4, 281);
            this.reportsContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportsContainer.MaximumSize = new System.Drawing.Size(411, 177);
            this.reportsContainer.MinimumSize = new System.Drawing.Size(411, 102);
            this.reportsContainer.Name = "reportsContainer";
            this.reportsContainer.Size = new System.Drawing.Size(411, 102);
            this.reportsContainer.TabIndex = 2;
            this.reportsContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 0);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(411, 108);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.panelView.Controls.Add(this.btnView);
            this.panelView.Location = new System.Drawing.Point(0, 114);
            this.panelView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(411, 63);
            this.panelView.TabIndex = 4;
            // 
            // btnView
            // 
            this.btnView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(0, 0);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnView.Name = "btnView";
            this.btnView.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.btnView.Size = new System.Drawing.Size(411, 63);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.button7_Click);
            // 
            // LibrarianContainer
            // 
            this.LibrarianContainer.Controls.Add(this.panel1);
            this.LibrarianContainer.Controls.Add(this.btnMembers);
            this.LibrarianContainer.Location = new System.Drawing.Point(4, 393);
            this.LibrarianContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LibrarianContainer.MaximumSize = new System.Drawing.Size(411, 177);
            this.LibrarianContainer.MinimumSize = new System.Drawing.Size(411, 102);
            this.LibrarianContainer.Name = "LibrarianContainer";
            this.LibrarianContainer.Size = new System.Drawing.Size(411, 102);
            this.LibrarianContainer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 63);
            this.panel1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(411, 63);
            this.button3.TabIndex = 1;
            this.button3.Text = "Manage";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 63);
            this.panel2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(112, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(411, 63);
            this.button4.TabIndex = 1;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnMembers
            // 
            this.btnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(0, 0);
            this.btnMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnMembers.Size = new System.Drawing.Size(411, 108);
            this.btnMembers.TabIndex = 0;
            this.btnMembers.Text = "Librarian";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // sidebar_timer
            // 
            this.sidebar_timer.Interval = 1;
            this.sidebar_timer.Tick += new System.EventHandler(this.sidebar_timer_Tick);
            // 
            // reports_timer
            // 
            this.reports_timer.Interval = 1;
            this.reports_timer.Tick += new System.EventHandler(this.reports_timer_Tick);
            // 
            // members_timer
            // 
            this.members_timer.Interval = 1;
            this.members_timer.Tick += new System.EventHandler(this.members_timer_Tick);
            // 
            // pnlAdminDash
            // 
            this.pnlAdminDash.Location = new System.Drawing.Point(429, 68);
            this.pnlAdminDash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAdminDash.Name = "pnlAdminDash";
            this.pnlAdminDash.Size = new System.Drawing.Size(1430, 808);
            this.pnlAdminDash.TabIndex = 6;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLogOut.Location = new System.Drawing.Point(1680, 2);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(196, 57);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "LOGOUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.button5_Click);
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1876, 894);
            this.Controls.Add(this.pnlAdminDash);
            this.Controls.Add(this.sidebar_AdminDash);
            this.Controls.Add(this.btnLogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Dashboard";
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.sidebar_AdminDash.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.homeSidebarPanel.ResumeLayout(false);
            this.reportsContainer.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            this.LibrarianContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar_AdminDash;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel homeSidebarPanel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel reportsContainer;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel LibrarianContainer;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebar_timer;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Timer reports_timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer members_timer;
        private System.Windows.Forms.Panel pnlAdminDash;
    }
}