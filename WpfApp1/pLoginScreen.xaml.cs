using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp1.Api;

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
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (BOX1.Text == "" || BOX2.Text == "" || BOX3.Text == "" || BOX4.Text == "" || BOX5.Text == "" || BOX6.Text == "" || BOX7.Text == "" || BOX8.Text == "")
                {
                    ResultBlock.Content = " لم يتم ادخال بيانات من فضلك ادخل رقم الاشتراك بطريقة صحيحة  ";
                    return;
                }
                string SubNum = BOX1.Text + BOX2.Text + BOX3.Text + BOX4.Text + BOX5.Text + BOX6.Text + BOX7.Text + BOX8.Text;
                WebClient client = new WebClient();
                Stream stream = client.OpenRead("https://31diag181.blob.core.windows.net/doccontainer/test.txt");

                using (var reader = new StreamReader(stream))
                {
                    string str = await reader.ReadToEndAsync();
                    List<data> data = JsonConvert.DeserializeObject<List<data>>(str);
                    App.allData = data;
                    bool status = false;
                    App.CurCustomer = data.FirstOrDefault(w => w.SubNo == SubNum);
                    if (App.CurCustomer != null)
                        status = true;

                    if (status)
                    {
                        pMain main = new pMain();
                        App.ParentWindowRef.ParentFrame.Navigate(main);
                    }
                    else
                    {
                        ResultBlock.Content = "! رقم المشترك غير صحيح";
                    }
                }

            }
            catch (FileNotFoundException ex)
            {
                ResultBlock.Content = ex.Message;
            }
        }

    }
}
