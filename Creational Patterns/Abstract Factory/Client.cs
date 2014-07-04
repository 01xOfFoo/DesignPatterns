using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Contracts;
using DesignPatterns.CreationalPatterns;
using System.Diagnostics;
using System;
using DesignPatterns.CreationalPatterns.AbstractFactory.Exceptions;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class Client : IClient
    {
        private ICarFactory factory = null;

        public void ChangeFactory(ICarFactory factory)
        {
            this.factory = factory;
        }

        public void TestCars()
        {
            if (factory == null)
                throw new CarFactoryNotAssignedException();

            TestLimousine();
            TestStationWagon();
        }

        private void TestStationWagon()
        {
            ICar car = factory.CreateKombi();
            AccelerateCar(car);
        }

        private void TestLimousine()
        {
            ICar car = factory.CreateLimousine();
            AccelerateCar(car);
        }

        private static void AccelerateCar(ICar car)
        {
            car.Accelerate();
        }
    }
}
