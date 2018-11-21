using System;

namespace QuickSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);

                QuickSort(arr, left, position - 1);

                QuickSort(arr, position + 1, right); 
            }
        }

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

        static void Swap(int[] arr, int i , int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
