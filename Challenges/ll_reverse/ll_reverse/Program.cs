using System;
using LinkedList.Classes;

namespace ll_reverse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating new LL...");
            LList myList = new LList(new Node(10));
            myList.Append(new Node(20));
            myList.Append(new Node(30));
            myList.Append(new Node(40));
            myList.Append(new Node(50));

            myList.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Reversing list...");
            ReverseLL(myList);

            myList.Print();
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Reverses a Linked List
        /// </summary>
        /// <param name="input">LinkedList input</param>
        public static void ReverseLL(LList input)
        {
            Node curr = input.Head;
            Node prev = null;
            
            while (curr != null)
            {
                Node next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            input.Head = prev;
        }
    }
}
