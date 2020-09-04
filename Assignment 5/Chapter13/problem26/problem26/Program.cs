using System;

namespace problem26
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileData = Console.ReadLine();
            string[] trimChars = new string[] { " ", "<", ">", "head", "html", "title", "body", };
            string reduced = fileData.Trim(trimChars);
        }
    }
}
