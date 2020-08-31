using System;

namespace problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.Write(ReverseNum(num));
            
        }
        static int ReverseNum(int number)
        {
            int reverse = 0, rem;
            while (number != 0)
            {
                rem = number % 10;
                reverse = reverse * 10 + rem;
                number /= 10;
            }
            return reverse;
        }
    }
}
