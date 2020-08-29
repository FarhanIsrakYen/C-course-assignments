using System;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 6 };
            int[] arr1 = { 1, 2, 4, 4, 6 };
            int sum = 0;
            if(arr.Length == arr1.Length)
            {
                for(int i=0;i<arr.Length;i++)
                {
                    for(int j=0; j< arr1.Length; j++)
                    {
                        if(arr[i]==arr1[j])
                        {
                            Console.WriteLine($"{arr[i]} , {arr1[j]}");
                            sum++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            if(sum == arr.Length)
            {
                Console.WriteLine(sum);
            }
        }
    }
}
