using System;
using DesignPatterns.StructuralPatterns.Bridge.Adorner;

namespace DesignPatterns.StructuralPatterns.Bridge.Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(IAdorner adorner) : base(adorner)
        {
        }

        public override void DrawShape()
        {
            Console.WriteLine("Drawing a rectangle " + Adorner.Adorn());
        }
    }
}