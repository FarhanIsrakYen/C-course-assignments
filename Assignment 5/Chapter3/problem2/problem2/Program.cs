using System;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 5 == 0 && num % 7 == 0)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
    }
}
