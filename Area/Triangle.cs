
namespace Area
{
    public class Triangle : IShape
    {
        public double Side1 { get; private set;}
        public double Side2 { get; private set;}
        public double Side3 { get; private set;}

        public Triangle(double s1, double s2, double s3) 
        {
            if(s1+s2<=s3 || s1+s3<=s2 || s2+s3<=s1)
            {
                // если стороны не могут создать треугольник, то пусть по дефолту - египетский
                Side1 = 3; Side2 = 4; Side3 = 5; 
            }
            else { Side1 = s1; Side2 = s2; Side3 = s3; }
        }

        public double GetArea()
        {
            //Площадь по формуле Герона
            double halfPer = (Side1 + Side2 + Side3) / 2;
            double Area = Math.Sqrt(halfPer*(halfPer-Side1)*(halfPer-Side2)*(halfPer-Side3));
            return Area;
        }

        public bool IsRectangular()
        {
            //проверка через теорему Пифагора
            //выявление большей стороны, которая является гипотенузой
            if (Side1 > Side2 && Side1 > Side3)
                return Side1 == Math.Sqrt(Math.Pow(Side2, 2) + Math.Pow(Side3, 2));
            else if (Side2 > Side1 && Side2 > Side3)
                return Side2 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side3, 2));
            else 
                return Side3 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2));
        }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
