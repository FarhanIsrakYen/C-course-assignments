using System;

namespace problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = 5;
            int x, y;
            Console.Write("Enter x:");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter y:");
            y = int.Parse(Console.ReadLine());
            if (((x * x) + (y * y) <= (radius * radius)))
                Console.WriteLine($"In the circle");
            else
                Console.WriteLine($"Out of the circle");
        }
    }
}
