using System;

namespace problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n, k;
            n = uint.Parse(Console.ReadLine());
            k = uint.Parse(Console.ReadLine());
            if (1 < k && k < n)
            {
                decimal result = 1;
                for (uint i = k + 1; i <= n; i++)
                {
                    result *= i;
                }
                Console.WriteLine($"Result: {result}");
            }
        }
    }
}
