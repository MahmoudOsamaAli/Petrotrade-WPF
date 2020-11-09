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
    /// Interaction logic for pReading.xaml
    /// </summary>
    public partial class pReading : Page
    {
        public pReading()
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

        private void btnRegisterReading_Click(object sender, RoutedEventArgs e)
        {
            if (txtCurrentReading.Text == "" || !int.TryParse(txtCurrentReading.Text, out _))
            {
                MessageBox.Show("القراءة فارغة أو مكتوبة بطريقة خاطئة!!!");
                txtCurrentReading.Text = "";
                return;
            }
            MessageBox.Show("تم تسجيل القراءة بنجاح", "بتروتريد", MessageBoxButton.OK, MessageBoxImage.Information);
            Button_Click(null, null);
        }
    }
}
