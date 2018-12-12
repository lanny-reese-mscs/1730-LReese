using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LReeseEx3B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcbutton_Click(object sender, RoutedEventArgs e)
        {

        //0
            try
            {
                decimal subtotal = decimal.Parse(this.inputTextbox0a.Text);
                decimal discountPercent = Ex3bCalculations.GetDiscountPercent(subtotal);
                resultTextBox0.Text = discountPercent.ToString("f3");
            }
            catch
            {
                resultTextBox0.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextbox0a.Text);
            }

            //1
            try
            {
                decimal subtotal = decimal.Parse(this.inputTextbox0a.Text);
                decimal discountPercent;
                Ex3bCalculations.GetDiscountPercent(subtotal, out discountPercent);
                resultTextBox1.Text = discountPercent.ToString("f3");
            }
            catch
            {
                resultTextBox1.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextbox1a.Text);
            }

            //2
            try
            {
                int months = Int32.Parse(this.inputTextbox2a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTexrBox2b.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextBox2c.Text);
                decimal furtureValue = Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);

                resultTextBox2.Text = furtureValue.ToString("c2");
            }
            catch
            {
                resultTextBox2.Text = "";
                MessageBox.Show("Invalid input: \n"
                    + this.inputTextbox2a.Text + "\n"
                    + this.inputTexrBox2b.Text + "\n"
                    + this.inputTextBox2c.Text + "\n");
            }

            //3
            try
            {
                int months = Int32.Parse(this.inputTextbox3a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTexrBox3b.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextBox3c.Text);
                decimal futureValue = 0m;
                Ex3bCalculations.CalculateFutureValue(
                    monthlyInvestment, monthlyInterestRate, months, ref futureValue);

                resultTextBox3.Text = futureValue.ToString("c2");
            }
            catch
            {
                resultTextBox3.Text = "";
                MessageBox.Show("Invalid input: \n"
                    + this.inputTextbox3a.Text + "\n"
                    + this.inputTexrBox3b.Text + "\n"
                    + this.inputTextBox3c.Text + "\n");
            }

            //4
            try
            {
                double Fahrenheit = Double.Parse(this.inputTextbox4a.Text);
                double Celsius = Ex3bCalculations.FahrenheitToCelsius(Fahrenheit);

                resultTextBox4.Text = Celsius.ToString("f1");
            }
            catch
            {
                resultTextBox4.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextbox4a.Text);
            }

            //5
            try
            {
                double Celsius = Double.Parse(this.inputTextbox5a.Text);
                double fahrenheit;
                Ex3bCalculations.CelsiusToFahrenheit(Celsius, out fahrenheit);

                resultTextBox5.Text = fahrenheit.ToString("f1");
            }
            catch
            {
                resultTextBox5.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextbox5a.Text);
            }

            //6
            try
            {
                decimal Hours = decimal.Parse(this.inputTextbox6a.Text);
                decimal Rate = decimal.Parse(this.inputTextBox6b.Text);
                decimal Celsius = Ex3bCalculations.GrossPay(Hours, Rate);

                resultTextBox6.Text = Celsius.ToString("c2");
            }
            catch
            {
                resultTextBox6.Text = "";
                MessageBox.Show("Invalid input: \n"
                    + this.inputTextbox6a.Text + "\n"
                    + this.inputTextBox6b.Text);
            }

            //7
            try
            {
                this.resultTextBox7.Text =
                    Ex3bCalculations.TotalHours(this.inputTextbox7a.Text).ToString("n2");
            }
            catch
            {
                this.resultTextBox7.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextbox7a.Text);
            }

            //8
            try
            {
                decimal rate = Decimal.Parse(this.inputTextBox8b.Text);
                this.resultTextBox8.Text =
                    Ex3bCalculations.GrossPay(this.inputTextbox8a.Text, rate).ToString("c2");
            }
            catch
            {
                this.resultTextBox8.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextbox8a.Text + "\n"
                    + this.inputTextBox8b.Text);
            }
        }
    }
}
