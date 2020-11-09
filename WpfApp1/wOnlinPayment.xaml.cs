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
    /// Interaction logic for wOnlinPayment.xaml
    /// </summary>
    public partial class wOnlinPayment : Window
    {
        public wOnlinPayment()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("تم السداد بنجاح", "بتروتريد", MessageBoxButton.OK, MessageBoxImage.Information);
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
