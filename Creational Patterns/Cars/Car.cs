using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Contracts;
using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Cars
{
    class Car : ICar
    {
        public Car()
        {
            Console.WriteLine(this.GetType().Name + " constructed");
        }

        public void Accelerate()
        {
            Console.WriteLine(this.GetType().Name + " accelerates");
        }
    }
}
