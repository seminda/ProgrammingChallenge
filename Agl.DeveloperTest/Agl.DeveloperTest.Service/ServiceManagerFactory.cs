namespace Agl.DeveloperTest.Service
{
    public static class ServiceManagerFactory
    {

        public static IPersonService GetPersernService()
        {
            return new PersonService();
        }
    }
}
