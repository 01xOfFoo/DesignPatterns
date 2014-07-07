using DesignPatterns.CreationalPatterns.Builder.Brew;
using DesignPatterns.CreationalPatterns.Builder.Brew.Brewery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Brewer brewer = new Brewer();

            BrewPaulanerBeer(brewer);
            BrewBecksBeer(brewer);

            Console.ReadLine();
        }

        private static void BrewBecksBeer(Brewer brewer)
        {
            brewer.SetBrewery(new BecksBrewery());
            brewer.BrewBeer();
            Beer beer = brewer.GetBeer();
            Console.WriteLine(beer.ToString());
        }

        private static void BrewPaulanerBeer(Brewer brewer)
        {
            brewer.SetBrewery(new PaulanerBrewery());
            brewer.BrewBeer();
            Beer beer = brewer.GetBeer();

            Console.WriteLine(beer.ToString());
        }
    }
}
