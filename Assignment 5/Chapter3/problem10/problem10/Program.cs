using System;

namespace problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, a, b, c, d;
            number = int.Parse(Console.ReadLine());
            a = (int)(number / 1000);
            b = (int)((number - a * 1000) / 100);
            c = (int)(((number - a * 1000) - b * 100) / 10);
            d = (int)(((number - a * 1000) - b * 100) - c * 10);
            Console.WriteLine($"Sum of the digits: {(a + b + c + d)}" );
            Console.WriteLine($"Reversed order: {d}{c}{b}{a}");
            Console.WriteLine($"Last digit first: {d}{a}{b}{c}");
            Console.WriteLine($"Exchange second and third digit: {a}{c}{b}{d}");
        }
    }
}
