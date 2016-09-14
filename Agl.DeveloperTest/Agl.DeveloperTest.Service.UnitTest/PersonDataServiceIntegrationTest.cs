﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            //TODO: Need to do a alternative way to fix the mocking issue to complete the unit testing
            //var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            //response.Content = new StringContent(System.IO.File.ReadAllText(@"SampleData.txt"));


            //_client.Setup(f => f.GetAsync(It.IsAny<string>()))
            //    .ReturnsAsync(response);

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
