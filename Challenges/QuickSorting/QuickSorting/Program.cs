using System;

namespace QuickSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] myArr = { 10, 3, -5, 1, 2, 8, 4 };
            QuickSort(myArr,0,myArr.Length - 1);

            foreach (var item in myArr)
            {
                Console.WriteLine(item);
            }

        }

        /// <summary>
        /// Sorts an array of integers in the quicksort fashion.
        /// Calls itself recursively and uses partition helper functions to set pivot points, then calls the swap helper to perform the 'rotation'.
        /// </summary>
        /// <param name="arr">Arry</param>
        /// <param name="left">Left partition</param>
        /// <param name="right">Right partition</param>
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);

                QuickSort(arr, left, position - 1);

                QuickSort(arr, position + 1, right); 
            }
        }

        /// <summary>
        /// Sets pivot points
        /// </summary>
        /// <param name="arr">Array from quicksort</param>
        /// <param name="left">Lef</param>
        /// <param name="right">Right</param>
        /// <returns></returns>
        static int Partition(int[] arr, int left, int right)
        {
            // set pivot
            int pivot = arr[right];

            //get index of low value
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if(arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i , low);
                }
            }
            Swap(arr, right, low + 1);
            return low + 1;
        }

        /// <summary>
        /// 'Rotates' array elements around pivot point.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="i"></param>
        /// <param name="low"></param>
        static void Swap(int[] arr, int i , int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
