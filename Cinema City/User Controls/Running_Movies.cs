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
using System.Data.SqlClient;
using Bunifu.UI.WinForms;

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
                runningMoviesGrid.Rows.Clear();
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
                    runningMoviesGrid.Rows.Add(temp_ID, temp_poster, temp_name, temp_year, temp_lang, temp_theatre, temp_time);
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

        private void populateGrid(SqlDataReader reader)
        {
            runningMoviesGrid.Rows.Clear();
            while (reader.Read())
            {
                var helper = db.GetData("SELECT movie_ID FROM Movies WHERE movie_ID = '" + reader["movie_ID"] + "'");
                string count = "";
                int i = 0;
                while (helper.Read())
                {
                    i++;
                }
                if (i > 0)
                {
                    count = "(" + i.ToString() + ")";
                }
                runningMoviesGrid.Rows.Add(reader["movie_ID"], reader["name"], reader["release_year"], reader["language"], reader["poster"], reader["theatre_name"], reader["show_time"].ToString() + count);
            }
        }

        //Delete Functionality
        private void runningMoviesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (runningMoviesGrid.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int selectedID = Convert.ToInt32(runningMoviesGrid.Rows[e.RowIndex].Cells[0].Value);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete?", "Movie Deletion Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    db.SetData("DELETE FROM Movies WHERE movie_ID = '" + selectedID + "'");
                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
