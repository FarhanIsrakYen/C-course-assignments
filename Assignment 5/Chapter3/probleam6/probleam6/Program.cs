using System;

namespace probleam6
{
    class Program
    {
        static void Main(string[] args)
        {
            double side, height, perimeter, area;
            Console.Write("Enter side:");
            side = double.Parse(Console.ReadLine());
            Console.Write("Enter height:");
            height = double.Parse(Console.ReadLine());
            perimeter = 2 * (side + height);
            area = side * height;
            Console.WriteLine($"Area: {area} and Perimeter: {perimeter}");
        }
    }
}
