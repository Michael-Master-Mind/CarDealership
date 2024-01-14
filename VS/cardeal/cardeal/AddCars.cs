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
    public partial class AddCars : Form
    {
        public AddCars()
        {
            InitializeComponent();
        }
        public void add(string model, string manufacturer, int year, double price, int kilometer)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog= CarDataBase;Integrated Security=True");
            string q = "AddCar";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@manufacturer", manufacturer);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@kilometer", kilometer);
            try
            {
                con.Open();
                MessageBox.Show("Succefully connected");
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(manufacturer + " "+model +" ,has been Successfully Registered!!!");
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            txtModel.Text = "";
            txrManufacturer.Text = "";
            txtYear.Text = "";
            txtPrice.Text = "";
            txtKilometer.Text = "";


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add(txtModel.Text, txrManufacturer.Text, Convert.ToInt32(txtYear.Text), Convert.ToDouble(txtPrice.Text),Convert.ToInt32(txtKilometer.Text));
        }
    }
}
