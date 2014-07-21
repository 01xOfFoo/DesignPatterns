namespace DesignPatterns.StructuralPatterns.Bridge.Adorner
{
    class SolidRedAdorner : IAdorner
    {
        public string Adorn()
        {
            return "in solid red color";
        }
    }
}