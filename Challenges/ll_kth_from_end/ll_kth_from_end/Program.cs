using System;
using LinkedList.Classes;

namespace ll_kth_from_end
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList myList = new LList(new Node(10));
            myList.Append(new Node(20));
            myList.Append(new Node(30));
            myList.Append(new Node(40));
            myList.Append(new Node(50));

            myList.Print();

            //Expects 40
            Console.WriteLine("Expects 40");
            Console.WriteLine(ReturnKthFromEnd(myList, 1));

            //Expects 10
            Console.WriteLine("Expects 10");
            Console.WriteLine(ReturnKthFromEnd(myList, 4));

        }

        /// <summary>
        /// Returns Kth element from the end starting with index 0
        /// </summary>
        /// <param name="list">Singly Linked List</param>
        /// <param name="k">Index from end</param>
        /// <returns></returns>
        public static int ReturnKthFromEnd(LList list, int k)
        {
            if (list.Head == null)
            {
                throw new NullReferenceException("List must not be null");
            }
            int counter = 0;
            Node curr = list.Head;

            while (curr.Next != null)
            {
                counter++;
                curr = curr.Next;
            }

            if (counter - k < 0)
            {
                throw new IndexOutOfRangeException("Index out of range. Please input another number");
            }

            curr = list.Head;

            while (counter - k > 0)
            {
                curr = curr.Next;
                counter--;
            }

            return (int) curr.Value;
        }
    }
}
