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
    /// Interaction logic for wReading.xaml
    /// </summary>
    public partial class wReading : Window
    {
        public wReading()
        {
            InitializeComponent();
            ShowHideInfo(Visibility.Hidden);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ShowHideInfo(Visibility.Hidden);
            if (txtGovernorate.Text == "" || !int.TryParse(txtGovernorate.Text, out _))
            {
                MessageBox.Show("كود المحافظة فارغ أو مكتوب بطريقة خاطئة!!!");
                return;
            }
            if (txtRegion.Text == "" || !int.TryParse(txtRegion.Text, out _))
            {
                MessageBox.Show("كود المنطقة فارغ أو مكتوب بطريقة خاطئة!!!");
                return;
            }
            if (txtDaily.Text == "" || !int.TryParse(txtDaily.Text, out _))
            {
                MessageBox.Show("كود اليومية فارغ أو مكتوب بطريقة خاطئة!!!");
                return;
            }
            if (txtSector.Text == "" || !int.TryParse(txtSector.Text, out _))
            {
                MessageBox.Show("كود القطاع فارغ أو مكتوب بطريقة خاطئة!!!");
                return;
            }
            if (txtBlok.Text == "" || !int.TryParse(txtBlok.Text, out _))
            {
                MessageBox.Show("كود البلوك فارغ أو مكتوب بطريقة خاطئة!!!");
                return;
            }
            if (txtBuilding.Text == "" || !int.TryParse(txtBuilding.Text, out _))
            {
                MessageBox.Show("كود العمارة فارغ أو مكتوب بطريقة خاطئة!!!");
                return;
            }
            if (txtApartmrnt.Text == "" || !int.TryParse(txtApartmrnt.Text, out _))
            {
                MessageBox.Show("كود الشقة فارغ أو مكتوب بطريقة خاطئة!!!");
                return;
            }
            if (txtSubsequence.Text == "" || !int.TryParse(txtSubsequence.Text, out _))
            {
                MessageBox.Show("الكود الفرعي فارغ أو مكتوب بطريقة خاطئة!!!");
                return;
            }
            ShowHideInfo(Visibility.Visible);
        }
        private void ShowHideInfo(Visibility flag)
        {
            lblPrevReadingLable.Visibility = flag;
            lblPrevReading.Visibility = flag;
            lblCurrentReadingLable.Visibility = flag;
            txtCurrentReading.Visibility = flag;
            btnRegisterReading.Visibility = flag;
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
