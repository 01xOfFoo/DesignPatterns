using DesignPatterns.CreationalPatterns.Builder.Brew.Brewery.Contracts;

namespace DesignPatterns.CreationalPatterns.Builder.Brew.Brewery
{
    class BecksBrewery : IBrewery
    {
        private Beer beer;

        public BecksBrewery()
        {
            beer = new Beer();
        }

        public void Brew()
        {
            beer.Volume = 0.33;            
        }

        public void Ferment()
        {
            beer.Potency = 4.9;
        }

        public void Bottle()
        {
            beer.Label = "Becks Pils";
        }

        public void Tag()
        {
            beer.Price = 0.81;
        }

        public Beer GetBeer()
        {
            return beer;
        }
    }
}
