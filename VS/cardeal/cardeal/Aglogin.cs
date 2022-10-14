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
    public partial class Aglogin : Form
    {
        public Aglogin()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Agent a= new Agent();
            a.TopLevel = false;
            panelhome.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }
    }
}
