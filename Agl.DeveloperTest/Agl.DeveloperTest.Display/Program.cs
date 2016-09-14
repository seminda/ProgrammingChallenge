using Agl.DeveloperTest.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agl.DeveloperTest.Display
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
            Console.Read();
        }

        static async Task RunAsync()
        {
            var persernService = ServiceManagerFactory.GetPersernService();
            var result = await persernService.GetPersonData();

           
        }
    }
}
