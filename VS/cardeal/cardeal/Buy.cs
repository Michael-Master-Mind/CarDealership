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
    public partial class Buypanel : Form
    {
        public Buypanel()
        {
            InitializeComponent();
        }
        
        private void panelhome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void G2_Click(object sender, EventArgs e)
        {
            Get g = new Get();
            g.TopLevel = false;
            panelhome.Controls.Add(g);
            g.BringToFront();
            g.Show();
        }

        private void lamboGet_Click(object sender, EventArgs e)
        {
            Get1 g = new Get1();
            g.TopLevel = false;
            panelhome.Controls.Add(g);
            g.BringToFront();
            g.Show();
        }

        private void f488Get_Click(object sender, EventArgs e)
        {
            Get2 g = new Get2();
            g.TopLevel = false;
            panelhome.Controls.Add(g);
            g.BringToFront();
            g.Show();
        }
    }
}
