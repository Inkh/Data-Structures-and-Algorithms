using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Sorting algorithm that breaks array down into halves and eventually merges everything back together.
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
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

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, arr);
            }
        }

        /// <summary>
        /// Helper method that takes in three arrays. The left partition, right partition, and the base array.
        /// </summary>
        /// <param name="left">Left half</param>
        /// <param name="right">Right half</param>
        /// <param name="arr">Original</param>
        /// <returns>Altered base array</returns>
        static int[] Merge(int[] left, int[] right, int[] arr)
        {
            //left pointer
            int i = 0;
            //right pointer
            int j = 0;
            //end array pointer
            int k = 0;

            //makes sure that indexes are valid
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    //puts smaller value into main arr. in this case, left arr
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    //puts smaller value into main arr. in this case, right arr
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            if (i == left.Length)
            {
                //copy right arr into main arr
                Array.Copy(right, j, arr, k, right.Length - j);
            }
            else
            {
                //copy left arr into main arr
                Array.Copy(left, i, arr, k, left.Length - i);
            }

            return arr;
        }
    }
}
