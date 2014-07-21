using DesignPatterns.CreationalPatterns.Builder.Brew.Brewery.Contracts;

namespace DesignPatterns.CreationalPatterns.Builder.Brew.Brewery
{
    internal class BecksBrewery : IBrewery
    {
        private readonly Beer _beer;

        public BecksBrewery()
        {
            _beer = new Beer();
        }

        public void Brew()
        {
            _beer.Volume = 0.33;
        }

        public void Ferment()
        {
            _beer.Potency = 4.9;
        }

        public void Bottle()
        {
            _beer.Label = "Becks Pils";
        }

        public void Tag()
        {
            _beer.Price = 0.81;
        }

        public Beer GetBeer()
        {
            return _beer;
        }
    }
}