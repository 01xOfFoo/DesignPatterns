using DesignPatterns.StructuralPatterns.Adapter.Phone;

namespace DesignPatterns.StructuralPatterns.Adapter.Agent
{
    public class CallAgent : ICallAgent
    {
        private readonly IPhone _phone;

        public CallAgent(IPhone phone)
        {
            _phone = phone;
        }

        public void CallNumber(string phoneNumber)
        {
            _phone.Dial(phoneNumber);
        }
    }
}