using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LReeseEx2d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setPassValuesButton_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "Frank";
            textBox2input.Text = "";
            textBox3input.Text = "2.3";
            textBox4input.Text = "false";
            textBox5inputA.Text = "2";
            textBox5inputB.Text = "2";
            textBox6input.Text = "xyz";
            textBox7input.Text = "1";
            textBox8inputA.Text = "1";
            textBox8inputB.Text = "2";
            textBox9input.Text = "500";
            textBox10inputA.Text = "3";
            textBox10inputB.Text = "3";
        }

        private void setFailsValuesButton_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "xyz";
            textBox2input.Text = "xyz";
            textBox3input.Text = "2.4";
            textBox4input.Text = "true";
            textBox5inputA.Text = "2";
            textBox5inputB.Text = "3";
            textBox6input.Text = "Jones";
            textBox7input.Text = "0";
            textBox8inputA.Text = "1";
            textBox8inputB.Text = "1";
            textBox9input.Text = "499";
            textBox10inputA.Text = "4";
            textBox10inputB.Text = "3";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            textBox1output.Text = "Fail";
            textBox2output.Text = "Fail";
            textBox3output.Text = "Fail";
            textBox4output.Text = "Fail";
            textBox5output.Text = "Fail";
            textBox6output.Text = "Fail";
            textBox7output.Text = "Fail";
            textBox8output.Text = "Fail";
            textBox9output.Text = "Fail";
            textBox10output.Text = "Fail";

            textBox1outputB.Text = "Success";
            textBox2outputB.Text = "Success";
            textBox3outputB.Text = "Success";
            textBox4outputB.Text = "Success";
            textBox5outputB.Text = "Success";
            textBox6outputB.Text = "Success";
            textBox7outputB.Text = "Success";
            textBox8outputB.Text = "Success";
            textBox9outputB.Text = "Success";
            textBox10outputB.Text = "Success";

            if (textBox1input.Text == "Frank")
                textBox1output.Text = "Success";
            if (textBox1input.Text != "Frank")
                textBox1outputB.Text = "Fail";

            if (textBox2input.Text == "")
                textBox2output.Text = "Success";
            if (textBox2input.Text != "")
                textBox2outputB.Text = "Fail";

            decimal val3 = Convert.ToDecimal(textBox3input.Text);
            if (val3 == 2.3m)
                textBox3output.Text = "Success";
            if (val3 != 2.3m)
                textBox3outputB.Text = "Fail";

            bool val4 = Convert.ToBoolean(textBox4input.Text);
            if (val4 == false)
                textBox4output.Text = "Success";
            if (val4 != false)
                textBox4outputB.Text = "Fail";

            decimal val5A = Convert.ToDecimal(textBox5inputA.Text);
            decimal val5B = Convert.ToDecimal(textBox5inputB.Text);
            if (val5A == val5B)
                textBox5output.Text = "Success";
            if (val5A != val5B)
                textBox5outputB.Text = "Fail";

            if (textBox6input.Text != "Jones")
                textBox6output.Text = "Success";
            if (textBox6input.Text == "Jones")
                textBox6outputB.Text = "Fail";

            decimal val7 = Convert.ToDecimal(textBox7input.Text);
            if (val7 > 0)
                textBox7output.Text = "Success";
            if (val7 <= 0)
                textBox7outputB.Text = "Fail";

            decimal val8A = Convert.ToDecimal(textBox8inputA.Text);
            decimal val8B = Convert.ToDecimal(textBox8inputB.Text);
            if (val8A < val8B)
                textBox8output.Text = "Success";
            if (val8A >= val8B)
                textBox8outputB.Text = "Fail";

            decimal val9 = Convert.ToDecimal(textBox9input.Text);
            if (val9 >= 500)
                textBox9output.Text = "Success";
            if (val9 < 500)
                textBox9outputB.Text = "Fail";

            decimal val10A = Convert.ToDecimal(textBox10inputA.Text);
            decimal val10B = Convert.ToDecimal(textBox10inputB.Text);
            if (val10A <= val10B)
                textBox10output.Text = "Success";
            if (val10A > val10B)
                textBox10outputB.Text = "Fail";
        }
    }
}
