using System;
using System.Collections.Generic;

namespace problem25
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var unique = new HashSet<char>(str);
            foreach (char c in unique)
                Console.Write(c);
        }
    }
}
