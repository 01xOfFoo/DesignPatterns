using DesignPatterns.CreationalPatterns.Builder.Brew;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.CreationalPatterns.Builder.Brew.Exceptions;

namespace DesignPatterns.CreationalPatterns.Tests.AbstractFactory.AbstractFactory
{
    [TestClass]
    public class BrewerTest
    {
        private Brewer brewer;

        [TestInitialize]
        public void SetUp()
        {
            brewer = new Brewer();
        }

        [TestMethod]
        [ExpectedException(typeof(BreweryNotAssignedException))]
        public void ExceptIfNoBreweryAssigned()
        {
            brewer.BrewBeer();
        }
    }
}
