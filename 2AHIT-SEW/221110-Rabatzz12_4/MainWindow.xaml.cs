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

            if(Double.TryParse(txtAmmount.Text, out amount) == true &&
               Double.TryParse(txtprice.Text, out singlePrice) == true)
            {
                double turnover = amount * singlePrice;
                double turnoverlimit = double.Parse(((ComboBoxItem)cboSalesLimit.SelectedValue).Content.ToString());
                double percentage = getDiscountInPercent();
                double discountPercentage = calcDiscountPercentage(turnover, turnoverlimit, percentage);
                double discount = turnover * discountPercentage;
                double endPrice = turnover - discount;

                // GUI Part
                lblDiscountPercent.Content = discountPercentage * 100 + "%";
                lblDiscount.Content = discount;
                lblEndPrice.Content = endPrice;
            }
        }

        private double getDiscountInPercent()
        {
            if (rdoZero.IsChecked == true) return 0;
            if (rdoTen.IsChecked == true) return 10;
            return 20;
        }

        private double calcDiscountPercentage(double turnover, double turnoverlimit, double percentage)
        {
            if(turnover > turnoverlimit)
            {
                return percentage * 0.01;
            }
            return 0;
        }        

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
