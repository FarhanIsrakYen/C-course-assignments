using System;

namespace problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
            Console.Write($"Maximum contiguous sum is {MaxSubArraySum(a)}");
        }
        static int MaxSubArraySum(int[] a)
        {
            int size = a.Length;
            int max_so_far = int.MinValue,
                sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum = sum + a[i];

                if (max_so_far < sum)
                    max_so_far = sum;

                if (sum < 0)
                    sum = 0;
            }

            return max_so_far;
        }
    }
}
