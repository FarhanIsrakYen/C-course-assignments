using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool leapYear = DateTime.IsLeapYear(int.Parse(Console.ReadLine()));
            Console.WriteLine(leapYear);
        }
    }
}
