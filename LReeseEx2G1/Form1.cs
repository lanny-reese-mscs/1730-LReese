using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LReeseEx2G1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1A Switch with no default
            resultSwitchTextbox01.Text = Ex2gCalculations.Switch01(textBox1a.Text);

            //1B IF with no default
            resultifTextbox01.Text = Ex2gCalculations.If01(textBox1a.Text);

            //1C else IF with no default
            resultelseifTextbox03.Text = Ex2gCalculations.ElseIf01(textBox1a.Text);

            //1D nested IF with no default
            resultnestedifTextbox04.Text = Ex2gCalculations.NestedIfElse01(textBox1a.Text);

            //2A switch with default
            resultswitchdefaultTextbox05.Text = Ex2gCalculations.SwitchDefault01(textBox1a.Text);

            //2B IF with default
            resultifdefaultTextbox06.Text = Ex2gCalculations.IfDefault01(textBox1a.Text);

            //2C else IF with default
            resultelseifdefaultTextbox07.Text = Ex2gCalculations.ElseIfDefault01(textBox1a.Text);

            //2D nested IF with default
            resultnestedifdefaultTextbox08.Text = Ex2gCalculations.NestedIfElseDefault01(textBox1a.Text);

            //3A nested IF with default
            resultSwitchTextbox01b.Text = Ex2gCalculations.Switch02(textBox2a.Text);

            //3B IF with no default
            resultifTextbox01b.Text = Ex2gCalculations.If02(textBox2a.Text);

            //3C else IF with no default
            resultelseifTextbox03b.Text = Ex2gCalculations.ElseIf02(textBox2a.Text);

            //3D nested IF with no default
            resultnestedifTextbox04b.Text = Ex2gCalculations.NestedIfElse02(textBox2a.Text);
        }
    }
}
