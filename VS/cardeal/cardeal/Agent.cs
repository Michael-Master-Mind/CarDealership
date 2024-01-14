using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

using System.Windows.Media;

using SeriesCollection = LiveCharts.SeriesCollection;

namespace cardeal
{
    public partial class Agent : Form
    {
        public Agent()
        {
            InitializeComponent();
        }
        public Agent(string s)
        {
            InitializeComponent();
            lblUser.Text = s;
        }
        public void loadform(object Form)
        {
            if (this.AgentPanel.Controls.Count > 0)
                this.AgentPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.AgentPanel.Controls.Add(f);
            this.AgentPanel.Tag = f;
            f.Show();

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btnload_Click(object sender, EventArgs e)
        {
            
        }

        private void panelhome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            loadform(new AddCars());
        }

        private void lblRemoveCars_Click(object sender, EventArgs e)
        {
            loadform(new RemoveCars());
        }

        private void lblSellers_Click(object sender, EventArgs e)
        {
            loadform(new Sellers());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click_1(object sender, EventArgs e)
        {
            loadform(new Dash());
        }
    }
}
