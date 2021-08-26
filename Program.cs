using System;
using ConsoleUtils;
using Shapes;

namespace cshapes
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeName shapeName = MyConsole.ReadLine<ShapeName>("Enter shape name (Square/Circle/Triangle)", ShapeName.Square);
            Shape shape;
            switch (shapeName) {
                case ShapeName.Circle:
                    shape = new Circle(MyConsole.ReadLine<int>("Enter Circle Radius"));
                    break;
                case ShapeName.Triangle:
                    shape = new Triangle(MyConsole.ReadLine<int>("Enter Triangle Base"), MyConsole.ReadLine<int>("Enter Triangle Height"));
                    break;
                case ShapeName.Square:
                default:
                    shape = new Square(MyConsole.ReadLine<int>("Enter Square Side"));
                    break;
            }
            Console.WriteLine("Created " + shapeName + " with area of " + shape.GetArea());
            Console.WriteLine(shape.Draw());
        }
    }
}
