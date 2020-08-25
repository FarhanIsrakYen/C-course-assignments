using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp = 0;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            Console.WriteLine($"1st number: {num1} 2nd number: {num2}");

        }
    }
}
