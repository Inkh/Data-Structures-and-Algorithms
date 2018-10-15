using System;

namespace Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: 7");
            Console.WriteLine("Expected: 13");
            Console.WriteLine("Actual Output: ");
            Console.WriteLine(FibonacciSequence(7));
        }

        /// <summary>
        /// Takes in a number and returns the nth value of a Fibonacci sequence.
        /// </summary>
        /// <param name="idx">Sequence index</param>
        /// <returns>Value in sequence</returns>
        public static int FibonacciSequence(int idx)
        {
            if (idx <= 2 && idx >= 0)
            {
                return idx;
            }
            int currNum = 1;
            int prevNum = 1;
            int temp = 0;
            for( int i = 2; i < idx; i++)
            {
                temp = currNum + prevNum;
                prevNum = currNum;
                currNum = temp;
            }
            return currNum;
        }
    }
}
