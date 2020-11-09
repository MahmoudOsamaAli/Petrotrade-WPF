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
    /// Interaction logic for pLoginScreen.xaml
    /// </summary>
    public partial class pLoginScreen : Page
    {
        public pLoginScreen()
        {
            InitializeComponent();
        }

        private void BOX1_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pMain main = new pMain();
            App.ParentWindowRef.ParentFrame.Navigate(main);
        }
    }
}
