using System;
using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Contracts;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Cars
{
    internal class Car : ICar
    {
        public Car()
        {
            Console.WriteLine(GetType().Name + " constructed");
        }

        public void Accelerate()
        {
            Console.WriteLine(GetType().Name + " accelerates");
        }
    }
}