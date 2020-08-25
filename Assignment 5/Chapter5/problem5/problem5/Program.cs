using System;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            char digit;
            string word;
            digit = char.Parse(Console.ReadLine());
            switch (digit)
            {
                case '0':
                    word = "zero";
                    break;
                case '1':
                    word = "one";
                    break;
                case '2':
                    word = "two";
                    break;
                case '3':
                    word = "three";
                    break;
                case '4':
                    word = "four";
                    break;
                case '5':
                    word = "five";
                    break;
                case '6':
                    word = "six";
                    break;
                case '7':
                    word = "seven";
                    break;
                case '8':
                    word = "eight";
                    break;
                case '9':
                    word = "nine";
                    break;
                default:
                    word = "error";
                    break;
            }
            Console.WriteLine(word);
        }
    }
}
