using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_City.User_Controls
{
    public partial class Movie_Report : UserControl
    {
        DBFunctions db = new DBFunctions();
        public Movie_Report()
        {
            InitializeComponent();
        }
        private void Movie_Report_Load(object sender, EventArgs e)
        {
            fromDate.Value = DateTime.Now;
            toDate.Value = DateTime.Now;
            fillChart();
        }
        private void fillChart()
        {
            string from = fromDate.Value.ToString("yyyy-MM-dd");
            string to = toDate.Value.ToString("yyyy-MM-dd");
            string movie, income;
            var dataReader = db.GetData("select movie_name as movie, sum(total_price) as income from Analytics where date between '" + from + "' and '" + to + "' group by movie_name");

            while (dataReader.Read())
            {
                movie = dataReader["movie"].ToString();
                income = dataReader["income"].ToString();

                Movie_Income.Series["movie_income"].Points.AddXY(movie, income);
            }
        }

        private void checkNowBtn_Click(object sender, EventArgs e)
        {
            Movie_Income.Series["movie_income"].Points.Clear();
            fillChart();
        }
    }
}