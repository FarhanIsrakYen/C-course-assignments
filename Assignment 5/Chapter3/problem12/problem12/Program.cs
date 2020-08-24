using System;

namespace problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            int v, position, mask;
            int i = 1;
            v = int.Parse(Console.ReadLine());
            position = int.Parse(Console.ReadLine());
            mask = i << position;
            if ((v & mask) == 0)
                Console.WriteLine("false");
            else
                Console.WriteLine("true");
        }
    }
}
