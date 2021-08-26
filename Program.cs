using System;
using ConsoleUtils;
using Shapes;

namespace cshapes
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeName shapeName = MyConsole.ReadLine<ShapeName>("Enter shape name (Square/Triangle/Circle)", ShapeName.Square);
            Console.WriteLine(shapeName);
        }
    }
}
