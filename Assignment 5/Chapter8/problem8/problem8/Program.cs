using System;

namespace problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] hexVal = s.ToCharArray();
                HexToBin(hexVal);
        }
        static void HexToBin(char[] hexVal)
        {
            int i = 0;

            while (hexVal[i] != '\u0000')
            {

                switch (hexVal[i])
                {
                    case '0':
                        System.Console.Write("0000");
                        break;
                    case '1':
                        System.Console.Write("0001");
                        break;
                    case '2':
                        System.Console.Write("0010");
                        break;
                    case '3':
                        System.Console.Write("0011");
                        break;
                    case '4':
                        System.Console.Write("0100");
                        break;
                    case '5':
                        System.Console.Write("0101");
                        break;
                    case '6':
                        System.Console.Write("0110");
                        break;
                    case '7':
                        System.Console.Write("0111");
                        break;
                    case '8':
                        System.Console.Write("1000");
                        break;
                    case '9':
                        System.Console.Write("1001");
                        break;
                    case 'A':
                    case 'a':
                        System.Console.Write("1010");
                        break;
                    case 'B':
                    case 'b':
                        System.Console.Write("1011");
                        break;
                    case 'C':
                    case 'c':
                        System.Console.Write("1100");
                        break;
                    case 'D':
                    case 'd':
                        System.Console.Write("1101");
                        break;
                    case 'E':
                    case 'e':
                        System.Console.Write("1110");
                        break;
                    case 'F':
                    case 'f':
                        System.Console.Write("1111");
                        break;
                    default:
                        System.Console.Write("Invalid hexadecimal digit ");
                        break;
                }
                i++;
            }
        }
    }
}
