using System;
using ClientLib;

namespace NetFrameworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Service1Client client = new Service1Client())
            {
                var response = client.GetDataAsync(32769).Result; // MaxStringContentLength = 32768
            }
            Console.WriteLine(@"Made it without exception.");
            Console.ReadLine();
        }
    }
}
