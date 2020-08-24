using System;

namespace problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            string withQuotes = @"The ""use"" of quotations causes difficulties.";
            string withoutQuotes = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(withoutQuotes);
            Console.WriteLine(withQuotes);
        }
    }
}
