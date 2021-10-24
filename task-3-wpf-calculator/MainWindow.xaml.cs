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

namespace task_3_wpf_calculator
{
    public partial class MainWindow : Window
    {

        double numA;
        char oper = '\x0000';

        public MainWindow()
        {
            InitializeComponent();
        }

        private void inputNum0(object sender, RoutedEventArgs e) { inputNum(0); }

        private void inputNum1(object sender, RoutedEventArgs e) { inputNum(1); }

        private void inputNum2(object sender, RoutedEventArgs e) { inputNum(2); }

        private void inputNum3(object sender, RoutedEventArgs e) { inputNum(3); }

        private void inputNum4(object sender, RoutedEventArgs e) { inputNum(4); }

        private void inputNum5(object sender, RoutedEventArgs e) { inputNum(5); }

        private void inputNum6(object sender, RoutedEventArgs e) { inputNum(6); }

        private void inputNum7(object sender, RoutedEventArgs e) { inputNum(7); }

        private void inputNum8(object sender, RoutedEventArgs e) { inputNum(8); }

        private void inputNum9(object sender, RoutedEventArgs e) { inputNum(9); }

        private void inputNum(int num)
        {
            if (textBox.Text == "Ошибка!")
            {
                textBox.Text = "";
            }
            if (oper != '\x0000')
            {
                numA = Convert.ToDouble(textBox.Text);
                textBox.Text = "";
            }
            textBox.Text += num.ToString();
        }

        private void click_c(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
            {
                numA = 0;
            }
            else
            {
                textBox.Text = "";
            }
        }

        private void calc(object sender, RoutedEventArgs e)
        {
            if (oper == '\x0000') return;
            double numB = Convert.ToDouble(textBox.Text);
            switch (oper)
            {
                case '-':
                    textBox.Text = (numA - numB).ToString();
                    break;
                case '+':
                    textBox.Text = (numA + numB).ToString();
                    break;
                case '/':
                    if (numB == 0)
                    {
                        textBox.Text = "Ошибка!";
                        break;
                    }
                    textBox.Text = (numA / numB).ToString();
                    break;
                case '*':
                    textBox.Text = (numA * numB).ToString();
                    break;
            }
            oper = '\x0000';
        }
        private void div(object sender, RoutedEventArgs e)
        {
            oper = '/';
        }
        private void plus(object sender, RoutedEventArgs e)
        {
            oper = '+';
        }
        private void mult(object sender, RoutedEventArgs e)
        {
            oper = '*';
        }
        private void sub(object sender, RoutedEventArgs e)
        {
            oper = '-';
        }
    }
}
