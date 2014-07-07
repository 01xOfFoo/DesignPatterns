using DesignPatterns.CreationalPatterns.AbstractFactory.Cars.Contracts;
using DesignPatterns.CreationalPatterns.AbstractFactory.Factories;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class Program
    {
        private static IClient client = null;

        public static void Main(string[] args)
        {
            client = new Client();

            TestDriveAudiCars();
            TestDriveMercedesCars();

            System.Console.ReadLine();
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
            client.ChangeFactory(carFactory);
            client.TestCars();
        }
    }
}
