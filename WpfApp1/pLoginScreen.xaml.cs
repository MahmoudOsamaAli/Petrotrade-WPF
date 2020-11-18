using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    pMain main = new pMain();
        //    App.ParentWindowRef.ParentFrame.Navigate(main);
        //}

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string str2 = BOX1.Text + BOX2.Text + BOX3.Text + BOX4.Text + BOX5.Text + BOX6.Text + BOX7.Text + BOX8.Text;
                WebClient client = new WebClient();
                //Stream stream = client.OpenRead("http://196.218.181.250:2020/test.txt");
                Stream stream = client.OpenRead("C:/Users/Mai/Documents/test.txt");
                string str;
                using (var reader = new StreamReader(stream))
                {
                    str = await reader.ReadToEndAsync();
                    List<data> data = new List<data>();
                    data = JsonConvert.DeserializeObject<List<data>>(str);
                    App.allData = data;
                    bool status = false;
                    foreach( var item in data)
                    {
                        if( item.SubNo == str2)
                        {
                            App.CurCustomer = item;
                            status = true;
                            break;
                        }
                    }
                     if(status)
                    {
                        pMain main = new pMain();
                        App.ParentWindowRef.ParentFrame.Navigate(main);
                    }
                    else
                    {
                        ResultBlock.Text = "fail ..!";
                    }
                   
                }
            }
            catch (FileNotFoundException ex)
            {
                ResultBlock.Text = ex.Message;
            }
        }

    }
}
