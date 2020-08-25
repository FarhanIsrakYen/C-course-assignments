using System;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1;
            float number2;
            float number3;
            float temp;
            number1 = float.Parse(Console.ReadLine());
            number2 = float.Parse(Console.ReadLine());
            number3 = float.Parse(Console.ReadLine());
            if (number1 < number2 && number1 < number3)
            {
                temp = number1;
                number1 = number3;
                number3 = temp;
                if (number1 < number2)
                {
                    temp = number1;
                    number1 = number2;
                    number2 = temp;
                }
            }
            else if (number2 < number1 && number2 < number3)
            {
                temp = number2;
                number2 = number3;
                number3 = temp;
                if (number1 < number2)
                {
                    temp = number1;
                    number1 = number2;
                    number2 = temp;
                }
            }
            else
            {
                if (number1 < number2)
                {
                    temp = number1;
                    number1 = number2;
                    number2 = temp;
                }
            }
            Console.WriteLine($"{number1}, {number2}, {number3}");
        }
    
    }
}
