using System;

namespace DesignPatterns.StructuralPatterns.Adapter.Phone

{
    class DigitalPhone : IPhone
    {
        public void Dial(string phonenumber)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Digital phone:");
            Console.WriteLine("Dialing number {0}", phonenumber);
            Console.WriteLine("Pick up phone");
        }
    }
}