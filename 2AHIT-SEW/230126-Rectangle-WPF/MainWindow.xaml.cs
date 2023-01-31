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

namespace _230126_Rectangle_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string input1, input2, shape;
        bool isOk1, isOk2;
        double area, circumference, n1, n2;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void cboShape_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cboItem = cboShape.SelectedItem as ComboBoxItem;
            if (cboItem != null)
            {
                shape = Convert.ToString(cboItem.Content);
            }

            if(shape == "Circle")
            {
                txtNum2.IsEnabled = false;
                txtNum2.Text = "";
            }
            else if(shape == "Rectangle")
            {
                txtNum2.IsEnabled = true;
            }


        }
        private void btnCircumference_Click(object sender, RoutedEventArgs e)
        {
            isOk(out isOk1, out isOk2);

            if (shape == "Rectangle")
            {
                if (isOk1 && isOk2)
                {
                    Rectangle r = new Rectangle(n1, n2);
                    area = r.GetCircumference();
                    lblCircumference.Content = area;
                }
                else
                {
                    MessageBox.Show("Fehlerhafte Eingabe!");
                    lblArea.Content = "";
                    lblCircumference.Content = "";
                }
            }
            else if (shape == "Circle")
            {
                if (isOk1)
                {
                    Circle c = new Circle(n1);
                    area = c.GetCircumference();
                    lblCircumference.Content = area;
                }
                else
                {
                    MessageBox.Show("Fehlerhafte Eingabe!");
                    lblArea.Content = "";
                    lblCircumference.Content = "";
                }
            }
            else
            {
                MessageBox.Show("Keine Form ausgewählt!");
                lblArea.Content = "";
                lblCircumference.Content = "";
            }
        }

        private void btnArea_Click(object sender, RoutedEventArgs e)
        {
            isOk(out isOk1, out isOk2);

            if (shape == "Rectangle")
            {
                if (isOk1 && isOk2)
                {
                    Rectangle r = new Rectangle(n1, n2);
                    area = r.GetArea();
                    lblArea.Content = area;
                }
                else
                {
                    MessageBox.Show("Fehlerhafte Eingabe!");
                    lblArea.Content = "";
                    lblCircumference.Content = "";
                }
            }
            else if (shape == "Circle")
            {
                if (isOk1)
                {
                    Circle c = new Circle(n1);
                    area = c.GetArea();
                    lblArea.Content = area;
                }
                else
                {
                    MessageBox.Show("Fehlerhafte Eingabe!");
                    lblArea.Content = "";
                    lblCircumference.Content = "";
                }
            }
            else
            {
                MessageBox.Show("Keine Form ausgewählt!");
                lblArea.Content = "";
                lblCircumference.Content = "";
            }
        }

        public void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void isOk(out bool isOk1, out bool isOk2)
        {
            input(out input1, out input2);

            isOk1 = double.TryParse(input1, out n1);
            isOk2 = double.TryParse(input2, out n2);
        }
        private void input(out string input1, out string input2)
        {
            input1 = txtNum1.Text;
            input2 = txtNum2.Text;
        }
    }
}
