using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.ObjectPool.Pool
{
    public interface IObjectPool<T> where T : class
    {
        T Consume();
        void Release(T instance);
        int GetAmountOfConsumeableObjects();
    }
}
