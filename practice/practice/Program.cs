using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = 5;
            int counter = 1;
            counter = num - 1;

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= counter; j++)
                    Console.Write(" ");

                counter--;

                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }

            counter = 1;

            for (int i = 1; i <= num - 1; i++)
            {
                for (int j = 1; j <= counter; j++)
                    Console.Write(" ");

                counter++;
                for (int j = 1; j <= 2 * (num - i) - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }

        }
    }
}
