
namespace DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Contracts
{
    public interface ICarFactory
    {
        ILimousine CreateLimousine();
        IStationWagon CreateKombi();
    }
}
