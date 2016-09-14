using System.Net.Http;

namespace Agl.DeveloperTest.Service
{
    public static class ServiceManagerFactory
    {

        public static IPersonService GetPersernService(HttpClient client)
        {
            return new PersonService(client);
        }
    }
}
