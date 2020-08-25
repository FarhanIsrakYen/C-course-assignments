using System;

namespace problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
                Console.WriteLine(num2);
        }
    }
}
