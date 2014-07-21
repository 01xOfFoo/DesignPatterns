using System;
using DesignPatterns.CreationalPatterns.Builder.Brew;
using DesignPatterns.CreationalPatterns.Builder.Brew.Brewery;
using DesignPatterns.CreationalPatterns.Builder.Brew.Brewery.Contracts;

namespace DesignPatterns.CreationalPatterns.Builder
{
    internal static class Program
    {
        private static IBrewer _brewer;

        private static void Main()
        {
            _brewer = new Brewer();

            BrewPaulanerBeer();
            BrewBecksBeer();

            Console.ReadLine();
        }

        private static void BrewBecksBeer()
        {
            IBrewery brewery = new BecksBrewery();
            _brewer.SetBrewery(brewery);
            BrewBeer();
        }

        private static void BrewPaulanerBeer()
        {
            IBrewery brewery = new PaulanerBrewery();
            _brewer.SetBrewery(brewery);
            BrewBeer();
        }

        private static void BrewBeer()
        {
            _brewer.BrewBeer();
            Beer beer = _brewer.GetBeer();
            Console.WriteLine(beer.ToString());
        }
    }
}