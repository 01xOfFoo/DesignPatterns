using System;
using DesignPatterns.StructuralPatterns.Bridge.Adorner;
using DesignPatterns.StructuralPatterns.Bridge.Shapes;

namespace DesignPatterns.StructuralPatterns.Bridge
{
    static class Program
    {
        static void Main()
        {
            IAdorner solidRedAdorner = new SolidRedAdorner();
            IShape rectangle = new Rectangle(solidRedAdorner);

            IAdorner verticalHatchAdorner = new VerticalHatchAdorner();
            IShape circle = new Circle(verticalHatchAdorner);

            rectangle.DrawShape();
            circle.DrawShape();

            Console.Read();
        }
    }
}
