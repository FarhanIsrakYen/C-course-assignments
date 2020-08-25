using System;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;
            double r = int.Parse(Console.ReadLine());
            Console.WriteLine($"Area: {PI * r * r} Perimeter: {2 * PI * r}");
        }
    }
}
