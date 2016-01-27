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
                Task.WaitAll(new[] { Beat(), Task.Delay(1000) });
            }
        }
        
        public static async Task Beat()
        {
            Console.WriteLine(await _client.GetStringAsync("http://services_echo_1:5004"));
        }
    }
}
