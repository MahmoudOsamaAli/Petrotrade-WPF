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
    /// Interaction logic for pPayment.xaml
    /// </summary>
    public partial class pPayment : Page
    {
        public pPayment()
        {
            InitializeComponent();
        }
        private void btnRegisterReading_Click(object sender, RoutedEventArgs e)
        {
            pOnlinPayment page = new pOnlinPayment();
            App.ParentWindowRef.ParentFrame.Navigate(page);
            //wOnlinPayment window = new wOnlinPayment();
            //window.Show();
            //this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pMain page = new pMain();
            App.ParentWindowRef.ParentFrame.Navigate(page);
            //MainWindow window = new MainWindow();
            //window.Show();
            //this.Close();
        }

        private void btnRegisterReading_Copy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("تم السداد بنجاح", "بتروتريد", MessageBoxButton.OK, MessageBoxImage.Information);
            pMain page = new pMain();
            App.ParentWindowRef.ParentFrame.Navigate(page);
            //MainWindow window = new MainWindow();
            //window.Show();
            //this.Close();
        }
    }
}
