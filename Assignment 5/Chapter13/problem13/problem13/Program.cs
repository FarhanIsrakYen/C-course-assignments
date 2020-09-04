using System;

namespace problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine("[protocol] = \"{0}\"", str.Substring(0, str.IndexOf("://")));
            Console.WriteLine("[server] = \"{0}\"", str.Substring(str.IndexOf("://") + 3).Split('/'));
            Console.WriteLine("[resource] = \"{0}\"", str.Substring(str.IndexOf("://") + 3).Substring(str.Substring(str.IndexOf("://") + 3).IndexOf('/')));
        }
    }
}
