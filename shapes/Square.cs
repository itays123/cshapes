using System;

namespace Shapes
{
    public class Square : Shape
    {
        // Draw Refrerences
        private static string Y_EDGE_UNIT = "===";
        private static string SPACE_UNIT = "   ";
        private static string X_EDGE_UNIT = "║";
        private static string TOP_LEFT_CORNER = "╔";
        private static string TOP_RIGHT_CORNER = "╗";
        private static string BOTTOM_LEFT_CORNER = "╚";
        private static string BOTTOM_RIGHT_CORNER = "╝";

        // attributes, getters, setters
        private int _side;
        public int Side { 
            get { return _side; } 
            set { _side = Math.Max(value, 1); } 
        }

        public Square(int side) {
            Side = side;
        }

        public override string Draw()
        {
            string s = TOP_LEFT_CORNER, space = "";

            // draw top edge
            for (int i = 0; i < Side; i++)
            {
                space += SPACE_UNIT;
                s += Y_EDGE_UNIT;
            }

            s += TOP_RIGHT_CORNER + "\n";

            // draw sides
            for (int i = 0; i < Side; i++)
                s += X_EDGE_UNIT + space + X_EDGE_UNIT + "\n";

            // draw bottom edge
            s += BOTTOM_LEFT_CORNER;
            for (int i = 0; i < Side; i++)
                s += Y_EDGE_UNIT;

            s += BOTTOM_RIGHT_CORNER + "\n";
            return s;
        }

        public override double GetArea()
        {
            return _side * _side;
        }
    }
}