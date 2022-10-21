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
    public partial class Dash : Form
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
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Cars");
                dgv.DataSource = ds.Tables["Cars"];

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }
        public void loadLabels(Label l, Label l2, Label l3, Label l4, Label l5, Label l6)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TV36L87C\SQLEXPRESS;Initial Catalog=CarDataBase;Integrated Security=True");
            string q1 = "CarTotalCount";
            string q2 = "MostExpensive";
            string q3 = "CheapestCar";
            string q4 = "OldestCar";
            string q5 = "LatestCar";
            string q6 = "AmountOfPurchase";
            SqlCommand cmd1 = new SqlCommand(q1, con);
            SqlCommand cmd2 = new SqlCommand(q2, con);
            SqlCommand cmd3 = new SqlCommand(q3, con);
            SqlCommand cmd4 = new SqlCommand(q4, con);
            SqlCommand cmd5 = new SqlCommand(q5, con);
            SqlCommand cmd6 = new SqlCommand(q6, con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd4.CommandType = CommandType.StoredProcedure;
            cmd5.CommandType = CommandType.StoredProcedure;
            cmd6.CommandType = CommandType.StoredProcedure;

            try
            {
                con.Open();
                int s1 = (int)cmd1.ExecuteScalar();
                string s2 = cmd2.ExecuteScalar().ToString();
                string s3 = cmd3.ExecuteScalar().ToString();
                string s4 = cmd4.ExecuteScalar().ToString();
                string s5 = cmd5.ExecuteScalar().ToString();
                string s6 = cmd6.ExecuteScalar().ToString();
                l.Text = s1.ToString();
                l2.Text = s2;
                l3.Text = s3;
                l4.Text = s4;
                l5.Text = s5;
                l6.Text = s6;
                con.Close();

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }
        public Dash()
        {
            InitializeComponent();
            Displayall(dgv);
            loadLabels(lblTotalCount, lblExpensive, lblCheapest, lblOldest, lblLastest, lblPurhcases);
        }
    }
}
