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
    public partial class Book_Ticket : UserControl
    {

        DBFunctions db = new DBFunctions();
        public Book_Ticket()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Now;
        }

        public void showMovies()
        {
            movieComboBox.DataSource = db.getData("SELECT name FROM Movies");
            movieComboBox.DisplayMember = "name";
        }

        private void Book_Ticket_VisibleChanged(object sender, EventArgs e)
        {
            showMovies();
        }
    }
}
