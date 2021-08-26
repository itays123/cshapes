using System;

namespace Shapes
{
    public class Triangle : Shape
    {

        // draw refrences
        private static string TRIANGLE_UNIT = "#";
        private static string SPACE = " ";

        // attributes and properties
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
            string s = "";
            int margin;
            for (int y = Height; y > 0; --y)
            {
                s+=TRIANGLE_UNIT;
                // because the longest edge is at the line y=(-h/b)x + h (between [0,h] and [b,0])
                // the margin (x), represented by spaces, would equal b-by/h. 
                // One margin is represented by the starting triangle unit, so subtract one from the result.
                margin = Base  - Base * y / Height - 1;
                if (margin >= 0) {
                    for (int i = 0; i < margin; i++)
                        s+=SPACE;
                    s+=TRIANGLE_UNIT;
                }
                    
                s+="\n";
            }

            // add base
            for (int i = 0; i < Base; i++)
            {
                s+=TRIANGLE_UNIT;
            }
            return s;
        }
        public override double GetArea()
        {
            return _base * _height / 2;
        }
    }
}