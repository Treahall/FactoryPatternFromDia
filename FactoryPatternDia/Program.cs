using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDia
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory Factory = new ShapeFactory();

            Factory.GetShape(ShapeType.Line).Draw();
            Factory.GetShape(ShapeType.Circle).Draw();
            Factory.GetShape(ShapeType.Rectangle).Draw();
            Factory.GetShape(ShapeType.Triangle).Draw();

            Console.ReadKey();
        }
    }

    class ShapeFactory
    {
        public IGeometricShape GetShape(ShapeType type)
        {
            if (type == ShapeType.Line)
            {
                return new Line();
            }
            else if (type == ShapeType.Circle)
            {
                return new Circle();
            }
            else if (type == ShapeType.Rectangle)
            {
                return new Rectangle();
            }
            else
            {
                Console.WriteLine("Returned Null: Shape not implemented");
                return null;
            }
        }
    }

    interface IGeometricShape
    {
        void Draw();
    }

    enum ShapeType
    {
        Line,
        Circle,
        Rectangle,
        Triangle
    }

    class Line : IGeometricShape
    {
        public void Draw()
        {
            Console.WriteLine("A Line is drawn");
        }
    }

    class Circle : IGeometricShape
    {
        public void Draw()
        {
            Console.WriteLine("A Circle is drawn");
        }
    }

    class Rectangle : IGeometricShape
    {
        public void Draw()
        {
            Console.WriteLine("A Rectangle is drawn");
        }
    }
}
