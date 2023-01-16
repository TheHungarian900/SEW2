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

namespace _221221_Zahlenfeld_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        double[] f = new double[5];
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string input = txtDec.Text;
            bool isOk;

            if(i < f.Length)
            {
                isOk = double.TryParse(input, out f[i]);

                if (isOk == true)
                {
                    resetGUI();

                    ListBox1.Items.Add(f[i]);

                    i++;
                }
                else
                {
                    lblInfo.Content = "Fehlerhafte Eingabe!";
                }
            }
            else
            {
                lblInfo.Content = "Keine weiteren Eingaben möglich!";
                btnAdd.IsEnabled = false;
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            double n = 0;
            double firstFound, search;

            if (double.TryParse(txtKey.Text, out n))
            {
                ArrayMethods.Search(f, n, out firstFound, out search);
                lblFirstFound.Content = firstFound + ". Stelle";
                lblSearch.Content = search;
            }
            else
            {
                lblInfo.Content = "Fehlerhafte Eingabe!";
            }
        }

        private void btnDelLast_Click(object sender, RoutedEventArgs e)
        {
            if(i > 0)
            {
                ListBox1.Items.RemoveAt(i - 1);
                f[i - 1] = 0;
                i--;

                resetGUI();
                
            }
            
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            for(i = 0; i < f.Length; i++)
            {
                f[i] = 0;
                ListBox1.Items.Clear();

                resetGUI();
            }
            i = 0;
        }

        //Minimum berechnen
        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            int amount = 0;
            double min;

            lblInfo.Content = "";

            var cboItem = cboAmount.SelectedItem as ComboBoxItem;
            if (cboItem != null)
            {
                amount = Convert.ToInt32(cboItem.Content);
            }

            ArrayMethods.Minimum(f, i, amount, out min);
            lblMin.Content = min;

            if (ArrayMethods.Minimum(f, i, amount, out min) == false)
            {
                lblInfo.Content = "Geben Sie mehr Nummern ein!";
            }
        }

        //Maximum berechnen
        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            int amount = 0;
            double max;

            lblInfo.Content = "";

            var cboItem = cboAmount.SelectedItem as ComboBoxItem;
            if (cboItem != null)
            {
                amount = Convert.ToInt32(cboItem.Content);
            }

            ArrayMethods.Maximum(f, i, amount, out max);
            lblMax.Content = max;

            if (ArrayMethods.Maximum(f, i, amount, out max) == false)
            {
                lblInfo.Content = "Geben Sie mehr Nummern ein!";
            }
        }

        //Mittelwert berechnen
        private void btnMw_Click(object sender, RoutedEventArgs e)
        {
            int amount = 0;
            double mw;

            lblInfo.Content = "";

            var cboItem = cboAmount.SelectedItem as ComboBoxItem;
            if(cboItem != null)
            {
                amount = Convert.ToInt32(cboItem.Content);
            }

            ArrayMethods.Mittelwert(f, i, amount, out mw);
            lblMw.Content = mw;

            if(mw == 0)
            {
                lblInfo.Content = "Geben Sie mehr Nummern ein!";
            }

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void resetGUI()
        {
            lblInfo.Content = "";
            lblMw.Content = "";
            lblMin.Content = "";
            lblMax.Content = "";
            lblFirstFound.Content = "";
            lblSearch.Content = "";
            btnAdd.IsEnabled = true;
        }

        
    }
}
