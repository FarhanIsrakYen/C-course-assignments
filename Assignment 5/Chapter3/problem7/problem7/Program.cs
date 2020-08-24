using System;

namespace problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            Console.Write("Enter your weight: ");
            weight = double.Parse(Console.ReadLine());
            double weight1 = weight * 0.17;
            Console.WriteLine($"Weight on the moon: { weight1 }" );
        }
    }
}
