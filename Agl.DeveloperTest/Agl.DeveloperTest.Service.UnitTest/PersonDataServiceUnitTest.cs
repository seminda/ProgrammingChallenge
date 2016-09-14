using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Agl.DeveloperTest.Service.UnitTest
{
    [TestClass]
    public class PersonDataServiceUnitTest
    {
        private Mock<HttpClient> _client;
        [TestInitialize]
        public void Initialise()
        {
            //TODO: Need to do a alternative way to fix the mocking issue to complete the unit testing
            //_client = new Mock<HttpClient>();
            //var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            //response.Content = new StringContent(System.IO.File.ReadAllText(@"SampleData.txt"));

            //_client.Setup(f => f.GetAsync(It.IsAny<string>()))
            //    .ReturnsAsync(response);

        }
        [TestMethod]
        public void Test_Success_DataAccess()
        {

            //Arrange

            //Act

            //Assert

        }

    }
}
