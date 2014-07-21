namespace DesignPatterns.StructuralPatterns.Bridge.Adorner
{
    class VerticalHatchAdorner : IAdorner
    {
        public string Adorn()
        {
            return "with vertical lines";
        }
    }
}