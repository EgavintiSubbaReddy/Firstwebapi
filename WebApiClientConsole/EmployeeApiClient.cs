using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

using System.Threading.Tasks;


namespace WebApiClientConsole
{
    internal class EmployeeApiClient
    {
        static Uri uri = new Uri("http://Localhost:5000/");
        public static async Task CallGetAllEmployee()
        {
            using(var client = new HttpClient())
            {
                client .BaseAddress = uri;  
                HttpResponseMessage response = await client.GetAsync("GetAllEmployees");
                response.EnsureSuccessStatusCode();
                if(response.IsSuccessStatusCode)
                {
                    String x = await response.Content.ReadAsStringAsync();
                    await Console.Out.WriteAsync(x);
                }
            }
        }
    }
}
