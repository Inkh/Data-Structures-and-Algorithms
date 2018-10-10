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
            //Loop through new array length (arr.Length + 1)
            for (int i = 0; i < newArr.Length; i++)
            {
                //Cast integer to double, then round it up.
                if (i < Math.Ceiling((double)arr.Length / 2))
                {
                    newArr[i] = arr[i];
                }
                //Once we're at middle point, set index value to input value
                else if (i == Math.Ceiling((double)arr.Length /2 ))
                {
                    newArr[i] = val;
                }
                //Past middle point. Our index is 1 ahead of original array index. Therefore we set new arr index value as i - 1.
                else
                {
                    newArr[i] = arr[i - 1];
                }
            }
            //Console log to make sure we get correct output.
            Console.WriteLine(string.Join(",", newArr));
            return newArr;
        }
    }
}
