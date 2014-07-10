using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Tests.AbstractFactory.ObjectPool
{
    class Dummy
    {
        public string createdBy { get; private set; }

        public Dummy()
        {
            createdBy = "default constructor";
        }

        public Dummy(string constructorString)
        {
            createdBy = constructorString;
        }
    }
}
