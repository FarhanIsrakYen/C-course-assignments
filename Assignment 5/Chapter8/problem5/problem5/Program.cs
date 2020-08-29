using System;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, binVal, decVal = 0, baseVal = 1, rem;
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                rem = num % 10;
                decVal += rem * baseVal;
                num /= 10;
                baseVal *= 2;
            }
            Console.Write(decVal);
        }
    }
}
