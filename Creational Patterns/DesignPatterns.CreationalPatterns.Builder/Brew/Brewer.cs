using DesignPatterns.CreationalPatterns.Builder.Brew.Brewery.Contracts;
using DesignPatterns.CreationalPatterns.Builder.Brew.Exceptions;

namespace DesignPatterns.CreationalPatterns.Builder.Brew
{
    public class Brewer : IBrewer
    {
        private IBrewery _brewery;

        public void SetBrewery(IBrewery brewery)
        {
            _brewery = brewery;
        }

        public Beer GetBeer()
        {
            return _brewery.GetBeer();
        }

        public void BrewBeer()
        {
            if (_brewery == null)
                throw new BreweryNotAssignedException();

            _brewery.Brew();
            _brewery.Ferment();
            _brewery.Bottle();
            _brewery.Tag();
        }
    }
}