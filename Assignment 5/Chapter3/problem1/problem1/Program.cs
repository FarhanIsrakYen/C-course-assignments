using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }
}
