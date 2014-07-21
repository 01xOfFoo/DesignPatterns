using DesignPatterns.CreationalPatterns.AbstractFactory.Factories.Contracts;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public interface IClient
    {
        void ChangeFactory(ICarFactory carFactory);
        void TestCars();
    }
}