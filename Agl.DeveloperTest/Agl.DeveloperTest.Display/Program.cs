using Agl.DeveloperTest.Service;
using System;
using System.Threading.Tasks;

namespace Agl.DeveloperTest.Display
{
    internal class Program
    {
        private static void Main()
        {
            RunAsync().Wait();
            Console.Read();
        }

        private static async Task RunAsync()
        {
            var persernService = ServiceManagerFactory.GetPersernService();
            var result = await persernService.GetPersonData();
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
                foreach (var pet in item.Pets)
                {
                    Console.WriteLine($"    {pet}");
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }

        }
    }
}
