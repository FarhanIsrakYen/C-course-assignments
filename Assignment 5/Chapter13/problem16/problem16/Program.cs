using System;

namespace problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "<p>Please visit <a href=\"http://softuni.bg\">our site</a> to choose a software engineering training course. Also visit<a href=\"http://softuni.bg" + "/forum\">our forum</a> to discuss the courses.</ p >";
            str = str.Replace("<a href=\"", "[URL=");
            str = str.Replace("\">", "]");
            str = str.Replace("</a>", "[/URL]");
            Console.WriteLine(str);
        }
    }
}
