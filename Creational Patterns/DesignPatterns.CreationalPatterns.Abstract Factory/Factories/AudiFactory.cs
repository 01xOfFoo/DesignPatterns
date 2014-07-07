using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Audi;
using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Contracts;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Factories
{
    class AudiFactory : ICarFactory
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
