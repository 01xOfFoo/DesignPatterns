using DesignPatterns.CreationalPatterns.FactoryMethod.Beer;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Brewery.Contracts
{
    public interface IBrewery
    {
        Brew MakeBrew();
    }
}
