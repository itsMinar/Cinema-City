using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cinema_City.User_Controls
{
    public partial class Analytics : UserControl
    {
        DBFunctions db = new DBFunctions();

        double temp_price;
        double total12 = 0, total3 = 0, total6 = 0, total9 = 0;
        public Analytics()
        {
            InitializeComponent();
        }

        private void checkNowBtn_Click(object sender, EventArgs e)
        {
            showChart();
        }

        private void Analytics_VisibleChanged(object sender, EventArgs e)
        {
            fromDate.Value = DateTime.Now;
            toDate.Value = DateTime.Now;
            showChart();
        }

        private void showChart()
        {
            fillChart(CCity_1, "CCity-01", "12:00 PM", "03:00 PM", "06:00 PM", "09:00 PM");
            fillChart(CCity_2, "CCity-02", "12:00 PM", "03:00 PM", "06:00 PM", "09:00 PM");
            fillChart(CCity_3, "CCity-03", "12:00 PM", "03:00 PM", "06:00 PM", "09:00 PM");
        }

        private void fillChart(Chart chartName, string theatre, string show1, string show2, string show3, string show4)
        {
            chartName.Series["Total Income"].Points.Clear();
            chartName.Titles.Clear();

            var reader12 = db.GetData("SELECT * FROM Analytics WHERE theatre_name = '" + theatre + "' AND show_time = '" + show1 + "' AND date BETWEEN '" + fromDate.Value.ToString("yyyy-MM-dd") + "' AND '" + toDate.Value.ToString("yyyy-MM-dd") + "'");
            var reader3 = db.GetData("SELECT * FROM Analytics WHERE theatre_name = '" + theatre + "' AND show_time = '" + show2 + "' AND date BETWEEN '" + fromDate.Value.ToString("yyyy-MM-dd") + "' AND '" + toDate.Value.ToString("yyyy-MM-dd") + "'");
            var reader6 = db.GetData("SELECT * FROM Analytics WHERE theatre_name = '" + theatre + "' AND show_time = '" + show3 + "' AND date BETWEEN '" + fromDate.Value.ToString("yyyy-MM-dd") + "' AND '" + toDate.Value.ToString("yyyy-MM-dd") + "'");
            var reader9 = db.GetData("SELECT * FROM Analytics WHERE theatre_name = '" + theatre + "' AND show_time = '" + show4 + "' AND date BETWEEN '" + fromDate.Value.ToString("yyyy-MM-dd") + "' AND '" + toDate.Value.ToString("yyyy-MM-dd") + "'");

            double totalData12 = reader(reader12, total12);
            double totalData3 = reader(reader3, total3);
            double totalData6 = reader(reader6, total6);
            double totalData9 = reader(reader9, total9);

            chartName.Series["Total Income"].Points.AddXY("12:00 PM", totalData12);
            chartName.Series["Total Income"].Points.AddXY("03:00 PM", totalData3);
            chartName.Series["Total Income"].Points.AddXY("06:00 PM", totalData6);
            chartName.Series["Total Income"].Points.AddXY("09:00 PM", totalData9);
       
            chartName.Titles.Add("Analytics of " + theatre);
        }

        private double reader(SqlDataReader reader, double total)
        {
            while (reader.Read())
            {
                temp_price = Convert.ToDouble(reader["total_price"].ToString());
                total += temp_price;
            }
            return total;
        }
    }
}
