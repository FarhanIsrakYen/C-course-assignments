using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum: {num1 + num2 + num3}");
        }
    }
}
