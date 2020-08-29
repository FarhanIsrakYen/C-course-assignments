using System;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity;
            quantity = int.Parse(Console.ReadLine());
            long prevMember = 0;
            long actualMember = 1;
            long auxMember = 0;
            decimal sum = 1M;
            if (quantity == 1)
            {
                sum = 0;
            }
            else if (quantity == 2)
            {
                sum = 1;
            }
            else
            {
                for (int i = 3; i <= quantity; i++)
                {
                    auxMember = actualMember;
                    actualMember += prevMember;
                    prevMember = auxMember;
                    sum += actualMember;
                }
            }
            if(quantity != 0)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
