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
    /// Interaction logic for wComplaint.xaml
    /// </summary>
    public partial class wComplaint : Window
    {
        public wComplaint()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("تم تسجيل الشكوى بنجاح", "بتروتريد", MessageBoxButton.OK, MessageBoxImage.Information);
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
