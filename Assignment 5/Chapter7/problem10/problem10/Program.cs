using System;

namespace problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int n = arr.Length;
            Console.WriteLine(MostFrequent(arr));
        }

        static int MostFrequent(int[] arr)
        {
            Array.Sort(arr);
            int max_count = 1, res = arr[0];
            int curr_count = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                    curr_count++;
                else
                {
                    if (curr_count > max_count)
                    {
                        max_count = curr_count;
                        res = arr[i - 1];
                    }
                    curr_count = 1;
                }
            }
            if (curr_count > max_count)
            {
                max_count = curr_count;
                res = arr[arr.Length - 1];
            }
            return res;
        }
    }
}
