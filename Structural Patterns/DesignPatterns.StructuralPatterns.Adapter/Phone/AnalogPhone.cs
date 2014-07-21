using System;

namespace DesignPatterns.StructuralPatterns.Adapter.Phone
{
    class AnalogPhone
    {
        public void PickUpPhone()
        {
            Console.WriteLine("Pick up phone");
        }

        public void DialSingleNumber(char phoneNumber)
        {
            Console.WriteLine("Dialing number {0}", phoneNumber);
        }
    }
}