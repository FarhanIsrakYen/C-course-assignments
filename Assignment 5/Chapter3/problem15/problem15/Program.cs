using System;

namespace problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number1 = uint.Parse(Console.ReadLine());
            uint number2;
            number2 = number1;
            uint bit3 = (number1 >> 3) & 1;
            uint bit24 = (number1 >> 24) & 1;
            number1 = (uint)(number1 & (~(1 << 24)) | (bit3 << 24));
            number1 = (uint)(number1 & (~(1 << 3)) | (bit24 << 3));
            uint bit4 = (number1 >> 4) & 1;
            uint bit25 = (number1 >> 25) & 1;
            number1 = (uint)(number1 & (~(1 << 25)) | (bit4 << 25));
            number1 = (uint)(number1 & (~(1 << 4)) | (bit25 << 4));
            uint bit5 = (number1 >> 5) & 1;
            uint bit26 = (number1 >> 26) & 1;
            number1 = (uint)(number1 & (~(1 << 26)) | (bit5 << 26));
            number1 = (uint)(number1 & (~(1 << 5)) | (bit26 << 5));
            Console.WriteLine($"New number : {number1}" );
    }
    }
}
