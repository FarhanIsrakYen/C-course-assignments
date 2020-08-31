using System;

namespace problem12
{
    class Program
    {
            static void Main(String[] args)
            {
                int[] A = { -3, 1, 3 };
                int[] B = { -1, 1 };
                int m = A.Length;
                int n = B.Length;
                Console.WriteLine("First polynomial is n");
                PrintPoly(A, m);
                Console.WriteLine("nSecond polynomial is n");
                PrintPoly(B, n);
                int[] prod = Multiply(A, B, m, n);
                Console.WriteLine("nProduct polynomial is n");
                PrintPoly(prod, m + n - 1);
            }
            static int[] Multiply(int[] A, int[] B, int m, int n)
            {
                int[] prod = new int[m + n - 1];
                for (int i = 0; i < m + n - 1; i++)
                {
                    prod[i] = 0;
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        prod[i + j] += A[i] * B[j];
                    }
                }
                return prod;
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
