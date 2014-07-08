using DesignPatterns.CreationalPatterns.Builder.Brew;
using DesignPatterns.CreationalPatterns.Builder.Brew.Brewery;
using DesignPatterns.CreationalPatterns.Builder.Brew.Brewery.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder
{
    class Program
    {
        private static IBrewer brewer;

        static void Main(string[] args)
        {
            brewer = new Brewer();

            BrewPaulanerBeer();
            BrewBecksBeer();

            Console.ReadLine();
        }

        private static void BrewBecksBeer()
        {
            IBrewery brewery = new BecksBrewery();
            brewer.SetBrewery(brewery);
            BrewBeer();
        }

        private static void BrewPaulanerBeer()
        {
            IBrewery brewery = new PaulanerBrewery();
            brewer.SetBrewery(brewery);
            BrewBeer();
        }

        private static void BrewBeer()
        {
            brewer.BrewBeer();
            Beer beer = brewer.GetBeer();
            Console.WriteLine(beer.ToString());
        }

    }
}
