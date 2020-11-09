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
    /// Interaction logic for pComplaint.xaml
    /// </summary>
    public partial class pComplaint : Page
    {
        public pComplaint()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pMain page = new pMain();
            App.ParentWindowRef.ParentFrame.Navigate(page);
            //MainWindow window = new MainWindow();
            //window.Show();
            //this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("تم تسجيل الشكوى بنجاح", "بتروتريد", MessageBoxButton.OK, MessageBoxImage.Information);
            pMain page = new pMain();
            App.ParentWindowRef.ParentFrame.Navigate(page);
            //MainWindow window = new MainWindow();
            //window.Show();
            //this.Close();
        }
    }
}
