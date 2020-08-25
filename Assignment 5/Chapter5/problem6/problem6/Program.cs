using System;

namespace problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            double result;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            result = Math.Pow(b, 2) - 4 * a * c;
            if (result == 0)
            {
                Console.WriteLine($"discriminant = 0, one real root: {-b / (2 * a)}");
            }
            else if (result < 0)
            {
                Console.WriteLine("discriminant is negative, no real roots.");
            }
            else 
            {
                Console.WriteLine("discriminant is positive, two real roots {(-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a)}" +
                    $"and {(-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a)}");
            }   
        }
    }
}
