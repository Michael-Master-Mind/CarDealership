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
    public partial class signin : Form
    {
        
        public signin()
        {
            InitializeComponent();
        }
        public void customerSign_in(string email, string password)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog= CarDataBase;Integrated Security=True");
            string q = "CheckSignIn";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            try
            {
                con.Open();
                MessageBox.Show("Succefully connected");
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Sign-in Successful!!!");
                    Home h = new Home(email);
                    h.Show();

                }
                else
                {
                    MessageBox.Show("Incorrect Email or Password!!!");
                }
                con.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            customerSign_in(txtEmail.Text,txtPassword.Text);
        }
    }
}
