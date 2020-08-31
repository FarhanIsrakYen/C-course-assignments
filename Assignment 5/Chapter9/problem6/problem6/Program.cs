using System;

namespace problem6
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
            Console.WriteLine($"{CheckGreater(numbers)} is greater");
        }
        static int CheckGreater(int[] numbers)
        {
            int num = -1;
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i - 1] < numbers[i] && numbers[i + 1] < numbers[i])
                {
                    num = numbers[i];
                    break;
                }
            }
            return num;
        }
    }
}
