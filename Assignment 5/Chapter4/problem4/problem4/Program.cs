using System;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            float number2, number3;
            Console.WriteLine("Enter 3 numbers:");
            number1 =int.TryParse(Console.ReadLine(), out );
            number2 = float.Parse(Console.ReadLine());
            number3 = float.Parse(Console.ReadLine());
            Console.WriteLine("{0,-10:X}{1,-10:0.00}{2,-10:-0.00}", number1, number2, number3);
        }
    }
}
