using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Api
{
    public class BaseController
    {       
       public async Task<bool> updateFile(data customer)
        {
            using (var client = new HttpClient())
            {
                // Setting Base address.  
                client.BaseAddress = new Uri("http://localhost:32985/");

                // Setting content type.  
                client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("SubNumber", customer.SubNo);
                //client.DefaultRequestHeaders.Add("CurrentRead", customer.CurrentRead.ToString());

                // Setting timeout.  
                client.Timeout = TimeSpan.FromSeconds(Convert.ToDouble(1000000));

                //HttpResponseMessage resp2 = client.PostAsync<string>("http://localhost:32985/api/UpdateFile", customer, new JsonMediaTypeFormatter()).Result;
                HttpResponseMessage resp2 = await client.PostAsJsonAsync("api/UpdateFile", customer).ConfigureAwait(false);
                if (!resp2.IsSuccessStatusCode)
                {
                    return false;
                }
                resp2.Dispose();
                return true;
            }

        }
    }
}
