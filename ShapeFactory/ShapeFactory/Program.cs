using System;

namespace ShapeFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();

            IGeometricShape LennyLine = factory.GetShape(ShapeType.LINE);
            if (LennyLine != null)
                LennyLine.Draw();

            IGeometricShape CirceCircle = factory.GetShape(ShapeType.CIRCLE);
            if (CirceCircle != null)
                CirceCircle.Draw();

            IGeometricShape RandyRectangle = factory.GetShape(ShapeType.RECTANGLE);
            if (RandyRectangle != null)
                RandyRectangle.Draw();

            IGeometricShape TerryTriangle = factory.GetShape(ShapeType.TRIANGLE);
            if(TerryTriangle != null)
                TerryTriangle.Draw();
        }
    }
}
