using System;

namespace problem7
{
    class Program
    {
        static void Main()
        {
            int n, i;
            int[] arr1 = new int[5];
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                arr1[i] = i+1;
            }
            Permute(arr1, 0, n - 1);
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Permute(int[] list, int k, int m)
        {
            int i;
            if (k == m)
            {
                Console.Write("( ");
                for (i = 0; i <= m; i++)
                    Console.Write($"{list[i]} ,");
                Console.Write(" ), ");
            }
            else
                for (i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    Permute(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }
    }
}

