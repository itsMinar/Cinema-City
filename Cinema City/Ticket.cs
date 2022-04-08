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
        public string movie, theatre, ticketNumber, time, date, seat, price;

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        public Ticket()
        {
            InitializeComponent();
        }

        public Ticket(string movie, string theatre, string ticketNumber, string time, string seat, string date, string price)
        {
            this.movie = movie;
            this.theatre = theatre;
            this.ticketNumber = ticketNumber;
            this.time = time;
            this.seat = seat;
            this.date = date;
            this.price = price;

            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            pMovie.Text = movie;
            pTheatre.Text = theatre;
            pTime.Text = time;
            pTicketNumber.Text = ticketNumber;
            pSeat.Text = seat;
            pDate.Text = date;
            pTotalPrice.Text = price;
        }

        //painting the ticket
        void Print()
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bitmap;
    }
}
