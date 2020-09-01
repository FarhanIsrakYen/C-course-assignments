using System;

namespace problem9
{
    class Program
    {
        static void Main()
        {
            uint[] A = { 1, 4, 45, 6, 10 };
            uint n = 16;
            uint arr_size = 6;
            if (Check(A, arr_size, n))
                Console.Write("Array has two elements with given sum");
            else
                Console.Write("Array doesn't have two elements with given sum");
        }
        static bool Check(uint[] A, uint arr_size, uint sum)
        {
            uint l, r;
            Sort(A, 0, arr_size - 1);
            l = 0;
            r = arr_size - 1;
            while (l < r)
            {
                if (A[l] + A[r] == sum)
                    return true;
                else if (A[l] + A[r] < sum)
                    l++;
                else
                    r--;
            }
            return false;
        }
        static uint Partition(uint[] arr, uint low, uint high)
        {
            uint pivot = arr[high];
            uint i = (low - 1);
            for (uint j = low; j <= high - 1; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    uint temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            uint temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }
        static void Sort(uint[] arr, uint low, uint high)
        {
            if (low < high)
            {
                uint pi = Partition(arr, low, high);
                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }
        }
    }
}
