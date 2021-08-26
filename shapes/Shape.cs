
namespace Shapes
{
    abstract class Shape
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
        public abstract void Draw();

        /**
            Use the console to ask the user for constructor params.
        */
        public abstract void Initialize();
    }
}