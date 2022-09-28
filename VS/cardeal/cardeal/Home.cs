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
        public void loadform(object Form)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f= Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        
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
            loadform(new H());
            indicator.Top = 20;
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            loadform(new Buy());
            indicator.Top = 80;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            loadform(new Sell());
            indicator.Top = 140;
            
        }
        private void label4_Click(object sender, EventArgs e)
        {
            loadform(new Agent());
            indicator.Top = 200;
        }
        private void label19_Click(object sender, EventArgs e)
        {
            loadform(new settings());
            indicator.Top = 580;
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

        private void rjButton1_Click(object sender, EventArgs e)
        {
            sign s = new sign();
            s.Show();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label27_Click_1(object sender, EventArgs e)
        {
            sign s = new sign();
            s.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panelhome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}
