using DesignPatterns.CreationalPatterns.FactoryMethod.Beer;
using DesignPatterns.CreationalPatterns.FactoryMethod.Brewery.Contracts;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Brewery
{
    class PaulanerBrewery : IBrewery
    {
        public Brew MakeBrew()
        {
            return new PaulanerWeißbier();
        }
    }
}
