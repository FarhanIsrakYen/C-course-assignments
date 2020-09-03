using System;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int startTime = Environment.TickCount;
            for (int i = 0; i < 10000000; i++)
            {
                sum++;
            }
            int endTime = Environment.TickCount;
            Console.WriteLine($"The time elapsed is {((endTime - startTime) / 1000.0)} sec.");
            Console.WriteLine($"The time elapsed is {((endTime - startTime) / 60000.0)} min.");
            Console.WriteLine($"The time elapsed is {((endTime - startTime) / 3600000000.0)} hours.");
            Console.WriteLine($"The time elapsed is {((endTime - startTime) / 86400000000.0)} days.");

        }
    }
}
