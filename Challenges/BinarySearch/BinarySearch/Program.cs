using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Sample input. Expected output to be : 6
            int num = 150;
            int[] sortedArr = { 1, 3, 5, 6, 8, 10, 150, 320 };
            Console.WriteLine(BinarySearchArray(sortedArr, num));

            //Sample Input 2. Expected output to be : -1
            int[] emptyArr = { };
            Console.WriteLine(BinarySearchArray(emptyArr, num));
        }

        /// <summary>
        /// Standard binary search on a sorted array.
        /// </summary>
        /// <param name="arr">Input array</param>
        /// <param name="val">Value to search for</param>
        /// <returns>Index of found value OR -1 if not found</returns>
        public static int BinarySearchArray(int[] arr, int val)
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
