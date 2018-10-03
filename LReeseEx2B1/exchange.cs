using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LReeseEx2B1
{
    public partial class exchange : Form
    {
        public exchange()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAust = Convert.ToDecimal(txtAustAmount.Text);
            decimal rateAust = Convert.ToDecimal(txtAustRate.Text);
            decimal usAust = amountAust * rateAust;
            txtAustUS.Text = usAust.ToString("0.00");

            decimal amountBhut = Convert.ToDecimal(txtBhutAmount.Text);
            decimal rateBhut = Convert.ToDecimal(txtBhutRate.Text);
            decimal usBhut = amountBhut * rateBhut;
            txtBhutUS.Text = usBhut.ToString("0.00");

            decimal amountEuro = Convert.ToDecimal(txtEuroAmount.Text);
            decimal rateEuro = Convert.ToDecimal(txtEuroRate.Text);
            decimal usEuro = amountEuro * rateEuro;
            txtEuroUS.Text = usEuro.ToString("0.00");

            decimal amountCosta = Convert.ToDecimal(txtCostaAmount.Text);
            decimal rateCosta = Convert.ToDecimal(txtCostaRate.Text);
            decimal usCosta = amountCosta * rateCosta;
            txtCostaUS.Text = usCosta.ToString("0.00");

            decimal USDollar = usAust + usBhut + usCosta + usEuro;
            txtUSDollar.Text = USDollar.ToString("0.00");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
