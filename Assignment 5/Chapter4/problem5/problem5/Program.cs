using System;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            for (int i=num1; i<=25; i++)
            {
                if(i%5==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
