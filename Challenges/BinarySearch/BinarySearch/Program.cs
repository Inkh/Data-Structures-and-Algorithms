using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample input. Expected output to be : 6
            int num = 150;
            int[] sortedArr = { 1, 3, 5, 6, 8, 10, 150, 320 };
            Console.WriteLine(BinarySearch(sortedArr, num));

            //Sample Input 2. Expected output to be : -1
            int[] emptyArr = { };
            Console.WriteLine(BinarySearch(emptyArr, num));
        }

        static int BinarySearch(int[] arr, int val)
        {
            int start = 0;
            int end = arr.Length - 1;
            int mid;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (arr[mid] == val)
                {
                    return mid;
                }
                else if (arr[mid] < val)
                {
                    start = mid + 1;
                }
                else if (arr[mid] > val)
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}
