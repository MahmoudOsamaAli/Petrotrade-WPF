﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for pQuery.xaml
    /// </summary>
    public partial class pQuery : Page
    {
        public pQuery()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pMain page = new pMain();
            App.ParentWindowRef.ParentFrame.Navigate(page);
        }
         private void ShowInvoice(object sender, RoutedEventArgs e)
        {
            pInvoice page = new pInvoice();
            App.ParentWindowRef.ParentFrame.Navigate(page);
        }


    }
}
