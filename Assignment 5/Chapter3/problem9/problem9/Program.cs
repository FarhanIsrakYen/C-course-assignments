using System;

namespace problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            const int RADIUS = 5;
            const int BOTTOMLEFTX = -1;
            const int BOTTOMLEFTY = 1;
            const int UPPERRIGHTX = 5;
            const int UPPERRIGHTY = 5;
            int x, y;
            Console.Write("Enter x:");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter y:");
            y = int.Parse(Console.ReadLine());
            if(x >= BOTTOMLEFTX && y >= BOTTOMLEFTY && x <= UPPERRIGHTX && y <= UPPERRIGHTY)
                Console.WriteLine($"In the Rectangle");
            else
                Console.WriteLine($"Out of the Rectangle");

            if (((x * x) + (y * y) <= (RADIUS * RADIUS)))
                Console.WriteLine($"In the circle");
            else
                Console.WriteLine($"Out of the circle");
        }
    }
}
