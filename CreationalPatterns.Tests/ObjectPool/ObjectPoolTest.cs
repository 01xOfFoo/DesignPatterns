using DesignPatterns.CreationalPatterns.ObjectPool.Pool;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.CreationalPatterns.Tests.ObjectPool
{
    [TestClass]
    public class ObjectPoolTest
    {
        private IObjectPool<Dummy> BuildObjectPool()
        {
            return new ObjectPool<Dummy>();
        }

        private IObjectPool<Dummy> BuildObjectPoolWithConstructorDelegate()
        {
            return new ObjectPool<Dummy>(() => new Dummy("special"));
        }

        [TestMethod]
        public void CanConsumeObject()
        {
            IObjectPool<Dummy> objectPool = BuildObjectPool();
            Dummy dummy = objectPool.Consume();

            Assert.IsNotNull(dummy);
        }

        [TestMethod]
        public void CanReleaseObject()
        {
            IObjectPool<Dummy> objectPool = BuildObjectPool();
            Dummy dummy = objectPool.Consume();
            objectPool.Release(dummy);

            Assert.AreEqual(1, objectPool.GetAmountOfConsumeableObjects());
        }

        [TestMethod]
        public void ReturnsTheSameObjectAfterItsBeenReleased()
        {
            IObjectPool<Dummy> objectPool = BuildObjectPool();

            Dummy dummy = objectPool.Consume();
            objectPool.Release(dummy);

            Dummy dummy2 = objectPool.Consume();

            Assert.AreSame(dummy, dummy2);
            Assert.AreEqual(0, objectPool.GetAmountOfConsumeableObjects());
        }

        [TestMethod]
        public void CheckIfDelegateIsUsedToConstructObjects()
        {
            IObjectPool<Dummy> objectPool = BuildObjectPoolWithConstructorDelegate();
            Dummy dummy = objectPool.Consume();

            Assert.AreEqual("special", dummy.CreatedBy);
        }
    }
}