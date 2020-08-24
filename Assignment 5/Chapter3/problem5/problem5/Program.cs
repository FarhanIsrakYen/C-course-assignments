using System;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, a, b, area;
            Console.Write("Enter side a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            h = double.Parse(Console.ReadLine());
            area = 0.5 * ((a + b) * h);
            Console.WriteLine($"Area:{area}");
        }
    }
}
