using Area;

namespace Area.Tests
{
    public class AreaTests
    {
        [Fact]
        public void Circle_getArea_r10_Returned_314_15()
        {
            const double arg1 = 10;
            Circle circle = new Circle(arg1);
            const double exprected = 314.15;
            double result = circle.GetArea();
            Assert.Equal(exprected, result, 0.05);
        }

        [Fact]
        public void Circle_getArea_r5_5_Returned_95()
        {
            const double arg1 = 5.5;
            Circle circle = new Circle(arg1);
            const double exprected = 95.03;
            double result = circle.GetArea();
            Assert.Equal(exprected, result, 0.05);
        }

        [Fact]
        public void Triangle_getArea_s3s4s5_Returned_6()
        {
            const double arg1 = 3;
            const double arg2 = 4;
            const double arg3 = 5;
            Triangle triange = new Triangle(arg1,arg2,arg3);
            const double exprected = 6;
            double result = triange.GetArea();
            Assert.Equal(exprected, result, 0.05);
        }

        [Fact]
        public void Triangle_getArea_s12_6s4_4s10_Returned_19_6()
        {
            const double arg1 = 12.6;
            const double arg2 = 4.4;
            const double arg3 = 10;
            Triangle triange = new Triangle(arg1, arg2, arg3);
            const double exprected = 19.67;
            double result = triange.GetArea();
            Assert.Equal(exprected, result, 0.05);
        }

        [Fact]
        public void Triangle_IsRectangular_s3s4s5_ReturnedTrue()
        {
            const double arg1 = 3;
            const double arg2 = 4;
            const double arg3 = 5;
            Triangle triange = new Triangle(arg1, arg2, arg3);
            const bool exprected = true;
            bool result = triange.IsRectangular();
            Assert.Equal(exprected, result);
        }

        [Fact]
        public void Triangle_IsRectangular_s8s6s10_ReturnedTrue()
        {
            const double arg1 = 8;
            const double arg2 = 6;
            const double arg3 = 10;
            Triangle triange = new Triangle(arg1, arg2, arg3);
            const bool exprected = true;
            bool result = triange.IsRectangular();
            Assert.Equal(exprected, result);
        }

        [Fact]
        public void Triangle_IsRectangular_s5s7s10_ReturnedFalse()
        {
            const double arg1 = 5;
            const double arg2 = 7;
            const double arg3 = 10;
            Triangle triange = new Triangle(arg1, arg2, arg3);
            const bool exprected = false;
            bool result = triange.IsRectangular();
            Assert.Equal(exprected, result);
        }
    }
}