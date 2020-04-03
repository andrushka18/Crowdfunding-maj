using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Text;

namespace ToolBox.Connections
{
    public class Connection
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:44356/api/");
            HttpResponseMessage response = client.GetAsync("").Result;
            Console.WriteLine("{0} - {1}", (int)response.StatusCode, response.ReasonPhrase);
            if ((int)response.StatusCode == 401)
            {
                var credentials = new NetworkCredential("Admin", "Admin");
                var handler = new HttpClientHandler { Credentials = credentials };

                client = new HttpClient(handler);
                client.BaseAddress = new Uri("http://localhost:5629/api/");
                response = client.GetAsync(" ").Result;
                Console.WriteLine("{0} - {1}", (int)response.StatusCode, response.ReasonPhrase);
            }
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<T> Get()  user = (IEnumerable<T>)response.Content.ReadAsAsync<IEnumerable<T>>().Result;

                foreach (var (T entity)  in IEnumerable<T>)
                {
                    Console.WriteLine("{0}\t{1}\t{2}"
                   
                };

            }
            Console.ReadKey();
        }
    }
}
