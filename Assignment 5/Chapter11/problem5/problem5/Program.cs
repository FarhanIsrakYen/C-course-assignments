using System;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());
            double sum = Math.Pow(side1, 2) + Math.Pow(side2, 2);
            double hypotenuse = Math.Sqrt(sum);
            Console.WriteLine(hypotenuse);
        }
    }
}
