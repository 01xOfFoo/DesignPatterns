namespace DesignPatterns.CreationalPatterns.FactoryMethod.Beer
{
    internal class BecksPilsener : Brew
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