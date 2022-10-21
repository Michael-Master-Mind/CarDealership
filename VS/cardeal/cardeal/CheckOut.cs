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

namespace cardeal
{
    public partial class CheckOut : Form
    {
        public int carid;
        public string email;
        public int card_id;

        public CheckOut()
        {
            InitializeComponent();
        }

        public CheckOut(int carid, string email)
        {
            InitializeComponent();
            this.carid = carid;
            getCar(this.carid);
            this.email = email;
        }

        public void getCar(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog= CarDataBase;Integrated Security=True");
            string q = "GetCar";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@carid", id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dt.Rows[0][0].ToString();
                CarInfo ci = new CarInfo();
                ci.Model = dt.Rows[0][1].ToString();
                ci.Manufacturer = dt.Rows[0][2].ToString();
                ci.Year = dt.Rows[0][3].ToString();
                ci.Price = dt.Rows[0][4].ToString();
                flowLayoutPanel1.Controls.Add(ci);
              
                con.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }


        }
        public int getCustId(string email)
        {
            int custid=0;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog= CarDataBase;Integrated Security=True");
            string q = "GetCustomerId";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);

            try
            {
                con.Open();
                custid=(int)cmd.ExecuteScalar();
                con.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            return custid;
        }

        public void GenerateInvoice(int custid,int carid,string address,int cardid,int cardno,string firstname)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog= CarDataBase;Integrated Security=True");
            string q = "InsertCheckOut";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@custid",custid);
            cmd.Parameters.AddWithValue("@carid", carid);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@cardid", cardid);
            cmd.Parameters.AddWithValue("@cardno",cardno);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Invoice"+'\n'+
                                "First Name:"+firstname+'\n'+
                                "Email:"+email+'\n'+
                                "CarID:"+carid+'\n'+'\n'+
                                "Successfully Purschased");
                con.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }


        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (cmbCardType.SelectedItem.ToString() == "Master Card")
                card_id = 1;
            else if (cmbCardType.SelectedItem.ToString() == "Visa Card")
                card_id = 2;
            else
                card_id = 3;
            //int cardno = Convert.ToInt32(txtCardno.Text);

            GenerateInvoice(getCustId(email), carid, txtAddress.Text, card_id, Convert.ToInt32(txtYear.Text), txtFirstName.Text);
        }
    }
}
