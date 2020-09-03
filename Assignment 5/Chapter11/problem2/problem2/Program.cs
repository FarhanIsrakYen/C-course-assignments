using System;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int number = 1; number <= 10; number++)
            {
                int randomNumber = rand.Next(100, 200);
                Console.Write($"{randomNumber} ");
            }
        }
    }
}
