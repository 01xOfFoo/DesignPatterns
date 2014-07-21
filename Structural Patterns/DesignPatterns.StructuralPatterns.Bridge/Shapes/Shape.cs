using DesignPatterns.StructuralPatterns.Bridge.Adorner;

namespace DesignPatterns.StructuralPatterns.Bridge.Shapes
{
    abstract class Shape : IShape
    {
        protected readonly IAdorner Adorner;

        protected Shape(IAdorner adorner)
        {
            Adorner = adorner;
        }

        public abstract void DrawShape();
    }
}