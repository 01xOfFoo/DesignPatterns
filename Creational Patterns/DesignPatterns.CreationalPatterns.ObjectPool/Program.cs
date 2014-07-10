using DesignPatterns.CreationalPatterns.ObjectPool.Pool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            IObjectPool<Employee> objectPool = new ObjectPool<Employee>();

            Employee e1 = objectPool.Consume();
            Console.WriteLine(e1.ToString());

            Employee e2 = objectPool.Consume();
            Console.WriteLine(e2.ToString());

            objectPool.Release(e1);
            Employee e3 = objectPool.Consume();
            Console.WriteLine(e3.ToString());
            
            Console.ReadLine();
        }
    }
}
