using System;

namespace problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            int divCounter = 0;
            int number=int.Parse(Console.ReadLine());
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    divCounter += 1;
                else
                    divCounter += 0;
            }
            if (divCounter > 0)
                Console.WriteLine($"false");
            else
                Console.WriteLine($"true");
        }
    }
}
