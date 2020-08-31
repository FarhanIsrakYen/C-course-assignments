using System;

namespace problem4
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
            Console.WriteLine("Which number do you want to find?");
            int numCheck = int.Parse(Console.ReadLine());
            Console.WriteLine($"Number {numCheck} occured {CountOccurences(numbers, numCheck)} times");
        }
        static int CountOccurences(int[] arr, int num)
        {
            int occured = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == num)
                {
                    occured++;
                }
            }
            return occured;
        }
    }
}
