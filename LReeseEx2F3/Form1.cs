using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LReeseEx2F3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            //#1 if
            textBox1result.Text = Ex2fCalculations.Calc01(textBox1.Text);

            // #2 if {block}
            textBox2result.Text = Ex2fCalculations.Calc02(textBox2.Text);

            //#3 if else
            textBox3result.Text = Ex2fCalculations.Calc03(textBox3.Text);

            //#4 if else if
            textBox4result.Text = Ex2fCalculations.Calc04(textBox4.Text);

            //#5 Range Test
            textBox5result.Text = Ex2fCalculations.Calc05(textBox5.Text);

            //#6 nested if
            textBox6result.Text = Ex2fCalculations.Calc06(textBox6.Text, textBox6a.Text);

            //#7 input valadation
            textBox7result.Text = Ex2fCalculations.Calc07(textBox7.Text);

            //#8
            textBox8result.Text = Ex2fCalculations.Calc08(textBox8.Text, textBox8a.Text);

            //#9
            textBox9result.Text = Ex2fCalculations.Calc09(textBox9.Text, textBox9a.Text);

            //#10
            textBox10result.Text = Ex2fCalculations.Calc10(textBox10.Text, textBox10a.Text);
        }
    }
}
