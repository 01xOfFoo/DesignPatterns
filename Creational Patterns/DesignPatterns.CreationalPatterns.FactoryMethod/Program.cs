using DesignPatterns.CreationalPatterns.FactoryMethod.Beer;
using DesignPatterns.CreationalPatterns.FactoryMethod.Brewery;
using DesignPatterns.CreationalPatterns.FactoryMethod.Brewery.Contracts;
using System;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    class Program
    {
        private static IBrewery brewery;

        static void Main(string[] args)
        {
            BrewPaulanerWeißbier();
            BrewBecksPilsener();

            Console.ReadLine();
        }

        private static void BrewPaulanerWeißbier()
        {
            brewery = new PaulanerBrewery();
            BrewBeer();
        }

        private static void BrewBecksPilsener()
        {
            brewery = new BecksBrewery();
            BrewBeer();
        }

        private static void BrewBeer()
        {
            Brew brew = brewery.MakeBrew();
            Console.WriteLine(brew.ToString());
        }
    }
}
