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
    public partial class Newacc : Form
    {
        public Newacc()
        {
            InitializeComponent();
        }
        public void save(string firstname,string lastname,string email,string password)
        {
    
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog= CarDataBase;Integrated Security=True");
            string q = "InsertToCustomer";
            string q1 = "InsertLogin";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType=CommandType.StoredProcedure; 
            cmd.Parameters.AddWithValue("@FirstName", firstname);
            cmd.Parameters.AddWithValue("@LastName", lastname);
            cmd.Parameters.AddWithValue("@email", email);
            SqlCommand cm = new SqlCommand(q1, con);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@email", email);
            cm.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                con.Open();
                MessageBox.Show("Succefully connected");
                cmd.ExecuteNonQuery();
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(firstname + " ,has been Successfully Registered!!!");
                txtFirstname.Text = "";
                txtLastname.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            save(txtFirstname.Text,txtLastname.Text,txtEmail.Text,txtPassword.Text);
        }
    }
}
