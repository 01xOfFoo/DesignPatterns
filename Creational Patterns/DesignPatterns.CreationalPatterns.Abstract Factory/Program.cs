using System;
using DesignPatterns.CreationalPatterns.AbstractFactory.Factories;
using DesignPatterns.CreationalPatterns.AbstractFactory.Factories.Contracts;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public static class Program
    {
        private static IClient _client;

        public static void Main()
        {
            _client = new Client();

            TestDriveAudiCars();
            TestDriveMercedesCars();

            Console.ReadLine();
        }

        private static void TestDriveAudiCars()
        {
            ICarFactory carFactory = new AudiFactory();
            TestDrive(carFactory);
        }

        private static void TestDriveMercedesCars()
        {
            ICarFactory carFactory = new MercedesFactory();
            TestDrive(carFactory);
        }

        private static void TestDrive(ICarFactory carFactory)
        {
            _client.ChangeFactory(carFactory);
            _client.TestCars();
        }
    }
}