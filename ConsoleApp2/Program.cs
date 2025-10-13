using System.Net.Http;
using System.Net.Http.Json;

namespace ConsoleApp2
{
    internal class Program
    {
        public static HttpClient httpClient = new HttpClient();
        static void  Main()
        {
            httpClient.BaseAddress = new Uri("http://localhost:5195/api/");

            
        }
    }
}
