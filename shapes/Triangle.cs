using System;
using ConsoleUtils;

namespace Shapes
{
    public class Triangle : Shape
    {
        private int _base;
        public int Base { 
            get { return _base; } 
            set { _base = Math.Max(value, 1); } 
        }

        private int _height;
        public int Height { 
            get { return _height; } 
            set { _height = Math.Max(value, 1); } 
        }

        public Triangle(int aBase, int height) {
            Base = aBase;
            Height = height;
        }

        public override string Draw()
        {
            return "";
        }

        public override double GetArea()
        {
            return _base * _height / 2;
        }
    }
}