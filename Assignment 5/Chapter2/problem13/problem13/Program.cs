using System;

namespace problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"x:{x}y:{y}");


        }
    }
}
