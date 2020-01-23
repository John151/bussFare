using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussFare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double busfare = 2.0;
            int trips;

            if (Int32.TryParse(txtTrips.Text, out trips))
            {
                double total = busfare * trips;
                txtTotal.Text = "$" + total;
            }
            else
            {
                MessageBox.Show("Enter only numbers", "Error");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
