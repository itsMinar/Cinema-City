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

namespace Cinema_City
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            hideallUserControl();
            uncheckAllButton();
            showUserControl(user_Dashboard1, dashboardBtn);
        }

        private void uncheckAllButton()
        {
            dashboardBtn.Checked = false;
            addMoviesBtn.Checked = false;
            runningMoviesBtn.Checked = false;
            bookingBtn.Checked = false;
        }

        private void hideallUserControl()
        {
            user_Dashboard1.Visible = false;
            add_Movies1.Visible = false;
            running_Movies1.Visible=false;
            book_Ticket1.Visible = false;
        }
        private void showUserControl(UserControl x, Guna2Button y)
        {
            hideallUserControl();
            uncheckAllButton();
            y.Checked = true;
            x.Visible = true;
            x.BringToFront();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure?", "Logout", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                logIn loginPage = new logIn();
                loginPage.Show();
                this.Hide();
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            showUserControl(user_Dashboard1, dashboardBtn);
        }

        private void addMoviesBtn_Click(object sender, EventArgs e)
        {
            showUserControl(add_Movies1, addMoviesBtn);
        }

        private void runningMoviesBtn_Click(object sender, EventArgs e)
        {
            showUserControl(running_Movies1, runningMoviesBtn);
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            showUserControl(book_Ticket1, bookingBtn);
        }
    }
}
