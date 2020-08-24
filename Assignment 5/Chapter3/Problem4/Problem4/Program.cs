using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool bit3 = (num & 4) != 0;
            Console.WriteLine("The third bit is " + (bit3 ? 1 : 0));
        }
    }
}
