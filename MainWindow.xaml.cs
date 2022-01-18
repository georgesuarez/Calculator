using Calculator.ViewModels;
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
        long numberOne = 0;
        long numberTwo = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void appendSameNumber(int num, long numberOne, long numberTwo, string operation)
        {
            if (operation == "")
            {
                numberOne = (numberOne * 10) + num;
                TextDisplay.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + num;
                TextDisplay.Text = numberTwo.ToString();
            }

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numberOne = (numberOne * 10) + 1;
                TextDisplay.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 1;
                TextDisplay.Text = numberTwo.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numberOne = (numberOne * 10) + 2;
                TextDisplay.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 2;
                TextDisplay.Text = numberTwo.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numberOne = (numberOne * 10) + 3;
                TextDisplay.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 3;
                TextDisplay.Text = numberTwo.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numberOne = (numberOne * 10) + 4;
                TextDisplay.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 4;
                TextDisplay.Text = numberTwo.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numberOne = (numberOne * 10) + 5;
                TextDisplay.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 5;
                TextDisplay.Text = numberTwo.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numberOne = (numberOne * 10) + 6;
                TextDisplay.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 6;
                TextDisplay.Text = numberTwo.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numberOne = (numberOne * 10) + 7;
                TextDisplay.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 7;
                TextDisplay.Text = numberTwo.ToString();
            }

        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numberOne = (numberOne * 10) + 8;
                TextDisplay.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 8;
                TextDisplay.Text = numberTwo.ToString();
            }

        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numberOne = (numberOne * 10) + 9;
                TextDisplay.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 9;
                TextDisplay.Text = numberTwo.ToString();
            }

        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numberOne = (numberOne * 10);
                TextDisplay.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10);
                TextDisplay.Text = numberTwo.ToString();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            TextDisplay.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            TextDisplay.Text = "0";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            TextDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            TextDisplay.Text = "0";
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    TextDisplay.Text = (numberOne + numberTwo).ToString();
                    break;
                case "-":
                    TextDisplay.Text= (numberTwo - numberOne).ToString();
                    break;
                case"*":
                    TextDisplay.Text= (numberOne * numberTwo).ToString();
                    break;
                case "/":
                    TextDisplay.Text= (numberOne / numberTwo).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numberOne = 0;
            }
            else
            {
                numberTwo = 0;
            }

            TextDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            numberOne = 0;
            numberTwo = 0;
            operation = "";
            TextDisplay.Text = "0";
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numberOne = (numberOne / 10);
                TextDisplay.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo / 10);
                TextDisplay.Text = numberTwo.ToString();
            }
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                numberOne *= -1;
                TextDisplay.Text = numberOne.ToString();
            }
            else
            {
                numberTwo *= -1;
                TextDisplay.Text = numberTwo.ToString();
            }
        }
    }
}
