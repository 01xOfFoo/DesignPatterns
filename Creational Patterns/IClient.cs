using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Contracts;

namespace DesignPatterns.CreationalPatterns
{
    public interface IClient
    {
        void ChangeFactory(ICarFactory carFactory);
        void TestCars();
    }
}
