using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeFactory
{
    public enum ShapeType
    {
        LINE,
        CIRCLE,
        RECTANGLE,
        TRIANGLE
    }
    internal class ShapeFactory
    {
        public IGeometricShape GetShape(ShapeType shape)
        {
            switch (shape)
            {
                case ShapeType.LINE:
                    Line L = new Line();
                    return L;

                case ShapeType.CIRCLE:
                    Circle C = new Circle();
                    return C;

                case ShapeType.RECTANGLE:
                    Rectangle R = new Rectangle();
                    return R;

                case ShapeType.TRIANGLE:
                    return null;

                default:
                    return null;
            }
        }
    }

    abstract class IGeometricShape
    {
        public abstract void Draw();
    }

    class Line : IGeometricShape
    {
        public override void Draw()
        {
            Console.WriteLine("Draws a line");
        }
    }

    class Circle : IGeometricShape
    {
        public override void Draw()
        {
            Console.WriteLine("Draws a circle");
        }
    }

    class Rectangle : IGeometricShape
    {
        public override void Draw()
        {
            Console.WriteLine("Draws a rectangle");
        }
    }
}
