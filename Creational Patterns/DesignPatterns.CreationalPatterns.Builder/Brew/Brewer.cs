using DesignPatterns.CreationalPatterns.Builder.Brew.Brewery.Contracts;
using DesignPatterns.CreationalPatterns.Builder.Brew.Exceptions;

namespace DesignPatterns.CreationalPatterns.Builder.Brew
{
    public class Brewer : IBrewer
    {
        private IBrewery brewery;
        
        public void SetBrewery(IBrewery brewery)
        {
            this.brewery = brewery;
        }

        public Beer GetBeer()
        {
            return brewery.GetBeer();
        }

        public void BrewBeer()
        {
            if (brewery == null)
                throw new BreweryNotAssignedException();

            brewery.Brew();
            brewery.Ferment();
            brewery.Bottle();
            brewery.Tag();
        }
    }
}
