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
using nsMath;

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
               
            if(isOk1 && isOk2)
            {
                try
                {
                    lblResult.Content = MathOperations.Add(num1, num2);
                }
                catch (OverflowException ex)
                {
                    lblResult.Content = ex.Message;
                }
                catch (ArithmeticException ex)
                {
                    lblResult.Content = ex.Message;
                }
            }
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            isOk();

            if(isOk1 && isOk2)
            {
                try
                {
                    lblResult.Content = MathOperations.Sub(num1, num2);
                }
                catch (OverflowException ex)
                {
                    lblResult.Content = ex.Message;
                }
                catch (ArithmeticException ex)
                {
                    lblResult.Content = ex.Message;
                }
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            isOk();

            if(isOk1 && isOk2)
            {
                try
                {
                    lblResult.Content = MathOperations.Mult(num1, num2);
                }
                catch (OverflowException ex)
                {
                    lblResult.Content = ex.Message;
                    //MessageBox.Show("Yor number is too high!");
                }
                catch (ArithmeticException ex)
                {
                    lblResult.Content = ex.Message;
                }
            }            
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            isOk();

            if(isOk1 && isOk2)
            {
                try
                {
                    lblResult.Content = MathOperations.Div(num1, num2);
                }
                catch (OverflowException ex)
                {
                    lblResult.Content = ex.Message;
                }
                catch (DivideByZeroException ex)
                {
                    lblResult.Content = ex.Message;
                }
                catch (ArithmeticException ex)
                {
                    lblResult.Content = ex.Message;
                }
            }
        }

        private void btnFactorial_Click(object sender, RoutedEventArgs e)
        {
            Factorial();

            if (isOk3)
            {
                try
                {
                    lblResult.Content = MathOperations.Factorial(num3);
                }
                catch (OverflowException ex)
                {
                    lblResult.Content = ex.Message;
                }
                catch (StackOverflowException ex)
                {
                    lblResult.Content = ex.Message;
                }
                catch (MathOperations.NegativeArgumentException)
                {
                    lblResult.Content = "Value may not be negative!";
                }
                catch (ArithmeticException ex)
                {
                    lblResult.Content = ex.Message;
                }
            }
        }

        private void btnAbs_Click(object sender, RoutedEventArgs e)
        {
            isOk();

            if(isOk1)
            {
                try
                {
                    lblResult.Content = MathOperations.Abs(num1);
                }
                catch (OverflowException ex)
                {
                    lblResult.Content = ex.Message;
                }
                catch (ArithmeticException ex)
                {
                    lblResult.Content = ex.Message;
                }
                finally
                {
                    lblResult.Content += "finally!";
                }
            }
        }

        private void btnSignum_Click(object sender, RoutedEventArgs e)
        {
            isOk();

            if(isOk1)
            {
                try
                {
                    lblResult.Content = MathOperations.Signum(num1);
                }
                catch (OverflowException ex)
                {
                    lblResult.Content = ex.Message;
                }
                catch (ArithmeticException ex)
                {
                    lblResult.Content = ex.Message;
                }
            }
        }

        public void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void isOk()
        {
            try
            {
                isOk1 = double.TryParse(txtNumber1.Text, out num1);
                isOk2 = double.TryParse(txtNumber2.Text, out num2);

                if(isOk1 == false || isOk2 == false)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException ex)
            {
                lblResult.Content = ex.Message;
            }
            catch (InvalidCastException ex)
            {
                lblResult.Content = ex.Message;
            }
        }
        private void Factorial()
        {
            try
            {
                isOk3 = long.TryParse(txtFactorial.Text, out num3);

                if (isOk3 == false)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException ex)
            {
                lblResult.Content = ex.Message;
            }
            catch (InvalidCastException ex)
            {
                lblResult.Content = ex.Message;
            }
        }

    }
}
