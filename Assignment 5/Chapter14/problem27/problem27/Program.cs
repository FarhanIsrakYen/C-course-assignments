using System;

namespace problem27
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper help = new Helper();
            int divisor, numerator, denominator, reducedNumerator, reducedDenominator;
            Console.WriteLine("Specify the numerator of the fraction.");
            Console.Write("Numerator= ");
            numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Specify the denominator of the fraction.");
            Console.Write("Denominator= ");
            denominator = int.Parse(Console.ReadLine());
            Console.WriteLine();
            divisor = help.Gcd(numerator, denominator);
            if (divisor != 1)
            {
                reducedNumerator = help.Division(numerator, divisor);
                reducedDenominator = help.Division(denominator, divisor);
                Console.WriteLine($"The numerator of the reduced fraction is {reducedNumerator} ");
                Console.WriteLine($"The denominator of the reduced fraction is {reducedDenominator} ");
                Console.WriteLine();
                Console.WriteLine($"The fraction {numerator}/{denominator} can be reduced to {reducedNumerator}/{reducedDenominator}");
            }
            else
                Console.WriteLine("The fraction can not be reduced");
        }
    }
}
