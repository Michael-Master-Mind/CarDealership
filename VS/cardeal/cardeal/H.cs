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
    public partial class H : Form
    {
        public H()
        {
            InitializeComponent();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            sign s = new sign();
            s.Show();
        }
    }
}
