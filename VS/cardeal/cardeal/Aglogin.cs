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
    public partial class Aglogin : Form
    {
        public Aglogin()
        {
            InitializeComponent();
        }
        public void agentSign_in(string name, string password)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog= CarDataBase;Integrated Security=True");
            string q = "AgentSignIn";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
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
                    Agent a = new Agent(name);
                    a.TopLevel = false;
                    panelhome.Controls.Add(a);
                    a.BringToFront();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
                con.Close();

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            agentSign_in(txtName.Text, txtPassword.Text);
        }
    }
}
