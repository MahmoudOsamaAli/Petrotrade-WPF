using System;
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
    /// Interaction logic for pHome.xaml
    /// </summary>
    public partial class pHome : Page
    {
        public pHome()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pInvoice page = new pInvoice();
            App.ParentWindowRef.ParentFrame.Navigate(page);
            //wQuery window = new wQuery();
            //window.Show();
            //this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pReading page = new pReading();
            App.ParentWindowRef.ParentFrame.Navigate(page);
            //wReading window = new wReading();
            //window.Show();
            //this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            pPayment page = new pPayment();
            App.ParentWindowRef.ParentFrame.Navigate(page);
            //wPayment window = new wPayment();
            //window.Show();
            //this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            pComplaint page = new pComplaint();
            App.ParentWindowRef.ParentFrame.Navigate(page);
            //wComplaint window = new wComplaint();
            //window.Show();
            //this.Close();
        }
    }
}
