using System;

namespace Assisgnment1
     
{
    class Program
    {
        static void Main(string[] args)
        {

            double r = 5.56;
            double s = 12.324;
            double w = 20.2;
            double l = 10.15;
            Console.WriteLine($"Area of Circle with Radius {r} is: {areaofcircle(r)}");
            Console.WriteLine($"Perimeter of Circle with Radius {r} is: {perimeterOfCircle(r)}");
            Console.WriteLine($"Area of Equilateral Triangle with side {s} is: {equilateralTriangleArea(s)}");
            Console.WriteLine($"Area of Rectangle with width {w} and length {l} is: {areaOfRectangle(l,w)}");


        }
        static double areaofcircle(double radius)
        {
        double area = Math.PI * Math.Pow(radius,2);
            return area;
        }
        static double perimeterOfCircle(double radius)
        {
            double area = 2 * Math.PI * radius;
            return area;
        }
        static double equilateralTriangleArea(double side)
        {
            double area = (Math.Sqrt(3)/4)*Math.Pow(side,2);
            return area;
        }
        static double areaOfRectangle(double length, double width)
        {
            double area = length * width;
            return area;
        }
    }
    
}
