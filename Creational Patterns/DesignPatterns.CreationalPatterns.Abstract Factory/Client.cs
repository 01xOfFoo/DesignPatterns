using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Contracts;
using DesignPatterns.CreationalPatterns.AbstractFactory.Exceptions;
using DesignPatterns.CreationalPatterns.AbstractFactory.Factories.Contracts;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class Client : IClient
    {
        private ICarFactory _factory;

        public void ChangeFactory(ICarFactory factory)
        {
            _factory = factory;
        }

        public void TestCars()
        {
            if (_factory == null)
                throw new CarFactoryNotAssignedException();

            TestLimousine();
            TestStationWagon();
        }

        private void TestStationWagon()
        {
            ICar car = _factory.CreateKombi();
            AccelerateCar(car);
        }

        private void TestLimousine()
        {
            ICar car = _factory.CreateLimousine();
            AccelerateCar(car);
        }

        private static void AccelerateCar(ICar car)
        {
            car.Accelerate();
        }
    }
}