using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_City.User_Controls
{
    public partial class Running_Movies : UserControl
    {
        DBFunctions db = new DBFunctions();
        public Running_Movies()
        {
            InitializeComponent();
        }
        private void getData()
        {
            try
            {
                DataTable dt = db.getData("SELECT * FROM Movies");

                string temp_name, temp_year, temp_lang, temp_theatre, temp_time;
                Image temp_poster;
                int temp_ID, i = 0;
                byte[] dbPoster;
                runningMoviesData.Rows.Clear();
                while (dt.Rows.Count > 0)
                {
                    if (i > dt.Rows.Count - 1)
                    {
                        break;
                    }
                    temp_ID = Convert.ToInt32(dt.Rows[i][0]);
                    temp_name = dt.Rows[i][1].ToString();
                    temp_year = dt.Rows[i][2].ToString();
                    temp_lang = dt.Rows[i][3].ToString();
                    dbPoster = (byte[])dt.Rows[i][4];
                    temp_poster = ConvertByteToImage(dbPoster);
                    temp_theatre = dt.Rows[i][5].ToString();
                    temp_time = dt.Rows[i][6].ToString();
                    runningMoviesData.Rows.Add(temp_ID, temp_poster, temp_name, temp_year, temp_lang, temp_theatre, temp_time);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Image ConvertByteToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void Running_Movies_VisibleChanged(object sender, EventArgs e)
        {
            getData();
        }
    }
}
