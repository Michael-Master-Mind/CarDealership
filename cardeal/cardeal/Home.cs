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
    public partial class Home : Form
    { 
        bool sidebarExpand;
        public Home()
        {
            InitializeComponent();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            H h= new H();
            h.TopLevel = false;
            panelhome.Controls.Add(h);
            h.BringToFront();
            h.Hide();
            h.Show();
            indicator.Top = 20;
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            indicator.Top = 80;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            indicator.Top = 140;
            panelhome.Visible = false;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            indicator.Top = 200;
            panelhome.Visible = false;
        }
        private void label19_Click(object sender, EventArgs e)
        {
            indicator.Top = 580;
            panelhome.Visible = false;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {
            sign s= new sign();
            s.Show();
        }
    }
}
