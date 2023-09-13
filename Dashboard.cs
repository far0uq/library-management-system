using LOAS.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LOAS
{
    public partial class Dashboard : Form
    {
        static DashboardNew dashnew = new DashboardNew();
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(DashboardNew dnew)
        {
            InitializeComponent();
            dashnew = dnew;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if ("Dashboard" != this.GetType().Name)
            {
                Dashboard dashboard = new Dashboard();
                Hide();
                dashboard.ShowDialog();
                Close();
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCatalog_Click_1(object sender, EventArgs e)
        {
            btnExit bookCatalog = new btnExit();
            Hide();
            bookCatalog.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ("IssueForm" != this.GetType().Name)
            {
                IssueForm issueform = new IssueForm();
                Hide();
                issueform.ShowDialog();
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ("Catalog" != this.GetType().Name)
            {
                btnExit bookCatalog = new btnExit();
                Hide();
                bookCatalog.ShowDialog();
                Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ("MemberPane" != this.GetType().Name)
            {
                MemberPane memberPane = new MemberPane();
                Hide();
                memberPane.ShowDialog();
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ("FineDetail" != this.GetType().Name)
            {
                FineDetail fineDetail = new FineDetail();
                Hide();
                fineDetail.ShowDialog();
                Close();
            }
        }
        private void DrawPieChart()
        {
            //reset your chart series and legends
            chtTopThreeAuthors.Series.Clear();
            chtTopThreeAuthors.Legends.Clear();

            //Add a new Legend(if needed) and do some formating
            chtTopThreeAuthors.Legends.Add("MyLegend");
            chtTopThreeAuthors.Legends[0].LegendStyle = LegendStyle.Table;
            chtTopThreeAuthors.Legends[0].Docking = Docking.Bottom;
            chtTopThreeAuthors.Legends[0].Alignment = StringAlignment.Center;
            chtTopThreeAuthors.Legends[0].Title = "Authors with the most Books.";
            chtTopThreeAuthors.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = "MySeriesName";
            chtTopThreeAuthors.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chtTopThreeAuthors.Series[seriesname].ChartType = SeriesChartType.Pie;

            using (var db = new LibraryEntities())
            {
                var authors = (
                                from author in db.Authors
                                 select new
                                 {
                                     author_id = author.author_id,
                                     author_name = author.author_name
                                 }).ToList();

                var books = (from book in db.Books
                                 join author in db.Authors

                                 on book.book_author equals author.author_id

                                 select new
                                 {
                                     book_author = author.author_name,
                                 }).ToList();

                int count = 0;
                List<int> bookCount = new List<int>();

                foreach (var author in authors)
                {
                    count = 0;
                    foreach(var book in books)
                    {
                        if(author.author_name == book.book_author)
                            count++;
                    }
                    bookCount.Add(count);
                }

                //Add some datapoints so the series. in this case you can pass the values to this method
                for(int i = 0; i < 3; i++)
                {
                    if(bookCount.Max() != 0)
                    {
                        int currentMax = bookCount.Max();
                        int maxIndex = bookCount.FindIndex(a => a == currentMax);
                        chtTopThreeAuthors.Series[seriesname].Points.AddXY(authors[maxIndex].author_name.ToString(), currentMax);

                        bookCount.RemoveAt(maxIndex);
                        authors.RemoveAt(maxIndex);
                    }
                }
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DrawPieChart();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DashboardNew dn = new DashboardNew(1);
            dn.Show();
            dashnew.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DashboardNew dn = new DashboardNew(2);
            dn.Show();
            dashnew.Hide();
        }
    }
}
