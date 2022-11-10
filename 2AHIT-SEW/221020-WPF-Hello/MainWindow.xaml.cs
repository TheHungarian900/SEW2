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

namespace _221020_WPF_Hello
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

        private void btnClick(object sender, RoutedEventArgs e)
        {
            txtBlaBla.Text = "";

            if (btnReset.Content.Equals("Reset"))
            {
                btnReset.Content = "YOU PRESSED ME! HOW RUDE!";
            }
            else
            {
                btnReset.Content = "STOP CLICKING ME! STOP IT!";
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(btnReset != null)
            {
                btnReset.Content = "Reset";
            }
        }
    }
}
