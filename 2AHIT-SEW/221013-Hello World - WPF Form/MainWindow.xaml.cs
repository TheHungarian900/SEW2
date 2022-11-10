﻿using System;
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

namespace _221013_Hello_World___WPF_Form
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
        private void cmdHello_Click(object sender, RoutedEventArgs e)
        {
            lblHello.Content = "Hello World!";
        }
        private void cmdDelete_Click(object sender, RoutedEventArgs e)
        {
            lblHello.Content = "---";
        }
        private void cmdCopy_Click(object sender, RoutedEventArgs e)
        {
            lblHello.Content = tbxInput.Text;
        }
    }
}
