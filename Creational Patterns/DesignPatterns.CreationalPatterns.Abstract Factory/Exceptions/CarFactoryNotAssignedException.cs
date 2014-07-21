using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Exceptions
{
    public class CarFactoryNotAssignedException : Exception
    {
        public CarFactoryNotAssignedException() : base("No factory assigned")
        {
        }
    }
}