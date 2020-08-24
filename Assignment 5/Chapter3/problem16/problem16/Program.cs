using System;

namespace problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number1 = uint.Parse(Console.ReadLine());
            uint number2, bitI, bitIPlus15;
            number2 = number1;
            for (int i = 1; i <= 16; i++)
            {
                bitI = (number2 >> i) & 1;
                bitIPlus15 = (number2 >> (i + 16)) & 1;
                number2 = (uint)(number2 & (~(1 << (i + 16))) | (bitI << (i + 16)));
                number2 = (uint)(number2 & (~(1 << i)) | (bitIPlus15 << i));
            }

            Console.WriteLine($"New number {number2}");
        }
    }
    
}
