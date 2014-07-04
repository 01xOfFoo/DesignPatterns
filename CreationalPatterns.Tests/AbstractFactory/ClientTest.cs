using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.CreationalPatterns.AbstractFactory.Exceptions;
using DesignPatterns.CreationalPatterns.AbstractFactory;

namespace DesignPatterns.CreationalPatterns.Tests.AbstractFactory
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        [ExpectedException(typeof(CarFactoryNotAssignedException))]
        public void ClientThrowsExceptionIfNoFactoryIsGiven()
        {
            Client client = new Client();
            client.TestCars();
        }
    }
}