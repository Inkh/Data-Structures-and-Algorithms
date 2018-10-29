using System;
using StackAndQueue.Classes;

namespace EeneyMeeneyMineyMoe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input list: [a, b, c, d, e]");
            Console.WriteLine("Input number: 3");
            Console.WriteLine("Expected output: d");
            string[] myList = { "a", "b", "c", "d", "e" };
            string result = EeneyMeeneyMineyMoeMethod(myList, 3);

            Console.Write("Actual output: ");
            Console.WriteLine(result);
        }
        /// <summary>
        /// Goes through the array and continuously removes elements in a circular fashion
        /// until only one element is left.
        /// </summary>
        /// <param name="input">Array of strings</param>
        /// <param name="n">The nth element to be removed. The first element is 1</param>
        /// <returns>Single string</returns>
        public static string EeneyMeeneyMineyMoeMethod(string[] input, int n)
        {
            Queue myQ = new Queue(new Node(input[0]));
            for (int i = 1; i < input.Length; i++)
            {
                myQ.Enqueue(new Node(input[i]));
            }
            while (myQ.Front != myQ.Rear)
            {
                int counter = 1;
                while (counter < n)
                {
                    myQ.Enqueue(myQ.Dequeue());
                    counter++;
                }
                myQ.Dequeue();
            }
            return (string)myQ.Front.Value;
        }
    }

}
