using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Beer
{
    class PaulanerWeißbier : Brew
    {
        public PaulanerWeißbier()
        {
            Volume = 0.5;
            Potency = 5.5;
            Label = "Paulaner Weißbier";
            Price = 0.97;
        }        
    }
}
