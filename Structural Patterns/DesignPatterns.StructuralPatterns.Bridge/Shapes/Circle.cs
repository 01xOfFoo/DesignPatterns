using System;
using DesignPatterns.StructuralPatterns.Bridge.Adorner;

namespace DesignPatterns.StructuralPatterns.Bridge.Shapes
{
    class Circle : Shape
    {
        public Circle(IAdorner adorner) : base(adorner)
        {
        }

        public override void DrawShape()
        {
            Console.WriteLine("Drawing a circle " + Adorner.Adorn());
        }
    }

}