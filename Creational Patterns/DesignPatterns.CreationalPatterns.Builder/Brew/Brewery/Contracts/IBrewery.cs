
namespace DesignPatterns.CreationalPatterns.Builder.Brew.Brewery.Contracts
{
    public interface IBrewery
    {
        void Brew();
        void Ferment();
        void Bottle();
        void Tag();
        Beer GetBeer();
    }
}
