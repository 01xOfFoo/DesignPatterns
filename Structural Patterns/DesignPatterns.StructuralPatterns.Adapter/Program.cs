using System;
using DesignPatterns.StructuralPatterns.Adapter.Agent;
using DesignPatterns.StructuralPatterns.Adapter.Phone;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    static class Program
    {
        static void Main()
        {
            var analogPhone = new AnalogPhone();
            IPhone phone = new AnalogPhoneAdapter(analogPhone);
            var agent = new CallAgent(phone);
            agent.CallNumber("0800123456");

            phone = new DigitalPhone();
            agent = new CallAgent(phone);
            agent.CallNumber("0800123456");

            Console.Read();
        }
    }
}
