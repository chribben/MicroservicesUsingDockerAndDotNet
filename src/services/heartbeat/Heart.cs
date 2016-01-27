using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace Heartbeat
{
    public static class Heart {
        private static HttpClient _client = new HttpClient();

        public static void Main(string[] args)
        {
            Pulse().Wait();
        }
        
        public static async Task Pulse()
        {
            while (true)
            {
                Beat();
                await Task.Delay(1000);
            }
        }
        
        public static async void Beat()
        {
            Console.WriteLine(await _client.GetStringAsync("http://localhost:5000/api/front"));
        }
    }
}
