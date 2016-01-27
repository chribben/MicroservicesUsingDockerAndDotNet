using System;
using System.Threading.Tasks;

namespace Heartbeat
{
    public static class Heart {
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
        
        public static void Beat()
        {
            Console.WriteLine(DateTime.UtcNow.ToString("O"));
        }
    }
}
