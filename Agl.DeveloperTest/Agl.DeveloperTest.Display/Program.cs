using Agl.DeveloperTest.Service;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Autofac;

namespace Agl.DeveloperTest.Display
{
    internal class Program
    {
        public static IContainer Container { get; set; }

        private static void Main()
        {
            InitialiseAutoFac();
            RunAsync().Wait();
            Console.Read();
        }

        private static async Task RunAsync()
        {
            using (var analyticServiceScope = Container.BeginLifetimeScope())
            {
                var client = analyticServiceScope.Resolve<HttpClient>();
                var persernService = ServiceManagerFactory.GetPersernService(client);
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

        public static void InitialiseAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<HttpClient>()
                .As<HttpClient>()
                .SingleInstance();
         

            Container = builder.Build();
        }
    }
}
