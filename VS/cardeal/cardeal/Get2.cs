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
    public partial class Get2 : Form
    {
        public Get2()
        {
            InitializeComponent();
        }
        public Get2(string email)
        {
            InitializeComponent();
            lblSignin.Text = email;
        }


        private void rjButton2_Click(object sender, EventArgs e)
        {
            CheckOut ck = new CheckOut(3,lblSignin.Text);
            ck.Hide();
            ck.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Buypanel b = new Buypanel();
            b.TopLevel = false;
            panelb.Controls.Add(b);
            b.BringToFront();
            b.Show();
        }
    }
}
