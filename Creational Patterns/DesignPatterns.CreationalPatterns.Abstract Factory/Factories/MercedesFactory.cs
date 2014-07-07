using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Contracts;
using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Mercedes;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Factories
{
    class MercedesFactory : ICarFactory
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
