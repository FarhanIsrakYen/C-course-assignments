using System;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(GetMax(a, b), c));
        }

        static int GetMax(int num1, int num2)
        {
            int max;
            if(num1 > num2)
            {
                max = num1;
            }
            else
            {
                max = num2;
            }
            return max;
        }
    }
}
