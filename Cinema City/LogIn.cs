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
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(username.Text =="admin" && password.Text == "220813")
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            } else
            {
                MessageBox.Show("Wrong Credential");
            }
        }
    }
}
