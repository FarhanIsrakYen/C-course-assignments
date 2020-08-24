using System;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Console.WriteLine("The third digit " + (num.Length >= 3 && num[num.Length - 3].Equals('7') ? "is": "isn't") + " 7.");
        }
    }
}
