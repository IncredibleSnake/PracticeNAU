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

namespace Calculator_WPF
{
    public partial class MainWindow : Window
    {   
        // Змінні для роботи калькулятора
        double num1 = 0;
        double num2 = 0;
        string op ="";

        public MainWindow()
        {
            InitializeComponent();
        }
        // Функція для набору чисел
        private void btn_num_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            String num = button.Content.ToString();
            if (txtValue.Text == "0")
                txtValue.Text = num;
            else
                txtValue.Text += num;

            if (op == ""){
                num1 = Double.Parse(txtValue.Text);
            }
            else{
                num2 = Double.Parse(txtValue.Text);
            }
        }

        // Функція для задання більшості операцій
        private void btn_op_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            op = button.Content.ToString();
            txtValue.Text = "0";

        }

        // Функція для розрахунку операцій 
        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            switch(op)
            {
                case "":
                    result = num1;
                    break;
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "min":
                    result = Math.Min(num1, num2);
                    break;
                case "max":
                    result = Math.Max(num1, num2);
                    break;
                case "avg":
                    result = (num1 + num2) / 2;
                    break;
                case "x^y":
                    result = Pow(num1, (int) num2);
                    break;
            }
            txtValue.Text = result.ToString();
            num1 = result;
            num2 = 0;
            op = "";

        }

        // Функція для зведення в ступінь
        private double Pow(double x, int y)
        {
            if (y == 0)
                return 1;
            return Pow(x, y - 1) * x;
        }

        // Функція для повного зтирання операцій
        private void btn_CE_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            op = "";
            txtValue.Text = "0";
        }

        // Функція для повного зтирання останнього числа
        private void btn_C_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
                num1 = 0;
            else
                num2 = 0;
            txtValue.Text = "0";
        }

        // Функція для зтирання останнього символа в числі
        private void btn_backspace_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = DropLastChar(txtValue.Text);
            if (op == "")
            {
                num1 = Double.Parse(txtValue.Text);
            }
            else
            {
                num2 = Double.Parse(txtValue.Text);
            }
        }

        // Функція для зтирання останнього символа 
        private string DropLastChar(string text)
        {
            if (text.Length == 1)
                text = "0";
            else
            {
                text = text.Remove(text.Length - 1, 1);
                if (text[text.Length - 1] == ',')
                    text = text.Remove(text.Length - 1, 1);
            }
            return text;
        }

        // Функція для перетворення числа у негативне
        private void btn_plusminus_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = num1 * -1;
                txtValue.Text = num1.ToString();
            }
            else
            {
                num2 = num2 *-1;
                txtValue.Text = num2.ToString();
            }
        }

        // Функція для додавання коми до числа
        private void btn_comma_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
                SetComma(num1);
            else
                SetComma(num2);
        }

        // Функція для додавання коми
        private void SetComma(double num2)
        {
            if (txtValue.Text.Contains(','))
                return;
            txtValue.Text += ',';
        }
    }
}
