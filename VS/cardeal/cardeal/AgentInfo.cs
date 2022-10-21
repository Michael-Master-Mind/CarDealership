using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cardeal
{
    public partial class AgentInfo : UserControl
    {
        private string _name;
        private string _location;
        private string _email;
        private string _phone;

        public string Name
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; lblLocation.Text = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; lblEmail.Text = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; lblPhone.Text = value; }
        }

        public AgentInfo()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
