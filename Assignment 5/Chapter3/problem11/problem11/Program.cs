using System;

namespace problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, position, mask;
            int i = 1;
            number = int.Parse(Console.ReadLine());
            position = int.Parse(Console.ReadLine());
            mask = i << position;
            if ((number & mask) == 0)
                Console.WriteLine("0");
            else
                Console.WriteLine("1");
        }
    }
}
