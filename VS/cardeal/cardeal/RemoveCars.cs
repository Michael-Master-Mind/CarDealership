using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cardeal
{
    public partial class RemoveCars : Form
    {
        public void Displayall(DataGridView dgv)
        {
            dgv.DataSource = null;
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TV36L87C\SQLEXPRESS;Initial Catalog=CarDataBase;Integrated Security=True");
            string query = "DisplayAllCars";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                int r = 0;
                //dgv.DataSource = null;
                //dgv.DataSource = cmd;
                while (sdr.Read())
                {
                    dgv.Rows.Add(1);
                    dgv[0, r].Value = sdr["ID"].ToString();
                    dgv[1, r].Value = sdr["Model"].ToString();
                    dgv[2, r].Value = sdr["Manufacturer"].ToString();
                    dgv[3, r].Value = sdr["Year"].ToString();
                    dgv[4, r].Value = sdr["Price"].ToString();
                    dgv[5, r].Value = sdr["Kilometer"].ToString();
                    r++;
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void remove(string model, string manufacturer, int year)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog= CarDataBase;Integrated Security=True");
            string q = "RemoveCar";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@manufacturer", manufacturer);
            cmd.Parameters.AddWithValue("@year", year);
            try
            {
                con.Open();
                MessageBox.Show("Succefully connected");
                cmd.ExecuteNonQuery();
                con.Close();
                    MessageBox.Show(manufacturer + " " + model + " ,has been Successfully Removed!!!"); 
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            
            txtModel.Text = "";
            txrManufacturer.Text = "";
            txtYear.Text = "";


        }

        public RemoveCars()
        {
            InitializeComponent();
            Displayall(dgv);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            remove(txtModel.Text, txrManufacturer.Text, Convert.ToInt32(txtYear.Text));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Displayall(dgv);
        }
    }
}
