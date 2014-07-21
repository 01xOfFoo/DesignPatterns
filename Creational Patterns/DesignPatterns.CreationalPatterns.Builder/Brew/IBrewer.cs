using DesignPatterns.CreationalPatterns.Builder.Brew.Brewery.Contracts;

namespace DesignPatterns.CreationalPatterns.Builder.Brew
{
    public interface IBrewer
    {
        void SetBrewery(IBrewery brewery);
        void BrewBeer();
        Beer GetBeer();
    }
}