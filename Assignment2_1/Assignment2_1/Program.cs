using System;

namespace Assignment2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter a binary value: ");
            String a = Console.ReadLine();
            Console.WriteLine($"Enter a decimal value: ");
            String b = Console.ReadLine();
            Console.WriteLine($"Enter a random word: ");
            String c = Console.ReadLine();
            part p = new part();

            p.binToDec(a);
            p.decToBin(b);
            p.fibonacci();
            p.alphabetSum(c);
        }
    }
        
    }


