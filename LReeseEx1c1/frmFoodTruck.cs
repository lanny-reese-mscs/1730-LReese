using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LReeseEx1c1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHotDogSubtotal.Text = (
                    4.0m 
                    * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00");
            txtHamburgersSubtotal.Text = (
                    5.0m 
                    * Convert.ToDecimal(txtHamburgers.Text)
                ).ToString("0.00");
            txtPretaxTotal.Text = 
                    (Convert.ToDecimal(txtHotDogSubtotal.Text)
                    + Convert.ToDecimal(txtHamburgersSubtotal.Text)
                ).ToString("0.00");
            txtTax.Text = 
                    (Convert.ToDecimal(txtPretaxTotal.Text)
                    * 0.06875m
                ).ToString("0.00");
            txtTotal.Text =
                    (Convert.ToDecimal(txtPretaxTotal.Text)
                    + Convert.ToDecimal(txtTax.Text)
                ).ToString("0.00");

            btnClear.Focus();
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            txtHotDogs.Focus();
        }
    }
}
