using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int last = 0;
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = i * 5;
            }
            foreach(int elements in arr)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
