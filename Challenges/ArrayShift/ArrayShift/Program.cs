using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3;
            int[] testArr = { 1, 2, 4, 5 };
            ArrayShift(testArr, number);
        }

        static int[] ArrayShift(int[] arr, int val)
        {
            int[] newArr = new int[arr.Length + 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < Math.Ceiling((double)arr.Length / 2))
                {
                    newArr[i] = arr[i];
                }
                else if (i == Math.Ceiling((double)arr.Length /2 ))
                {
                    newArr[i] = val;
                }
                else
                {
                    newArr[i] = arr[i - 1];
                }
            }
            Console.WriteLine(string.Join(",", newArr));
            return newArr;
        }
    }
}
