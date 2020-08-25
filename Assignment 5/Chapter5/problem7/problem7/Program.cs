using System;

namespace problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;
            int number4;
            int number5;
            Console.WriteLine("Enter 5 integers: ");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            number3 = int.Parse(Console.ReadLine());
            number4 = int.Parse(Console.ReadLine());
            number5 = int.Parse(Console.ReadLine());
            int greatest = number1;
            if (greatest < number2)
            {
                greatest = number2;
            }
            if (greatest < number3)
            {
                greatest = number3;
            }
            if (greatest < number4)
            {
                greatest = number4;
            }
            if (greatest < number5)
            {
                greatest = number5;
            }
            Console.WriteLine($"Greatest: {greatest}");
        }
    }
}
