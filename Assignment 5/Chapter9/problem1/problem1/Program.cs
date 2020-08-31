using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Name(s);
        }

        static void Name(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
