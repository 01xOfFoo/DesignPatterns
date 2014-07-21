using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.AbstractFactory.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.CreationalPatterns.Tests.AbstractFactory
{
    [TestClass]
    public class AbstractFactoryTest
    {
        private Client _client;

        [TestInitialize]
        public void SetUp()
        {
            _client = new Client();
        }

        [TestMethod]
        [ExpectedException(typeof (CarFactoryNotAssignedException))]
        public void ClientThrowsExceptionIfNoFactoryIsGiven()
        {
            _client.TestCars();
        }
    }
}