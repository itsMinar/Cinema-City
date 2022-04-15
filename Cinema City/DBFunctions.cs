using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_City
{
    internal class DBFunctions
    {
        public SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=MMM\SQLEXPRESS;Initial Catalog=CinemaCity;Integrated Security=True";
            return con;
        }

        public DataTable getData(string query)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            con.Close();
            return dt;
        }

        //Method to Get Data from Database (SELECT)
        public SqlDataReader GetData(string query)
        {
            SqlConnection con = GetConnection();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        //Method for Set Data in Database (INSERT, UPDATE, DELETE)
        public void SetData(string query)
        {
            SqlConnection con = GetConnection();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
