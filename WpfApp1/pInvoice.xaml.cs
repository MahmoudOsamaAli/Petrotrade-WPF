using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
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
    /// Interaction logic for pInvoice.xaml
    /// </summary>
    public partial class pInvoice : Page
    {
        public static data customer = App.CurCustomer;
        public pInvoice()
        {
            InitializeComponent();
            //CultureInfo ci = new CultureInfo("ar-EG");
            month.Text = DateTime.Now.Month.ToString();
            CreatedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            name.Text = customer.Name;
            city.Text = customer.City;
            area.Text = customer.Area;
            address.Text = customer.Address;
            subNumber.Text = customer.SubNo;
            LastRead.Text = customer.LastRead.ToString();
            if (customer.Reading.Count() > 0)
            {
                CurrentRead.Text = customer.Reading.Last().CurrentRead.ToString();
                billNo.Text = customer.Reading.Last().BillNo.ToString();
                Cost.Text = customer.Reading.Last().Cost.ToString() + " جنيه مصرى ";
            }
            else
            {
                CurrentRead.Text = " __ ";
                billNo.Text = " __ ";
                Cost.Text = " __ " + " جنيه مصرى ";
            }

            if (customer.Reading.Last().Paid.Value)
                Status.Visibility = Visibility.Visible;
        }

        private void ShowMessageBox_Click(string msgtext, string txt)
        {
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result = MessageBox.Show(msgtext, txt, button);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    pMain back = new pMain();
                    App.ParentWindowRef.ParentFrame.Navigate(back);
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var res = false;
            customer.Reading.Last().Paid = true;
            App.allData.Add(customer);
            var jsonCustomer = JsonConvert.SerializeObject(App.allData);
            try
            {
                using (StreamWriter writer = new StreamWriter("C:/Users/Mai/Documents/test.txt"))
                {
                    writer.Write(jsonCustomer);
                    res = true;
                }
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

        private void Click_Back(object sender, RoutedEventArgs e)
        {
            pMain back = new pMain();
            App.ParentWindowRef.ParentFrame.Navigate(back);
        }
     
    }
}
