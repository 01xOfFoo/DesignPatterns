using System;

namespace DesignPatterns.CreationalPatterns.Builder.Brew
{
    public class Beer
    {
        public string Label { get; set; }
        public double Volume { get; set; }
        public double Price { get; set; }
        public double Potency { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}l {2}% vol {3} EUR", Label, Volume, Potency, Price);
        }
    }
}