using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void MergeSort(int[] arr)
        {
            if (arr.Length > 1)
            {
                int leftSize = arr.Length / 2;
                int rightSize = arr.Length - leftSize;

                //first half in left array
                int[] left = new int[leftSize];
                Array.Copy(arr, 0, left, 0, arr.Length / 2);

                //second half in right array
                int[] right = new int[rightSize];
                Array.Copy(arr, arr.Length / 2, right, 0, arr.Length - left.Length);
            }
        }
    }
}
