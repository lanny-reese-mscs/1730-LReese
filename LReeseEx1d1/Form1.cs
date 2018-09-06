using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LReeseEx1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AustTextChanged(object sender, EventArgs e)
        {
            txtAustUS.Text = (
                Convert.ToDecimal(txtAustAmount.Text)
                * Convert.ToDecimal(txtAustRate.Text)
                ).ToString("0.00");
        }

        private void BhutTextChanged(object sender, EventArgs e)
        {
            txtBhutUS.Text = (
                Convert.ToDecimal(txtBhutAmount.Text)
                * Convert.ToDecimal(txtBhutRate.Text)
                ).ToString("0.00");
        }

        private void CostaTextChanged(object sender, EventArgs e)
        {
            txtCostaUS.Text = (
                Convert.ToDecimal(txtCostaAmount.Text)
                * Convert.ToDecimal(txtCostaRate.Text)
                ).ToString("0.00");
        }

        private void EuroTextChanged(object sender, EventArgs e)
        {
            txtEuroUS.Text = (
               Convert.ToDecimal(txtEuroAmount.Text)
               * Convert.ToDecimal(txtEuroRate.Text)
               ).ToString("0.00");
        }

        private void txtUSDollar_TextChanged(object sender, EventArgs e)
        {

        }

        private void USTextChanged(object sender, EventArgs e)
        {
            txtUSDollar.Text = (
                Convert.ToDecimal(txtAustUS.Text)
                + Convert.ToDecimal(txtBhutUS.Text)
                + Convert.ToDecimal(txtCostaUS.Text)
                + Convert.ToDecimal(txtEuroUS.Text)
                ).ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAustAmount.Text = "0.00";
            txtAustRate.Text = "0.717976";
            txtBhutAmount.Text = "0.00";
            txtBhutRate.Text = "0.0139831";
            txtCostaAmount.Text = "0.00";
            txtCostaRate.Text = "0.00176040";
            txtEuroAmount.Text = "0.00";
            txtEuroRate.Text = "1.16235";
        }
    }
}
