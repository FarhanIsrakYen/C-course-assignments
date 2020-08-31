using System;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            EngName(number);
        }
        static void EngName(string num)
        {
            int length = num.Length;
            char[] check = num.ToCharArray();
            char lastNum = check[length - 1];
            switch(lastNum)
            {
                case '1':
                    Console.WriteLine("one");
                    break;
                case '2':
                    Console.WriteLine("two");
                    break;
                case '3':
                    Console.WriteLine("three");
                    break;
                case '4':
                    Console.WriteLine("four");
                    break;
                case '5':
                    Console.WriteLine("five");
                    break;
                case '6':
                    Console.WriteLine("six");
                    break;
                case '7':
                    Console.WriteLine("seven");
                    break;
                case '8':
                    Console.WriteLine("eight");
                    break;
                case '9':
                    Console.WriteLine("nine");
                    break;
                case '0':
                    Console.WriteLine("zero");
                    break;

            }

            
        }
    }
}
