using DesignPatterns.CreationalPatterns.Builder.Brew.Brewery.Contracts;

namespace DesignPatterns.CreationalPatterns.Builder.Brew.Brewery
{
    class PaulanerBrewery : IBrewery
    {
        private Beer beer;

        public PaulanerBrewery()
        {
            beer = new Beer();
        }

        public void Brew()
        {
            beer.Volume = 0.5;
        }

        public void Ferment()
        {
            beer.Potency = 5.5;
        }

        public void Bottle()
        {
            beer.Label = "Paulaner Weißbier";
        }

        public void Tag()
        {
            beer.Price = 0.97;
        }

        public Beer GetBeer()
        {
            return beer;
        }
    }
}
