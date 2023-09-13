namespace LOAS
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chtTopThreeAuthors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtTopThreeAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dashboard";
            // 
            // chtTopThreeAuthors
            // 
            this.chtTopThreeAuthors.BackColor = System.Drawing.Color.Transparent;
            this.chtTopThreeAuthors.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chtTopThreeAuthors.BorderlineColor = System.Drawing.Color.Transparent;
            this.chtTopThreeAuthors.BorderlineWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.chtTopThreeAuthors.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtTopThreeAuthors.Legends.Add(legend1);
            this.chtTopThreeAuthors.Location = new System.Drawing.Point(109, 153);
            this.chtTopThreeAuthors.Name = "chtTopThreeAuthors";
            this.chtTopThreeAuthors.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 3;
            this.chtTopThreeAuthors.Series.Add(series1);
            this.chtTopThreeAuthors.Size = new System.Drawing.Size(385, 443);
            this.chtTopThreeAuthors.TabIndex = 29;
            this.chtTopThreeAuthors.Text = "chart1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(198)))), ((int)(((byte)(191)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::LOAS.Properties.Resources.icons8_repository_60;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(524, 153);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 150, 0, 20);
            this.button1.Size = new System.Drawing.Size(484, 443);
            this.button1.TabIndex = 30;
            this.button1.Text = "Register A Book";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(212)))), ((int)(((byte)(192)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::LOAS.Properties.Resources.icons8_member_50__2_;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(109, 623);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(0, 40, 0, 20);
            this.button6.Size = new System.Drawing.Size(899, 240);
            this.button6.TabIndex = 6;
            this.button6.Text = "View Members";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1078, 894);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chtTopThreeAuthors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtTopThreeAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTopThreeAuthors;
        private System.Windows.Forms.Button button1;
    }
}