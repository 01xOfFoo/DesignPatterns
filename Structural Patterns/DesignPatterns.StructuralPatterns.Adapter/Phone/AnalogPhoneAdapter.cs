using System;

namespace DesignPatterns.StructuralPatterns.Adapter.Phone
{
    class AnalogPhoneAdapter : IPhone
    {
        private readonly AnalogPhone _analogPhone;

        public AnalogPhoneAdapter(AnalogPhone analogPhone)
        {
            _analogPhone = analogPhone;
        }

        public void Dial(string phonenumber)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Analog phone:");
            _analogPhone.PickUpPhone();

            DialUpPhoneNumber(phonenumber);
        }

        private void DialUpPhoneNumber(string phonenumber)
        {
            foreach (var number in phonenumber)
                _analogPhone.DialSingleNumber(number);
        }
    }
}