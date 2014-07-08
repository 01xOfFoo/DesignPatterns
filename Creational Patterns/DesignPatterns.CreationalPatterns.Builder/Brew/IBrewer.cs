using DesignPatterns.CreationalPatterns.Builder.Brew.Brewery.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.Brew
{
    public interface IBrewer
    {
        void SetBrewery(IBrewery brewery);
        void BrewBeer();
        Beer GetBeer();
    }
}
