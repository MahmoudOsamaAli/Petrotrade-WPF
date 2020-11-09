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
    /// Interaction logic for wQuery.xaml
    /// </summary>
    public partial class wQuery : Window
    {
        public wQuery()
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
            lblReadingLable.Visibility = Visibility.Hidden;
            lblReading.Visibility = Visibility.Hidden;
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
            lblReadingLable.Visibility = Visibility.Visible;
            lblReading.Visibility = Visibility.Visible;
        }
    }
}
