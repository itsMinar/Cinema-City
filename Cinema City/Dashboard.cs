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
    }
}
