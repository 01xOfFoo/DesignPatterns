using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.CreationalPatterns.ObjectPool.Pool;

namespace DesignPatterns.CreationalPatterns.Tests.AbstractFactory.ObjectPool
{
    [TestClass]
    public class ObjectPoolTest
    {
        private IObjectPool<Dummy> buildObjectPool()
        {
            return new ObjectPool<Dummy>();
        }

        private IObjectPool<Dummy> buildObjectPoolWithConstructorDelegate()
        {
            return new ObjectPool<Dummy>( () => new Dummy("special") );                    
        }

        [TestMethod]
        public void CanConsumeObject()
        {
            IObjectPool<Dummy> objectPool = buildObjectPool();
            Dummy dummy = objectPool.Consume();

            Assert.IsNotNull(dummy);
        }

        [TestMethod]
        public void CanReleaseObject()
        {
            IObjectPool<Dummy> objectPool = buildObjectPool();
            Dummy dummy = objectPool.Consume();
            objectPool.Release(dummy);

            Assert.AreEqual(1, objectPool.GetAmountOfConsumeableObjects());
        }

        [TestMethod]
        public void ReturnsTheSameObjectAfterItsBeenReleased()
        {
            IObjectPool<Dummy> objectPool = buildObjectPool();

            Dummy dummy = objectPool.Consume();
            objectPool.Release(dummy);

            Dummy dummy2 = objectPool.Consume();

            Assert.AreSame(dummy, dummy2);
            Assert.AreEqual(0, objectPool.GetAmountOfConsumeableObjects());
        }

        [TestMethod]
        public void CheckIfDelegateIsUsedToConstructObjects()
        {
            IObjectPool<Dummy> objectPool = buildObjectPoolWithConstructorDelegate();
            Dummy dummy = objectPool.Consume();

            Assert.AreEqual("special", dummy.createdBy);
        }
    }
}
