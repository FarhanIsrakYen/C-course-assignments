using System;

namespace problem24
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().ToCharArray();
            Array.Sort(arr);
            Console.WriteLine(arr);
        }
    }
}
