using System;
using System.Collections.Generic;

namespace DesignPatterns.CreationalPatterns.ObjectPool.Pool
{
    public class ObjectPool<T> : IObjectPool<T> where T : class, new()
    {
        private readonly Func<T> _constructor;
        private readonly Queue<T> _pool = new Queue<T>();

        public ObjectPool()
        {
            ConcurrendconsumedObjectsCount = 0;
        }

        public ObjectPool(Func<T> constructor) : this()
        {
            _constructor = constructor;
        }

        public int ConcurrendconsumedObjectsCount { get; set; }

        public T Consume()
        {
            T instance;
            if (_pool.Count == 0)
            {
                instance = BuildObject();
                ConcurrendconsumedObjectsCount++;
            }
            else
            {
                instance = _pool.Dequeue();
            }
            return instance;
        }

        public void Release(T instance)
        {
            _pool.Enqueue(instance);
            ConcurrendconsumedObjectsCount--;
        }

        public int GetAmountOfConsumeableObjects()
        {
            return _pool.Count;
        }

        private T BuildObject()
        {
            return _constructor != null ? _constructor() : new T();
        }
    }
}