using System;

namespace problemn14
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for(int i = 0; i <= 50000000; i++)
            {
                sum += 0.000001;
            }
            Console.WriteLine((float)sum);
            Console.WriteLine((decimal)sum);
            Console.WriteLine((int)sum);
        }
    }
}
