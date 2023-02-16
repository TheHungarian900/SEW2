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

namespace _230209_Ex22_CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string input1, input2, input3;
        bool isOk1, isOk2, isOk3;
        double num1, num2;
        long num3;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            isOk();
                        
            try
            {
                lblResult.Content = nsMath.MathOperations.Add(num1, num2);
            }
            catch(OverflowException)
            {
                MessageBox.Show("Yor number is too high!");
            }
            catch(ArithmeticException)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            isOk();

            try
            {
                lblResult.Content = nsMath.MathOperations.Sub(num1, num2);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Yor number is too high!");
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            isOk();

            try
            {
                lblResult.Content = nsMath.MathOperations.Mult(num1, num2);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Yor number is too high!");
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            isOk();

            try
            {
                lblResult.Content = nsMath.MathOperations.Div(num1, num2);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Yor number is too high!" + e);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("You can't divide with 0!");
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void btnFactorial_Click(object sender, RoutedEventArgs e)
        {
            Factorial();

            try
            {
                lblResult.Content = nsMath.MathOperations.Factorial(num3);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Yor number is too high!");
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void btnAbs_Click(object sender, RoutedEventArgs e)
        {
            isOk();

            try
            {
                lblResult.Content = nsMath.MathOperations.Abs(num1);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Yor number is too high!");
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void btnSignum_Click(object sender, RoutedEventArgs e)
        {
            isOk();

            try
            {
                lblResult.Content = nsMath.MathOperations.Signum(num1);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Yor number is too high!");
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        public void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void isOk()
        {
            input();

            isOk1 = double.TryParse(input1, out num1);
            isOk2 = double.TryParse(input2, out num2);
        }
        private void input()
        {
            try
            {
                input1 = txtNumber1.Text;
                input2 = txtNumber2.Text;
            }
            
        }
        private void Factorial()
        {
            input3 = txtFactorial.Text;

            isOk3 = long.TryParse(input3, out num3);
        }

    }
}
