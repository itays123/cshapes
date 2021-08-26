
namespace cshapes
{
    abstract class Shape
    {
        protected Shape()
        {
        }

        public abstract double GetArea();

        public abstract void Draw();

        public abstract void Initialize();
    }
}