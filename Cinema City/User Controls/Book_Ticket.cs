using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cinema_City.User_Controls
{
    public partial class Book_Ticket : UserControl
    {

        DBFunctions db = new DBFunctions();
        string selectedMovie = "", selectedTheatre = "", selectedShowTime = "", selectedMovieID = "";

        string temp_movie, temp_theatre, temp_showTime;

        string seatSelection;

        float totalAmount = 0, basicSeatAmount = 300, vipSeatAmount = 500;

        int ticketCount = 1;
        public Book_Ticket()
        {
            InitializeComponent();
        }

        private void checkNowBtn_Click(object sender, EventArgs e)
        {
            selectedMovie = movieComboBox.Text;
            selectedTheatre = theatreComboBox.Text;
            selectedShowTime = showTimeComboBox.Text;

            var reader = db.GetData("SELECT * FROM Movies WHERE name = '" + selectedMovie + "' AND theatre_name = '" + selectedTheatre + "' AND show_time = '" + selectedShowTime + "'");

            while (reader.Read())
            {
                temp_movie = reader["name"].ToString();
                temp_theatre = reader["theatre_name"].ToString();
                temp_showTime = reader["show_time"].ToString();
                selectedMovieID = reader["movie_ID"].ToString();
            }

            if (selectedMovie != "" && selectedTheatre != "" && selectedShowTime != "")
            {
                if (selectedMovie == temp_movie && selectedTheatre == temp_theatre && selectedShowTime == temp_showTime)
                {
                    seatPanel.Visible = true;
                    customerPanel.Visible = true;

                    ticketCount = 1;
                    cName.Text = "";
                    cNumber.Text = "";
                    totalAmount = 0;
                    totalPrice.Text = "0 TAKA";

                    showSeats();
                }
                else
                {
                    MessageBox.Show("Movie Not Available!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Fillup Everything!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Book_Ticket_VisibleChanged(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Now;
            var reader = db.GetData("SELECT distinct name FROM Movies");
            movieComboBox.Items.Clear();
            while (reader.Read())
            {
                movieComboBox.Items.Add(reader["name"]);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string customerName = cName.Text;
            string customerNumber = cNumber.Text;

            string customerID = "";

            if (customerName != "" && customerNumber != "")
            {
                if (seatSelection != "")
                {
                    db.SetData("INSERT INTO Customer VALUES('" + customerName + "', '" + customerNumber + "')");
                }
                else
                {
                    MessageBox.Show("Invalid seat selection", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (seatSelection != "")
                {
                    var customerIDReader = db.GetData("SELECT * FROM Customer WHERE name = '" + customerName + "' AND phone_number = '" + customerNumber + "'");
                    while (customerIDReader.Read())
                    {
                        customerID = customerIDReader["customer_ID"].ToString();
                    }
                }

                if (customerID != "")
                {
                    db.SetData("INSERT INTO Reservation VALUES('" + seatSelection + "','" + customerID + "','" + selectedMovieID + "')");
                    var reservationIDReader = db.GetData("SELECT * FROM Reservation WHERE customer_ID = '" + customerID + "' AND reserved_seat = '" + seatSelection + "' AND movie_ID = '" + selectedMovieID + "'");
                    string reservedID = "";
                    while (reservationIDReader.Read())
                    {
                        reservedID = reservationIDReader["reservation_ID"].ToString();
                    }

                    //Generating a ticket number
                    Random random = new Random();
                    string ticketNumber = "(" + selectedTheatre + ")-" + random.Next(10000, 20000).ToString();

                    if (reservedID != "")
                    {
                        string purchasedTime = DateTime.Now.ToString("hh:mm tt");
                        string purchasedDate = DateTime.Now.ToString("yyyy-MM-dd");
                        db.SetData("INSERT INTO Ticket VALUES('" + ticketNumber + "','" + purchasedTime + "','" + purchasedDate + "','" + totalAmount + "','" + reservedID + "')");
                    }

                    MessageBox.Show("Purchase Completed for " + customerName, "BOOKED SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Ticket ticket = new Ticket(selectedMovie, selectedTheatre, ticketNumber, selectedShowTime, seatSelection, datePicker.Value.ToString("dd/MM/yyyy"), totalAmount.ToString());

                    // Insert Data to Database for Analytics
                    db.SetData("INSERT INTO Analytics VALUES('" + selectedMovie + "','" + datePicker.Value.ToString("yyyy-MM-dd") + "','" + showTimeComboBox.Text + "','" + theatreComboBox.Text + "','" + totalAmount + "')");

                    ticketCount = 1;
                    cName.Text = "";
                    cNumber.Text = "";
                    totalAmount = 0;
                    totalPrice.Text = "0 TAKA";

                    ticket.ShowDialog();

                    showSeats();
                }
            }
            else
            {
                MessageBox.Show("Please fill up everything", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void showSeats()
        {
            string reserved_seat;
            Guna2Button[] seats = { A1, A2, A3, A4, A5, A6, A7, B1, B2, B3, B4, B5, B6, B7, C1, C2, C3, C4, C5, C6, C7, D1, D2, D3, D4, D5, D6, D7, E1, E2, E3, E4, E5, E6, E7, F1, F2, F3, F4, F5, F6, F7, M1, M2, M3, M4, M5, M6, M7, N1, N2, N3, N4, N5, N6, N7, P1, P2, P3, P4, P5, P6, P7, Q1, Q2, Q3, Q4, Q5, Q6, Q7};
            all_seat_available(seats);

            if (selectedMovieID != "")
            {
                var reader = db.GetData("SELECT * FROM Reservation WHERE movie_ID = " + Convert.ToInt32(selectedMovieID) + "");
                while (reader.Read())
                {
                    reserved_seat = reader["reserved_seat"].ToString();
                    string[] reserve = reserved_seat.Split(',');
                    for (int i = 0; i < reserve.Length; i++)
                    {
                        switch (reserve[i])
                        {
                            case "A1":
                                reserved_status(A1);
                                break;
                            case "A2":
                                reserved_status(A2);
                                break;
                            case "A3":
                                reserved_status(A3);
                                break;
                            case "A4":
                                reserved_status(A4);
                                break;
                            case "A5":
                                reserved_status(A5);
                                break;
                            case "A6":
                                reserved_status(A6);
                                break;
                            case "A7":
                                reserved_status(A7);
                                break;
                            case "B1":
                                reserved_status(B1);
                                break;
                            case "B2":
                                reserved_status(B2);
                                break;
                            case "B3":
                                reserved_status(B3);
                                break;
                            case "B4":
                                reserved_status(B4);
                                break;
                            case "B5":
                                reserved_status(B5);
                                break;
                            case "B6":
                                reserved_status(B6);
                                break;
                            case "B7":
                                reserved_status(B7);
                                break;
                            case "C1":
                                reserved_status(C1);
                                break;
                            case "C2":
                                reserved_status(C2);
                                break;
                            case "C3":
                                reserved_status(C3);
                                break;
                            case "C4":
                                reserved_status(C4);
                                break;
                            case "C5":
                                reserved_status(C5);
                                break;
                            case "C6":
                                reserved_status(C6);
                                break;
                            case "C7":
                                reserved_status(C7);
                                break;
                            case "D1":
                                reserved_status(D1);
                                break;
                            case "D2":
                                reserved_status(D2);
                                break;
                            case "D3":
                                reserved_status(D3);
                                break;
                            case "D4":
                                reserved_status(D4);
                                break;
                            case "D5":
                                reserved_status(D5);
                                break;
                            case "D6":
                                reserved_status(D6);
                                break;
                            case "D7":
                                reserved_status(D7);
                                break;
                            case "E1":
                                reserved_status(E1);
                                break;
                            case "E2":
                                reserved_status(E2);
                                break;
                            case "E3":
                                reserved_status(E3);
                                break;
                            case "E4":
                                reserved_status(E4);
                                break;
                            case "E5":
                                reserved_status(E5);
                                break;
                            case "E6":
                                reserved_status(E6);
                                break;
                            case "E7":
                                reserved_status(E7);
                                break;
                            case "F1":
                                reserved_status(F1);
                                break;
                            case "F2":
                                reserved_status(F2);
                                break;
                            case "F3":
                                reserved_status(F3);
                                break;
                            case "F4":
                                reserved_status(F4);
                                break;
                            case "F5":
                                reserved_status(F5);
                                break;
                            case "F6":
                                reserved_status(F6);
                                break;
                            case "F7":
                                reserved_status(F7);
                                break;

                            case "M1":
                                reserved_status(M1);
                                break;
                            case "M2":
                                reserved_status(M2);
                                break;
                            case "M3":
                                reserved_status(M3);
                                break;
                            case "M4":
                                reserved_status(M4);
                                break;
                            case "M5":
                                reserved_status(M5);
                                break;
                            case "M6":
                                reserved_status(M6);
                                break;
                            case "M7":
                                reserved_status(M7);
                                break;
                            case "N1":
                                reserved_status(N1);
                                break;
                            case "N2":
                                reserved_status(N2);
                                break;
                            case "N3":
                                reserved_status(N3);
                                break;
                            case "N4":
                                reserved_status(N4);
                                break;
                            case "N5":
                                reserved_status(N5);
                                break;
                            case "N6":
                                reserved_status(N6);
                                break;
                            case "N7":
                                reserved_status(N7);
                                break;
                            case "P1":
                                reserved_status(P1);
                                break;
                            case "P2":
                                reserved_status(P2);
                                break;
                            case "P3":
                                reserved_status(P3);
                                break;
                            case "P4":
                                reserved_status(P4);
                                break;
                            case "P5":
                                reserved_status(P5);
                                break;
                            case "P6":
                                reserved_status(P6);
                                break;
                            case "P7":
                                reserved_status(P7);
                                break;
                            case "Q1":
                                reserved_status(Q1);
                                break;
                            case "Q2":
                                reserved_status(Q2);
                                break;
                            case "Q3":
                                reserved_status(Q3);
                                break;
                            case "Q4":
                                reserved_status(Q4);
                                break;
                            case "Q5":
                                reserved_status(Q5);
                                break;
                            case "Q6":
                                reserved_status(Q6);
                                break;
                            case "Q7":
                                reserved_status(Q7);
                                break;
                        }
                    }
                }
            }
        }

        //Function to make all seats available by default
        private void all_seat_available(Guna2Button[] button)
        {
            for (int i = 0; i < button.Length; i++)
            {
                button[i].Enabled = true;
                button[i].Checked = false;
                seatSelection = "";
                seatNumber.Text = seatSelection;
                button[i].Cursor = Cursors.Hand;
            }
        }

        //It will make a seat disabled if it's already reserved
        void reserved_status(Guna2Button button)
        {
            button.Enabled = false;
            button.Cursor = Cursors.No;
        }

        //This function will help to generate the selections of Basic Seats
        public void basicSeatBtnToggle(Guna2Button button, string seat_no)
        {
            if (button.Checked == true)
            {
                seatSelection += seat_no + ",";
                totalAmount += basicSeatAmount;
                ticketCount++;
            }
            else
            {
                ticketCount--;
                seatSelection = seatSelection.Remove(seatSelection.IndexOf(seat_no), 3);
                if (totalAmount > 0)
                {
                    totalAmount -= basicSeatAmount;
                }
            }
        }

        //This function will help to generate the selections of VIP Seats
        public void vipSeatBtnToggle(Guna2Button button, string seat_no)
        {
            if (button.Checked == true)
            {
                seatSelection += seat_no + ",";
                totalAmount += vipSeatAmount;
                ticketCount++;
            }
            else
            {
                ticketCount--;
                seatSelection = seatSelection.Remove(seatSelection.IndexOf(seat_no), 3);
                if (totalAmount > 0)
                {
                    totalAmount -= vipSeatAmount;
                }
            }
        }

        private void basicSeatClick(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;

            if (ticketCount <= 5)
            {
                basicSeatBtnToggle(button, button.Text);
                seatNumber.Text = seatSelection;

                totalPrice.Text = totalAmount.ToString() + " TAKA";
            }
            else if (ticketCount > 5 && button.Checked==false)
            {
                basicSeatBtnToggle(button, button.Text);
                seatNumber.Text = seatSelection;

                totalPrice.Text = totalAmount.ToString() + " TAKA";
            }
            else
            {
                button.Checked = false;
                MessageBox.Show("Customer Can't Buy more than 5 Tickets", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void vipSeatClick(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;

            if (ticketCount <= 5)
            {
                vipSeatBtnToggle(button, button.Text);
                seatNumber.Text = seatSelection;

                totalPrice.Text = totalAmount.ToString() + " TAKA";
            }
            else if (ticketCount > 5 && button.Checked == false)
            {
                vipSeatBtnToggle(button, button.Text);
                seatNumber.Text = seatSelection;

                totalPrice.Text = totalAmount.ToString() + " TAKA";
            }
            else
            {
                button.Checked = false;
                MessageBox.Show("Customer Can't Buy more than 5 Tickets", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
