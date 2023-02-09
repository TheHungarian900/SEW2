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
        string input1, input2, input3, shape, CoA;
        bool isOk1, isOk2, isOk3;
        double n1, n2, n3;


        public MainWindow()
        {
            InitializeComponent();
            lblDeveloperName.Content = Rectangle.DeveloperName;
        }

        //Circumference or Area
        private void cboCoA_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cboItem = cboCoA.SelectedItem as ComboBoxItem;
            if (cboItem != null)
            {
                CoA = Convert.ToString(cboItem.Content);
            }

            if (CoA == "Circumference" || CoA == "Area")
            {
                txtAreaDensity.IsEnabled = false;
                txtAreaDensity.Text = "";
            }
            else if (CoA == "Mass")
            {
                txtAreaDensity.IsEnabled = true;
            }
        }

        //Rectangle or Circle
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

                txtAreaDensity.IsEnabled = false;
                txtAreaDensity.Text = "";
            }
            else if(shape == "Rectangle")
            {
                txtNum2.IsEnabled = true;

                txtAreaDensity.IsEnabled = true;
            }


        }

        //Calculating
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            isOk(out isOk1, out isOk2);

            //Circumference
            if (CoA == "Circumference")
            {


                //Rectangle
                if (shape == "Rectangle")
                {
                    if (isOk1 && isOk2)
                    {
                        Rectangle r = new Rectangle(n1, n2, n3);
                        lblResult.Content = r.Circumference;
                    }
                    else
                    {
                        MessageBox.Show("Fehlerhafte Eingabe!");
                        lblResult.Content = "";
                    }
                }
                //Circle
                else if (shape == "Circle")
                {
                    if (isOk1)
                    {
                        Circle c = new Circle(n1);
                        Circle c2 = new Circle(n1, 1.0, 1.1);
                        lblResult.Content = c.Circumference;
                    }
                    else
                    {
                        MessageBox.Show("Fehlerhafte Eingabe!");
                        lblResult.Content = "";
                    }
                }
                //Nothing
                else
                {
                    MessageBox.Show("Keine Form ausgewählt!");
                    lblResult.Content = "";
                }
            }

            //Area
            else if(CoA == "Area")
            {
                //Rectangle
                if (shape == "Rectangle")
                {
                    if (isOk1 && isOk2)
                    {
                        Rectangle r = new Rectangle(n1, n2, n3);
                        lblResult.Content = r.Area;
                    }
                    else
                    {
                        MessageBox.Show("Fehlerhafte Eingabe!");
                        lblResult.Content = "";
                    }
                }
                //Circle
                else if (shape == "Circle")
                {
                    if (isOk1)
                    {
                        Circle c = new Circle(n1);
                        lblResult.Content = c.Area;
                    }
                    else
                    {
                        MessageBox.Show("Fehlerhafte Eingabe!");
                        lblResult.Content = "";
                    }
                }
                //Nothing
                else
                {
                    MessageBox.Show("Keine Form ausgewählt!");
                    lblResult.Content = "";
                }
            }

            //Mass
            else if(CoA == "Mass")
            {
                if (shape == "Rectangle")
                {
                    if (isOk1 && isOk2 && isOk3)
                    {
                        Rectangle r = new Rectangle(n1, n2, n3);
                        lblResult.Content = r.Mass;
                    }
                    else
                    {
                        MessageBox.Show("Fehlerhafte Eingabe!");
                        lblResult.Content = "";
                    }
                }
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
            isOk3 = double.TryParse(input3, out n3);
        }

        private void input(out string input1, out string input2)
        {
            input1 = txtNum1.Text;
            input2 = txtNum2.Text;
            input3 = txtAreaDensity.Text;
        }
    }
}
