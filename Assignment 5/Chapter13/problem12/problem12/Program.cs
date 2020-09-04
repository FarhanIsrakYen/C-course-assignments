using System;

namespace problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0, -15} {1, 15}", "Decimal:", number);
            Console.WriteLine("{0, -15} {1, 15}", "Hexadecimal:", number.ToString("X"));
            Console.WriteLine("{0, -15} {1, 15}", "Currency:", string.Format("{0:C}", number));
            Console.WriteLine("{0, -15} {1, 15}", "Percent:", string.Format("{0:P2}", number));
            Console.WriteLine("{0, -15} {1, 15}", "Scientific:", number.ToString("\\0.#####E0"));
        }
    }
}
