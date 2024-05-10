
namespace Area
{
    public class Circle: IShape
    {
        public Circle(double r) {
            if (r <= 0) 
                Radius = 1;
            else 
                Radius = r; 
        }

        public double Radius { get; private set; }

        public double GetArea() {

            return pi * Math.Pow(Radius, 2);
        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        private const double pi = 3.14159;

    }
}
