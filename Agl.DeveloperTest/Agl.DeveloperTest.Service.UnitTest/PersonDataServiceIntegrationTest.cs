using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;
using Moq;

namespace Agl.DeveloperTest.Service.UnitTest
{
    [TestClass]
    public class PersonDataServiceIntegrationTest
    {
        private Mock<HttpClient> _client;
        [TestInitialize]
        public void Initialise()
        {
            _client = new Mock<HttpClient>();

        }
        [TestMethod]
        public void Test_Success_DataAccess()
        {
            
            RunAsync().Wait();
           
        }

        private async Task RunAsync()
        {
            //Arrange
            var persernService = ServiceManagerFactory.GetPersernService(_client.Object);

            //Act
            var result = await persernService.GetPersonData();

            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count==2);
            
        }
    }
}
