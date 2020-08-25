using System;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 6;
            int num3 = 4;
            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num3);
                }
            }
            else if(num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);
            }
        }
    }
}
