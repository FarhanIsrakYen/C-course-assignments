using System;

namespace problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            uint previous = 0;
            uint current = 1;
            uint newElement = 0;
            Console.WriteLine(previous);
            Console.WriteLine(current);
            for (int i=3; i<=100; i++)
            {
                newElement = previous + current;
                Console.WriteLine(newElement);
                previous = current;
                current = newElement;
            }
        }
    }
}
