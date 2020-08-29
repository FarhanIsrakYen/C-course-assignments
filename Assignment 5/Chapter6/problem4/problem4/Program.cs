using System;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            uint quantity = uint.Parse(Console.ReadLine());
            int smallest = int.MaxValue;
            int largest = int.MinValue;
            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine($"Enter the number {i}: ");
                int number = int.Parse(Console.ReadLine());
                if (number < smallest)
                {
                    smallest = number;
                }
                if (number > largest)
                {
                    largest = number;
                }
            }
            Console.WriteLine($"Smallest: {smallest} Largest: {largest}");
        }
    }
}
