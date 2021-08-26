using System;

namespace Shapes
{
    public class Square : Shape
    {
        private int _side;
        public int Side { 
            get { return _side; } 
            set { _side = Math.Max(value, 1); } 
        }

        public Square() {
            Side = 1;
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }

        public override double GetArea()
        {
            return _side * _side;
        }

        public override void Initialize()
        {
            throw new System.NotImplementedException();
        }
    }
}