using DesignPatterns.CreationalPatterns.Builder.Brew;
using DesignPatterns.CreationalPatterns.Builder.Brew.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.CreationalPatterns.Tests.Builder
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
        [ExpectedException(typeof (BreweryNotAssignedException))]
        public void ExceptIfNoBreweryAssigned()
        {
            brewer.BrewBeer();
        }
    }
}