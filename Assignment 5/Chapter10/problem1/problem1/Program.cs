using System;
using System.IO;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = Directory.GetFiles("C:\\data\\", "*.*", SearchOption.AllDirectories);
            foreach (string folders in list)
            {
                Console.WriteLine(folders);
            }
        }
    }
}
