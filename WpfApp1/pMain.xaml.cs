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
        public pMain()
        {
            App.HomeParent = this;
            InitializeComponent();
            pHome c = new pHome();
            this.ParentFrame.Navigate(c);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pLoginScreen page = new pLoginScreen();
            App.ParentWindowRef.ParentFrame.Navigate(page);
        }


    }
}
