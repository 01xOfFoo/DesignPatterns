using System;
using DesignPatterns.CreationalPatterns.ObjectPool.Pool;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    internal static class Program
    {
        private static void Main()
        {
            IObjectPool<Employee> objectPool = new ObjectPool<Employee>();

            var e1 = objectPool.Consume();
            Console.WriteLine(e1.ToString());

            var e2 = objectPool.Consume();
            Console.WriteLine(e2.ToString());

            objectPool.Release(e1);
            var e3 = objectPool.Consume();
            Console.WriteLine(e3.ToString());

            Console.ReadLine();
        }
    }
}