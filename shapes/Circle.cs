using System;
using ConsoleUtils;

namespace Shapes
{
    public class Circle : Shape
    {
        private int _radius;
        public int Radius { 
            get { return _radius; } 
            set { _radius = Math.Max(value, 1); } 
        }

        public Circle(int radius) {
            Radius = radius;
        }

        public override string Draw()
        {
            return "";
        }

        public override double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}