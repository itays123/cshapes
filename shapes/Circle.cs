using System;

namespace Shapes
{
    public class Circle : Shape
    {

        // draw references
        private static double RADIUS_EPSLION = 10.140735;
        private static string CRICLE_EDGE = "C#";
        private static string SPACE = "  ";

        // attributes & properties

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
            string s = "";
            bool pointOnCirc = false;
            double distanceFromCenter;
            for (int x = -1 * Radius; x <= Radius; x++) {
                for (int y = -1 * Radius; y <= Radius; y++) {
                    distanceFromCenter = Math.Sqrt(x*x + y*y);
                    pointOnCirc = Math.Abs(distanceFromCenter - Radius) <= (Radius / RADIUS_EPSLION);
                    s+= pointOnCirc ? CRICLE_EDGE : SPACE;
                }
                s+= "\n";
            }
            return s;
        }

        public override double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}