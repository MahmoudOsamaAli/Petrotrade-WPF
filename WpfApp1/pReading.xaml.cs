using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
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
using System.Net.Http;
using System.Net.Http.Formatting;
using WpfApp1.Api;
using System.Linq;
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for pReading.xaml
    /// </summary>
    public partial class pReading : Page
    {
        private data customer;
        private SaveFile save;
        public pReading()
        {
            InitializeComponent();
            save = new SaveFile();
            customer = App.CurCustomer;
            lastReading.Text = customer.LastRead.ToString();
            subNumber.Text = customer.SubNo;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pMain page = new pMain();
            App.ParentWindowRef.ParentFrame.Navigate(page);
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void ShowMessageBox_Click(string msgtext , string txt)
        {
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result = MessageBox.Show(msgtext, txt, button);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    Button_Click(null, null);
                    break;
                case MessageBoxResult.No:
                    pLoginScreen page = new pLoginScreen();
                    App.ParentWindowRef.ParentFrame.Navigate(page);
                    break;
                case MessageBoxResult.Cancel:
                    pLoginScreen cancel = new pLoginScreen();
                    App.ParentWindowRef.ParentFrame.Navigate(cancel);
                    break;
            }
        }
        private async void btnRegisterReading_Click(object sender, RoutedEventArgs e)
        {
            var currentReadingStr = currentReading.Text;
            if (currentReadingStr == "" || customer.LastRead >= int.Parse(currentReadingStr) || !int.TryParse(currentReadingStr, out _))
            {
                MessageBox.Show("القراءة فارغة أو مكتوبة بطريقة خاطئة!!!");
                currentReading.Text = "";
                return;
            }
            var res = false;
            data row = App.allData.FirstOrDefault(w => w.SubNo == customer.SubNo);
            var LastArrange = row.Reading.Last().Arrange;
            App.allData.Remove(row);
            Random rnd = new Random();
            Reading reading = new Reading() { ReadDate = DateTime.Now, CurrentRead = int.Parse(currentReadingStr), Paid= false, Cost= (int.Parse(currentReadingStr) - customer.LastRead), BillNo = rnd.Next(1, 1000), Arrange= LastArrange+1 };
            customer.Reading.Add(reading);
            App.allData.Add(customer);
            var jsonCustomer = JsonConvert.SerializeObject(App.allData);
            try
            {
                using (StreamWriter writer = new StreamWriter("D:/Work/Petrotrade-WPF_WithAZURE/WpfApp1/common/test.txt"))
                {
                    writer.Write(jsonCustomer);
                    res = true;
                }
              await save.SendFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (res)
            {
                string msgtext = " هل  ترغب فى خدمات اخرى ؟";
                string txt = "تمت العملية بنجاح ";
                ShowMessageBox_Click(msgtext, txt);
            }
            else
            {
                string msgtext = " هل  ترغب فى خدمات اخرى ؟";
                string txt = "العملية فشلت ...! ";
                ShowMessageBox_Click(msgtext, txt);
            }
        }

    }
}
