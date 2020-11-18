using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for loginScreen.xaml
    /// </summary>
    public partial class loginScreen : Window
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private void BOX1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

            MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        //private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        using (var sr = new StreamReader("http://196.218.181.250:2020/test.txt"))
        //        {
        //            ResultBlock.Text = await sr.ReadToEndAsync();
        //        }
        //    }
        //    catch (FileNotFoundException ex)
        //    {
        //        ResultBlock.Text = ex.Message;
        //    }
        //}
    }
}
