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

namespace _221110_Rabatzz
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

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {

            double amount, singlePrice;
            double salesLimit = 0;

            if (Double.TryParse(txtAmmount.Text, out amount) == true &&
               Double.TryParse(txtprice.Text, out singlePrice) == true)
            {
                double turnover = amount * singlePrice;

                var cboItem = cboSalesLimit.SelectedItem as ComboBoxItem;
                if (cboItem != null)
                {
                    salesLimit = Convert.ToDouble(cboItem.Content);
                }

                double discountPercentage = calcDiscountPercentage(turnover, salesLimit);
                double discount = turnover * discountPercentage;
                double endPrice = turnover - discount;

                // GUI Part
                lblDiscountPercent.Content = discountPercentage * 100 + "%";
                lblDiscount.Content = discount;
                lblEndPrice.Content = endPrice;
            }
        }

        private double calcDiscountPercentage(double turnover, double salesLimit)
        {
            if (turnover <= salesLimit)
            {
                return 0;
            }
            else
            {
                return 0.15;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
