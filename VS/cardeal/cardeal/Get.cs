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
    public partial class Get : Form
    {
        public Get()
        {
            InitializeComponent();
        }


        private void panelhome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            CheckOut ck = new CheckOut();
            ck.Hide();
            ck.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Buypanel b=new Buypanel();
            b.TopLevel = false;
            panelb.Controls.Add(b);
            b.BringToFront();
            b.Show();
        }
    }
}
