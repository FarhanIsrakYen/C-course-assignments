using System;

namespace problem11
{
    class Program
    {
        public static void Main()
        {
            int[] A = { -3, 1, 3 };
            int[] B = { -1, 2 };
            int m = A.Length;
            int n = B.Length;
            Console.WriteLine("First polynomial is");
            PrintPoly(A, m);
            Console.WriteLine("\nSecond polynomial is ");
            PrintPoly(B, n);
            int[] sum = Add(A, B, m, n);
            int size = Max(m, n);
            Console.WriteLine("\nsum polynomial is ");
            PrintPoly(sum, size);
        }
        static int Max(int m, int n)
        {
            return (m > n) ? m : n;
        } 
        static int[] Add(int[] A, int[] B, int m, int n)
        {
            int size = Max(m, n);
            int[] sum = new int[size];
            for (int i = 0; i < m; i++)
            {
                sum[i] = A[i];
            }
            for (int i = 0; i < n; i++)
            {
                sum[i] += B[i];
            }

            return sum;
        }
        static void PrintPoly(int[] poly, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(poly[i]);
                if (i != 0)
                {
                    Console.Write("x^" + i);
                }
                if (i != n - 1)
                {
                    Console.Write(" + ");
                }
            }
        }
    }
}
