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
    public partial class CarInfo : UserControl
    {
        private string _model;
        private string _manufacturer;
        private string _year;
        private string _price;

        public string Model
        {
            get { return _model; }
            set { _model = value; lblModel.Text = value; }
        }
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; lblManufacturer.Text = value; }
        }
        public string Year
        {
            get { return _year; }
            set { _year = value; lblYear.Text = value; }
        }
        public string Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value; }
        }
        public CarInfo()
        {
            InitializeComponent();
        }
    }
}
