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
    public partial class settings : Form
    {
        public string email;
        public settings()
        {
            InitializeComponent();
        }
        public settings(string email)
        {
            InitializeComponent();
            if (email != "Sign in")
            {
                this.email = email;
                GetCust_info(this.email);
            }
        }
        public void GetCust_info(string oldemail)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog= CarDataBase;Integrated Security=True");
            string q = "GetCustomerInfo";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@oldemail",oldemail);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader sdr = cmd.ExecuteReader();
                int r = 0;
                while (sdr.Read())
                {
                    lblFirstName.Text = sdr["firstname"].ToString();
                    lblLastName.Text = sdr["lastname"].ToString();
                    lblEmail.Text = sdr["email"].ToString();
                    lblPassword.Text = sdr["password"].ToString();
                }
                con.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }
        public void Update_custInfo(string oldemail,string firstname, string lastname, string email, string password)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog= CarDataBase;Integrated Security=True");
            string q = "UpdateCustomerInfo";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@oldemail", oldemail);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader sdr = cmd.ExecuteReader();
                MessageBox.Show("Update Successful!!!");
                con.Close();
            }catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }
                private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            Update_custInfo(email, txtChangeFirstName.Text, txtChangeLastName.Text, txtChangeEmail.Text, txtChangePassword.Text);
            txtChangeFirstName.Text = "";
            txtChangeLastName.Text = "";
            txtChangeEmail.Text = "";
            txtChangePassword.Text = "";
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            GetCust_info(txtChangeEmail.Text);
        }
    }
}
