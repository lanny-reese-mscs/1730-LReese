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

namespace LReeseEx3A
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
            resultTextBox0.Text = Ex3aLoops.Calc0(inputTextbox0a.Text, inputTexrBox0b.Text, inputTextBox0c.Text);
            resultTextBox1.Text = Ex3aLoops.Calc1(inputTextbox1a.Text, inputTexrBox1b.Text, inputTextBox1c.Text);
            resultTextBox2.Text = Ex3aLoops.Calc2(inputTextbox2a.Text, inputTexrBox2b.Text, inputTextBox2c.Text);
            resultTextBox3.Text = Ex3aLoops.Calc3(inputTextbox3a.Text, inputTexrBox3b.Text, inputTextBox3c.Text);
            resultTextBox4.Text = Ex3aLoops.Calc4(inputTextbox4a.Text, inputTexrBox4b.Text, inputTextBox4c.Text);
            resultTextBox5.Text = Ex3aLoops.Calc5(inputTextbox5a.Text, inputTexrBox5b.Text, inputTextBox5c.Text);
            resultTextBox6.Text = Ex3aLoops.Calc6(inputTextbox6a.Text, inputTextBox6b.Text);
            resultTextBox7.Text = Ex3aLoops.Calc7(inputTextbox7a.Text, inputTextBox7b.Text);
            resultTextBox8.Text = Ex3aLoops.Calc8(inputTextbox8a.Text, inputTextBox8b.Text);
            //inputTextbox0a.Text, inputTexrBox0b.Text, inputTextBox0c.Text
        }
    }
}
