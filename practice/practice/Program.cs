using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = 7;
            int counter = 1;
            counter = num/2;

            for (int i = 1; i <= num; i++)
            {
                if(2*i-1 <= num)
                {
                    for (int j = 1; j <= counter; j++)
                        Console.Write(" ");

                    counter--;

                    for (int j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");

                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }

            counter = 1;

            
            for (int i = 1; i <= num - 1; i++)
            {
                if (2 * (num - i) - 1 < num)
                {
                    for (int j = 1; j <= counter; j++)
                        Console.Write(" ");

                    counter++;
                    for (int j = 1; j <= 2 * (num - i) - 1; j++)
                        Console.Write("*");

                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            counter = num / 2;
            for (int i = 1; i <= num; i++)
            {
                if (2 * i - 1 <= num)
                {
                    for (int j = 1; j <= counter; j++)
                        Console.Write(" ");

                    counter--;

                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        if(j == 1)
                        {
                            Console.Write("*");
                        }else if( j == 2 * i - 1)
                        {
                            Console.Write("*");
                        }else
                        {
                            Console.Write(" ");
                        }

                    }

                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }

            counter = 1;


            for (int i = 1; i <= num - 1; i++)
            {
                if (2 * (num - i) - 1 < num)
                {
                    for (int j = 1; j <= counter; j++)
                        Console.Write(" ");

                    counter++;
                    for (int j = 1; j <= 2 * (num - i) - 1; j++)
                        if (j == 1)
                        {
                            Console.Write("*");
                        }
                        else if (j == 2 * (num - i) - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    Console.WriteLine();
                }
            }

        }
    }
}
