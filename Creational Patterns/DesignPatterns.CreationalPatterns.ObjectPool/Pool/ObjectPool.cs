using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.ObjectPool.Pool
{
    public class ObjectPool<T> : IObjectPool<T> where T : class, new()
    {
        private Func<T> constructor = null;
        private Queue<T> pool = new Queue<T>();
        private int concurrendconsumedObjectsCount;

        public ObjectPool()
        {
            this.concurrendconsumedObjectsCount = 0;
        }

        public ObjectPool(Func<T> constructor) : this()
        {
            this.constructor = constructor;
        }

        public T Consume()
        {
            T instance = null;
            if (this.pool.Count == 0)
            {
                instance = buildObject();
                this.concurrendconsumedObjectsCount++;
            }
            else
            {
                instance = this.pool.Dequeue();
            }
            return instance;
        }

        private T buildObject()
        {
            T instance = null;
            if (this.constructor != null)
            {
                instance = this.constructor();
            }
            else
        	{
                instance = new T();
            }
            return instance;
        }

        public void Release(T instance)
        {
            this.pool.Enqueue(instance);
            this.concurrendconsumedObjectsCount--;
        }

        public int GetAmountOfConsumeableObjects()
        {
            return this.pool.Count;
        }
    }
}