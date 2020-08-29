using System;

namespace problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexval = Console.ReadLine();
            int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(decValue);
        }
    }
}
