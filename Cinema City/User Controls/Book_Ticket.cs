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

namespace Cinema_City.User_Controls
{
    public partial class Book_Ticket : UserControl
    {

        DBFunctions db = new DBFunctions();
        string selectedMovie = "", selectedTheatre = "", selectedShowTime = "", selectedMovieID = "";

        string temp_movie, temp_theatre, temp_showTime;

        string seatSelection;

        float totalAmount = 0, perSeatAmount = 250;
        public Book_Ticket()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Now;
        }

        private void checkNowBtn_Click(object sender, EventArgs e)
        {
            selectedMovie = movieComboBox.Text;
            selectedTheatre = theatreComboBox.Text;
            selectedShowTime = showTimeComboBox.Text;

            var reader = db.GetData("SELECT * FROM Movies");

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
            var reader = db.GetData("SELECT * FROM Movies");
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

                    //Generating a ticket for the passenger
                    if (reservedID != "")
                    {
                        Random random = new Random();
                        string ticketNumber = "(" + selectedTheatre + ")-" + random.Next(10000, 20000).ToString();
                        string purchasedTime = DateTime.Now.ToString("hh:mm tt");
                        string purchasedDate = DateTime.Now.ToString("yyyy-MM-dd");
                        db.SetData("INSERT INTO Ticket VALUES('" + ticketNumber + "','" + purchasedTime + "','" + purchasedDate + "','" + totalAmount + "','" + reservedID + "')");
                    }

                    MessageBox.Show("Purchase Completed for " + customerName, "RESERVED SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cName.Text = "";
                    cNumber.Text = "";
                    totalAmount = 0;
                    totalPrice.Text = "Loading...";
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
            Guna2Button[] seats = { A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4 };
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
                            case "A8":
                                reserved_status(A8);
                                break;
                            case "A9":
                                reserved_status(A9);
                                break;
                            case "A10":
                                reserved_status(A10);
                                break;
                            case "A11":
                                reserved_status(A11);
                                break;
                            case "A12":
                                reserved_status(A12);
                                break;
                            case "A13":
                                reserved_status(A13);
                                break;
                            case "A14":
                                reserved_status(A14);
                                break;
                            case "A15":
                                reserved_status(A15);
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
                            case "B8":
                                reserved_status(B8);
                                break;
                            case "B9":
                                reserved_status(B9);
                                break;
                            case "B10":
                                reserved_status(B10);
                                break;
                            case "B11":
                                reserved_status(B11);
                                break;
                            case "B12":
                                reserved_status(B12);
                                break;
                            case "B13":
                                reserved_status(B13);
                                break;
                            case "B14":
                                reserved_status(B14);
                                break;
                            case "B15":
                                reserved_status(B15);
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
                            case "C8":
                                reserved_status(C8);
                                break;
                            case "C9":
                                reserved_status(C9);
                                break;
                            case "C10":
                                reserved_status(C10);
                                break;
                            case "C11":
                                reserved_status(C11);
                                break;
                            case "C12":
                                reserved_status(C12);
                                break;
                            case "C13":
                                reserved_status(C13);
                                break;
                            case "C14":
                                reserved_status(C14);
                                break;
                            case "C15":
                                reserved_status(C15);
                                break;

                            case "R1":
                                reserved_status(R1);
                                break;
                            case "R2":
                                reserved_status(R2);
                                break;
                            case "R3":
                                reserved_status(R3);
                                break;
                            case "R4":
                                reserved_status(R4);
                                break;
                            case "R5":
                                reserved_status(R5);
                                break;
                            case "R6":
                                reserved_status(R6);
                                break;
                            case "R7":
                                reserved_status(R7);
                                break;
                            case "R8":
                                reserved_status(R8);
                                break;
                            case "R9":
                                reserved_status(R9);
                                break;
                            case "R10":
                                reserved_status(R10);
                                break;
                            case "R11":
                                reserved_status(R11);
                                break;
                            case "R12":
                                reserved_status(R12);
                                break;
                            case "R13":
                                reserved_status(R13);
                                break;
                            case "R14":
                                reserved_status(R14);
                                break;
                            case "R15":
                                reserved_status(R15);
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
                            case "M8":
                                reserved_status(M8);
                                break;
                            case "M9":
                                reserved_status(M9);
                                break;
                            case "M10":
                                reserved_status(M10);
                                break;
                            case "M11":
                                reserved_status(M11);
                                break;
                            case "M12":
                                reserved_status(M12);
                                break;
                            case "M13":
                                reserved_status(M13);
                                break;
                            case "M14":
                                reserved_status(M14);
                                break;
                            case "M15":
                                reserved_status(M15);
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
                button[i].Cursor = Cursors.Default;
            }
        }

        //It will make a seat disabled if it's already reserved
        void reserved_status(Guna2Button button)
        {
            button.Enabled = false;
            button.Cursor = Cursors.No;
        }

        //This function will help to generate the selections of seats
        public void seatBtnToggle(Guna2Button button, string seat_no)
        {
            if (button.Checked == true)
            {
                seatSelection += seat_no + ",";
                totalAmount += perSeatAmount;
            }
            else
            {
                seatSelection = seatSelection.Remove(seatSelection.IndexOf(seat_no), 3);
                if (totalAmount > 0)
                {
                    totalAmount -= perSeatAmount;
                }
            }
        }

        private void seatClick(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            seatBtnToggle(button, button.Text);
            seatNumber.Text = seatSelection;

            totalPrice.Text = totalAmount.ToString() + " TAKA";
        }
    }
}
