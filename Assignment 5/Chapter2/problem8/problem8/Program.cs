using System;

namespace problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "World";
            object variable = s1 + " " + s2;
            string newString = (string)variable;
            Console.WriteLine(newString);
        }
    }
}
