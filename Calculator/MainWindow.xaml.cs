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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public string ArithOp{ get; set; }
        public MainWindow()
        {
            InitializeComponent();
    }

        private void btnAddition_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += "+";
            ArithOp = "+";

        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += "-";
            ArithOp = "-";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += "x";
            ArithOp = "x";
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += "÷";
            ArithOp = "÷";
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += "1";
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += "2";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += "3";
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += "4";
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += "5";
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += "6";
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += "7";
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += "8";
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += "9";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text = "";
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += "0";
        }

        private void btnDecimalPoint_Click(object sender, RoutedEventArgs e)
        {
            TbDisplay.Text += ".";
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            double result;
            string calc = TbDisplay.Text;
            string[] calcValues = calc.Split(ArithOp);

            num1 = Double.Parse(calcValues[0]);
            num2 = Double.Parse(calcValues[1]);

            switch (ArithOp)
            {
                default:
                    result = -1;
                    break;
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "x":
                    result = num1 * num2;
                    break;
                case "÷":
                    result = num1 / num2;
                    break;
            }
            TbDisplay.Text = "";
            string numOutput = result.ToString();
            TbDisplay.Text = numOutput;
        }
    }
}
