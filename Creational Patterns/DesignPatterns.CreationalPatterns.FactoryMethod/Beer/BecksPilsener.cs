using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Beer
{
    class BecksPilsener : Brew
    {
        public BecksPilsener()
        {
            Volume = 0.33;
            Potency = 4.9;
            Label = "Becks Pils";
            Price = 0.81;
        }
    }
}
