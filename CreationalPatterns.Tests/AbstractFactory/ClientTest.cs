using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.CreationalPatterns.AbstractFactory.Exceptions;
using DesignPatterns.CreationalPatterns.AbstractFactory;

namespace DesignPatterns.CreationalPatterns.Tests.AbstractFactory
{
    [TestClass]
    public class AbstractFactoryTest
    {
        private Client client;

        [TestInitialize]
        public void SetUp()
        {
            client = new Client();
        }

        [TestMethod]
        [ExpectedException(typeof(CarFactoryNotAssignedException))]
        public void ClientThrowsExceptionIfNoFactoryIsGiven()
        {
            client.TestCars();
        }
    }
}