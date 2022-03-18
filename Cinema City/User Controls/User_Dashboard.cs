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
    public partial class user_Dashboard : UserControl
    {
        public user_Dashboard()
        {
            InitializeComponent();
        }

        private void user_Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            day.Text = DateTime.Now.ToString("dddd");
            date.Text = DateTime.Now.ToString("dd");
            month.Text = DateTime.Now.ToString("MMMM");
        }
    }
}
