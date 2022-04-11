using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_City.User_Controls
{
    public partial class Add_Movies : UserControl
    {
        DBFunctions db = new DBFunctions();

        string Tht { get; set; }
        string Tm { get; set; }

        public Add_Movies()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgBox.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void addMovieBtn_Click(object sender, EventArgs e)
        {
            if(Tht != null && Tm != null)
            {
                try
                {
                    string name = nameBox.Text;
                    string year = yearBox.Text;
                    string lang = langBox.Text;
                    string theatre = theatreBox.SelectedItem.ToString();
                    string time = timeBox.SelectedItem.ToString();

                    Image img = imgBox.Image;
                    byte[] imgArr;
                    ImageConverter converter = new ImageConverter();
                    imgArr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                    string temp_name, temp_year, temp_lang, temp_theatre, temp_time;
                    bool dataExist = false;

                    SqlDataReader dr = db.GetData("SELECT * FROM Movies");

                    while (dr.Read())
                    {
                        temp_name = dr["name"].ToString();
                        temp_year = dr["release_year"].ToString();
                        temp_lang = dr["language"].ToString();
                        temp_theatre = dr["theatre_name"].ToString();
                        temp_time = dr["show_time"].ToString();

                        if (temp_theatre == theatre && temp_time == time)
                        {
                            dataExist = true;
                            MessageBox.Show("Theatre is Booked", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    }
                    dr.Close();

                    if (dataExist == false)
                    {
                        if (name != String.Empty && year != String.Empty && lang != String.Empty && img != null)
                        {
                            SqlConnection con = db.GetConnection();
                            con.Open();

                            SqlCommand cmd = new SqlCommand("INSERT INTO Movies(name, release_year, language, poster, theatre_name, show_time) VALUES(@name, @year, @language, @poster, @theatre, @time)", con);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@year", year);
                            cmd.Parameters.AddWithValue("@language", lang);
                            cmd.Parameters.AddWithValue("@poster", imgArr);
                            cmd.Parameters.AddWithValue("@theatre", theatre);
                            cmd.Parameters.AddWithValue("@time", time);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Movie Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();

                            nameBox.Text = String.Empty;
                            yearBox.Text = String.Empty;
                            langBox.Text = String.Empty;
                            imgBox.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("Something is Missing", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("Select Theatre and Show Time", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void theatreBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (theatreBox.SelectedItem != null)
            {
                Tht = theatreBox.SelectedItem.ToString();
            }
        }

        private void timeBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (timeBox.SelectedItem != null)
            {
                Tm = timeBox.SelectedItem.ToString();
            }
        }
    }
}
