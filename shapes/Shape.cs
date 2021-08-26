
namespace Shapes
{
    public abstract class Shape
    {
        protected Shape()
        {
        }

        /**
            Get the area of the shape
        */
        public abstract double GetArea();

        /**
            Use the console to draw the shape
        */
        public abstract string Draw();
    }
}