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

        private void Running_Movies_VisibleChanged(object sender, EventArgs e)
        {
            showAllMovies();
        }

        public void showAllMovies()
        {
            var reader = db.GetData("SELECT * FROM Movies");
            populateGrid(reader);
        }

        private void populateGrid(SqlDataReader reader)
        {
            runningMoviesGrid.Rows.Clear();
            while (reader.Read())
            {
                runningMoviesGrid.Rows.Add(reader["movie_ID"], reader["poster"], reader["name"], reader["release_year"], reader["language"], reader["theatre_name"], reader["show_time"]);
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
                    showAllMovies();
                }
            }
        }
    }
}
