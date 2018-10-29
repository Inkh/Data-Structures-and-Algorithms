using System;
using System.Collections.Generic;
using StackAndQueue.Classes;

namespace EeneyMeeneyMineyMoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input list: [a, b, c, d, e]");
            Console.WriteLine("Input number: 3");
            Console.WriteLine("Expected output: d");
            string[] myList = { "a", "b", "c", "d", "e" };
            string result = EeneyMeeneyMineyMoe(myList, 3);

            Console.Write("Actual output: ");
            Console.WriteLine(result);
        }

        public static string EeneyMeeneyMineyMoe(string[] input, int n)
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
