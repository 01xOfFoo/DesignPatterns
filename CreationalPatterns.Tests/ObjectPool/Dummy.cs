namespace DesignPatterns.CreationalPatterns.Tests.ObjectPool
{
    internal class Dummy
    {
        public Dummy()
        {
            CreatedBy = "default constructor";
        }

        public Dummy(string constructorString)
        {
            CreatedBy = constructorString;
        }

        public string CreatedBy { get; private set; }
    }
}