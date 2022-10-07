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
    public partial class SellerInfo : UserControl
    {
        private string _name;
        private string _message;
        private string _phone;
        private string _email;

        public string Name
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; lblMessage.Text = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; lblPhone.Text = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; lblEmail.Text = value; }
        }
        public void remove(string name, string email)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog= CarDataBase;Integrated Security=True");
            string q = "RemoveSeller";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                con.Open();
                MessageBox.Show("Succefully connected");
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(name+ " ,has been Successfully Removed!!!");
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

        }
        public SellerInfo()
        {
            InitializeComponent();
            lblMessage.MaximumSize = new Size (300, 0);
            lblMessage.AutoSize = true;   
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            remove(Name, Email);
        }
    }
}
