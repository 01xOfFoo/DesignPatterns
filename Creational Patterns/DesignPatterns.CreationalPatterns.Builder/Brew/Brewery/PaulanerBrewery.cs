using DesignPatterns.CreationalPatterns.Builder.Brew.Brewery.Contracts;

namespace DesignPatterns.CreationalPatterns.Builder.Brew.Brewery
{
    internal class PaulanerBrewery : IBrewery
    {
        private readonly Beer _beer;

        public PaulanerBrewery()
        {
            _beer = new Beer();
        }

        public void Brew()
        {
            _beer.Volume = 0.5;
        }

        public void Ferment()
        {
            _beer.Potency = 5.5;
        }

        public void Bottle()
        {
            _beer.Label = "Paulaner Weißbier";
        }

        public void Tag()
        {
            _beer.Price = 0.97;
        }

        public Beer GetBeer()
        {
            return _beer;
        }
    }
}