using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Contracts;
using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Mercedes;
using DesignPatterns.CreationalPatterns.AbstractFactory.Factories.Contracts;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Factories
{
    internal class MercedesFactory : ICarFactory
    {
        public ILimousine CreateLimousine()
        {
            return new MercedesLimousine();
        }

        public IStationWagon CreateKombi()
        {
            return new MercedesStationWagon();
        }
    }
}