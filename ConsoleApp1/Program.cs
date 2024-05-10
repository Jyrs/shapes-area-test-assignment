using Area;

namespace ConsoleApp
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Console.WriteLine(circle.GetArea()+"\n");

            Triangle triangle = new Triangle(6,10,8);
            Console.WriteLine(triangle.IsRectangular());
            Console.WriteLine(triangle.GetArea()+"\n");

            Area(triangle);
            Area(circle);

        }

        static void Area(IShape shape)
        {
            Console.WriteLine(shape.GetArea());
        }

    }


}
