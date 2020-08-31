using System;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many number you want to input?");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Insert Your Numbers");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Which posotion you want to check?");
            int numCheck = int.Parse(Console.ReadLine());
            Console.WriteLine($"{CheckGreater(numbers, numCheck)}");
        }
        static bool CheckGreater(int[] numbers, int position)
        {
                if (numbers[position - 1] < numbers[position] && numbers[position + 1] < numbers[position])
                {
                    return true;
                }
                else
                    return false;
        }
    }
}
