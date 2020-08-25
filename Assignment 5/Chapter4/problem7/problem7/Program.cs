using System;

namespace problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for(int i = 0; i < 5; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
