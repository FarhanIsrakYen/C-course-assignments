using System;

namespace problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            string dictionary = ".NET - platform for applications from Microsoft\nCLR - managed execution environment for .NET\nnamespace - hierarchical organization of classes\n";
            string[] str = new string[10];
            str = dictionary.Split(new string[] { "\n" }, StringSplitOptions.None);
            Console.Write("Enter word: ");
            string input = Console.ReadLine() + " - ";
            foreach (string elements in str)
            {
                if (elements.Contains(input)) Console.WriteLine(elements.Substring(input.Length));
            }
            Console.ReadLine();
        }
    }
}
