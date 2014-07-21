using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Contracts;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Factories.Contracts
{
    public interface ICarFactory
    {
        ILimousine CreateLimousine();
        IStationWagon CreateKombi();
    }
}