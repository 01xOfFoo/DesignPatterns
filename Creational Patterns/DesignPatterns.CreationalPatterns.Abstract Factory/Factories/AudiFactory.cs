using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Audi;
using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Contracts;
using DesignPatterns.CreationalPatterns.AbstractFactory.Factories.Contracts;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Factories
{
    internal class AudiFactory : ICarFactory
    {
        public ILimousine CreateLimousine()
        {
            return new AudiLimousine();
        }

        public IStationWagon CreateKombi()
        {
            return new AudiStationWagon();
        }
    }
}