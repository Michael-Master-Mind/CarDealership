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
    public partial class Sellers : Form
    {
        public Sellers()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TV36L87C\SQLEXPRESS;Initial Catalog=CarDataBase;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select  name,phone,email,message from Seller", con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                int r = 0;
                while (sdr.Read())
                {
                    SellerInfo si = new SellerInfo();
                    si.Name = sdr["name"].ToString();
                    si.Message = sdr["message"].ToString();
                    si.Phone = sdr["phone"].ToString();
                    si.Email = sdr["email"].ToString();

                    flowLayoutPanel1.Controls.Add(si);
                    
                    r++;
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }
    }
}
