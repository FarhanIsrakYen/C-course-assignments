using System;
using System.Globalization;

namespace problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first date: ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter second date: ");
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture); ;

            Console.WriteLine($"Distance: {endDate.Subtract(startDate).TotalDays}");
        }
    }
}
