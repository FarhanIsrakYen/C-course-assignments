using System;

namespace problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C# is not C++ and PHP is not Delphi";
            str = Reverse(str);
            string[] arr = str.Split(' ');
            str = "";
            foreach (string s in arr) 
                str += Reverse(s) + ' ';
            Console.WriteLine(str);
        }
        public static string Reverse(string s)
        {
            char[] arr1 = s.ToCharArray();
            Array.Reverse(arr1);
            return new string(arr1);
        }
    }
}
