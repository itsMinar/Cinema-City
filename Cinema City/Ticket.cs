using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_City
{
    public partial class Ticket : Form
    {
        public string movie, theatre, time, date, seat;

        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            pMovie.Text = movie;
            pTheatre.Text = theatre;
            pTime.Text = time;
            pDate.Text = date;
            pSeat.Text = seat;
        }
    }
}
