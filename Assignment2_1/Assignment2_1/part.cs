using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_1
{
    class part
    {
        public part() { }
        public void binToDec(string s)
        {

            char[] arr;
            int sum = 0;

            arr = s.ToCharArray();
            Array.Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '1')
                {

                    if (i == 0)
                    {
                        sum += 1;
                    }
                    else
                    {
                        sum += (int)Math.Pow(2, i);
                    }
                }
                else
                {
                    continue;
                }

            }

            Console.WriteLine($"Decimal of {s} is {sum}");
        }

        public void decToBin(string s)
        {
            int  i;       
            int[] arr = new int[10];     
          
            int number= int.Parse(s);     

            for( i = 0; number > 0; i++)      
            {      
                arr[i] = number % 2;      
                number = number / 2;    
            }

            Console.Write($"Binary of {s} is ");

            for(i = i - 1 ; i >= 0 ; i--)      
            {      
                Console.Write(arr[i]);      
            } 
        }
        public void fibonacci()
        {
            int x = 0;
            int y = 1;
            int temp, i;
            Console.WriteLine();
            Console.Write($"First 50 fibonacci numbers are: {x} , {y} , ");
            
            for (i = 2; i < 50; ++i)
            {
                temp = x + y;
                Console.Write($"{temp} ,");
                x = y;
                y = temp;
            }
        }

        public void alphabetSum(string s)
        {
            
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] arr = new char[10];

            string a = s.ToUpper();
            arr = a.ToCharArray();

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                char c = arr[i];
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (c == alphabet[j])
                    {
                        sum = sum + j + 1;
                    }
                }
            }
            Console.WriteLine();
            Console.Write($"Sum of {s} is: {sum}");



        }
    }

}
