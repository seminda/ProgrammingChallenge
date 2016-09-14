using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;
using Moq;

namespace Agl.DeveloperTest.Service.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<HttpClient> _client;
        [TestInitialize]
        public void Initialise()
        {
            var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            response.Content = new StringContent(System.IO.File.ReadAllText(@"SampleData.txt"));
            _client = new Mock<HttpClient>();
            //_client.Setup(f => f.GetAsync(It.IsAny<string>()))
            //    .ReturnsAsync(response);

        }
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var service = ServiceManagerFactory.GetPersernService(_client.Object);
            //Act
            RunAsync().Wait();
            //Assert
            //Assert.IsNotNull(data);
        }

        private async Task RunAsync()
        {

            var persernService = ServiceManagerFactory.GetPersernService(_client.Object);
            var result = await persernService.GetPersonData();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count==2);
            //Assert.IsTrue(result.);


        }
    }
}
