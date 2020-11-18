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
    /// Interaction logic for pMain.xaml
    /// </summary>
    public partial class pMain : Page
    {
        private data customer;
        public pMain()
        {
            App.HomeParent = this;
            InitializeComponent();
            pHome c = new pHome();
            this.ParentFrame.Navigate(c);
            customer = App.CurCustomer;
            name.Text = customer.Name;
            city.Text = customer.City;
            area.Text = customer.Area;
            subNumber.Text = customer.SubNo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pLoginScreen page = new pLoginScreen();
            App.ParentWindowRef.ParentFrame.Navigate(page);
        }


    }
}
