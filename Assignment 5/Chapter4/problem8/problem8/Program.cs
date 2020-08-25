using System;

namespace problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            int greatest=int.MinValue;
            int[] num = new int[5]; 
            for(int i=0; i<5; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i<5; i++)
            {
                if (num[i] >greatest)
                    greatest = num[i];
            }
            Console.WriteLine(greatest);
            
        }
    }
}
