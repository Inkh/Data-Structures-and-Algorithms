using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] myArr = { 10, 3, -5, 1, 2, 8, 4 };
            InsertionSortMethod(myArr);

            foreach (var item in myArr)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Method that sorts an array of integers.
        /// </summary>
        /// <param name="arr">Array of integers.</param>
        public static void InsertionSortMethod(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = temp;
            }
            
        }
    }
}
