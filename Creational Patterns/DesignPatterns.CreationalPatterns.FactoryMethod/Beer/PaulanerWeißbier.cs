namespace DesignPatterns.CreationalPatterns.FactoryMethod.Beer
{
    internal class PaulanerWeißbier : Brew
    {
        public PaulanerWeißbier()
        {
            Volume = 0.5;
            Potency = 5.5;
            Label = "Paulaner Weißbier";
            Price = 0.97;
        }
    }
}