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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for wPayment.xaml
    /// </summary>
    public partial class wPayment : Window
    {
        public wPayment()
        {
            InitializeComponent();
        }

        private void btnRegisterReading_Click(object sender, RoutedEventArgs e)
        {
            wOnlinPayment window = new wOnlinPayment();
            window.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void btnRegisterReading_Copy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("تم السداد بنجاح", "بتروتريد", MessageBoxButton.OK, MessageBoxImage.Information);
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
