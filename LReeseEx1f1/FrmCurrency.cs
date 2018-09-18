using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LReeseEx1f1
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            txtcurrency.Focus();
            btnaust.BackgroundImage = picAust.Image;
            btnbhut.BackgroundImage = picbhutdim.Image;
            btncosta.BackgroundImage = piccostadim.Image;
            btneuro.BackgroundImage = piceurodim.Image;
            txtrate.Text = "0.717976";
            lblcurrency.Text = btnaust.Text + ": ";
            txtcurrency.Text = "0.00";
            txtTotal.Text = "0.00";
            txtUS.Text = "0.00";
            lbltotal.Text = "";
        }

        private void btnaust_Click(object sender, EventArgs e)
        {
            btnaust.BackgroundImage = picAust.Image;
            btnbhut.BackgroundImage = picbhutdim.Image;
            btneuro.BackgroundImage = piceurodim.Image;
            btncosta.BackgroundImage = piccostadim.Image;
            txtrate.Text = "0.717976";
            lblcurrency.Text = btnaust.Text + ": ";
            txtcurrency.Focus();
        }

        private void btnbhut_Click(object sender, EventArgs e)
        {
            btnbhut.BackgroundImage = picbhut.Image;
            btnaust.BackgroundImage = picAustdim.Image;
            btncosta.BackgroundImage = piccostadim.Image;
            btneuro.BackgroundImage = piceurodim.Image;
            txtrate.Text = "0.0139831";
            lblcurrency.Text = btnbhut.Text + ": ";
            txtcurrency.Focus();
        }

        private void btncosta_Click(object sender, EventArgs e)
        {
            btncosta.BackgroundImage = piccosta.Image;
            btnaust.BackgroundImage = picAustdim.Image;
            btnbhut.BackgroundImage = picbhutdim.Image;
            btneuro.BackgroundImage = piceurodim.Image;
            txtrate.Text = "0.00176040";
            lblcurrency.Text = btncosta.Text + ": ";
            txtcurrency.Focus();
        }

        private void btneuro_Click(object sender, EventArgs e)
        {
            btncosta.BackgroundImage = piccostadim.Image;
            btnaust.BackgroundImage = picAustdim.Image;
            btnbhut.BackgroundImage = picbhutdim.Image;
            btneuro.BackgroundImage = piceuro.Image;
            txtrate.Text = "1.16235";
            lblcurrency.Text = btneuro.Text + ": ";
            txtcurrency.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUS.Text = (
                Convert.ToDecimal(txtcurrency.Text)
                * Convert.ToDecimal(txtrate.Text)
                ).ToString("0.00");
        }

        private void txtcurrency_Enter(object sender, EventArgs e)
        {
            txtcurrency.SelectAll();
        }

        private void txtcurrency_MouseClick(object sender, MouseEventArgs e)
        {
            txtcurrency.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (Convert.ToDecimal(txtUS.Text) 
                + Convert.ToDecimal(txtTotal.Text)
                ).ToString("0.00");
            lbltotal.Text = lbltotal.Text + " + " + txtUS.Text;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnaust.BackgroundImage = picAust.Image;
            btnbhut.BackgroundImage = picbhutdim.Image;
            btncosta.BackgroundImage = piccostadim.Image;
            btneuro.BackgroundImage = piceurodim.Image;
            txtrate.Text = "0.717976";
            lblcurrency.Text = btnaust.Text + ": ";
            txtcurrency.Text = "0.00";
            txtTotal.Text = "0.00";
            txtUS.Text = "0.00";
            lbltotal.Text = "";
            txtcurrency.Focus();
        }
    }
}
