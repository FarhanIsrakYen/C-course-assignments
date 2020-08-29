using System;

namespace problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            uint k = uint.Parse(Console.ReadLine());
            Console.WriteLine((factorial(n)*factorial(k))/factorial(n-k));
        }
        static uint factorial(uint n)
        {
            uint num = 1;
            for(uint i = 1; i <= n; i++)
            {
                num *= i;
            }
            return num;
        }
    }
}
