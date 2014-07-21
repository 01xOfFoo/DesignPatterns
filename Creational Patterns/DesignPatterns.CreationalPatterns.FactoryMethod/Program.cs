using System;
using DesignPatterns.CreationalPatterns.FactoryMethod.Beer;
using DesignPatterns.CreationalPatterns.FactoryMethod.Brewery;
using DesignPatterns.CreationalPatterns.FactoryMethod.Brewery.Contracts;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    internal static class Program
    {
        private static IBrewery _brewery;

        private static void Main()
        {
            BrewPaulanerWeißbier();
            BrewBecksPilsener();

            Console.ReadLine();
        }

        private static void BrewPaulanerWeißbier()
        {
            _brewery = new PaulanerBrewery();
            BrewBeer();
        }

        private static void BrewBecksPilsener()
        {
            _brewery = new BecksBrewery();
            BrewBeer();
        }

        private static void BrewBeer()
        {
            Brew brew = _brewery.MakeBrew();
            Console.WriteLine(brew.ToString());
        }
    }
}