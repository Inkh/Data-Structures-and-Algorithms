using System;
using LinkedList.Classes;

namespace ll_kth_from_end
{
    class Program
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
            Console.WriteLine(ReturnKthFromEnd(myList, 1));

            //Expects 10
            Console.WriteLine(ReturnKthFromEnd(myList, 4));

            //Expects Exception
            Console.WriteLine(ReturnKthFromEnd(myList, 6));

            ReturnKthFromEnd(myList, 1);
        }

        static int ReturnKthFromEnd(LList list, int k)
        {
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
