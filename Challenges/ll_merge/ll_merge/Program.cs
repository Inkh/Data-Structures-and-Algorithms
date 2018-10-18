using System;
using LinkedList.Classes;

namespace ll_merge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LList first = new LList(new Node(1));
            first.Append(new Node(3));
            first.Append(new Node(5));

            LList second = new LList(new Node(2));
            second.Append(new Node(4));
            second.Append(new Node(6));

            LList merged = MergeLL(first, second);

            merged.Print();
        }

        static LList MergeLL(LList list1, LList list2)
        {
            Node curr1 = list1.Head;
            Node curr2 = list2.Head;
            LList returnList = new LList(curr1);

            curr1 = curr1.Next;

            Node returnCurr = returnList.Head;

            while (curr1 != null || curr2 != null)
            {
                if (curr2 != null)
                {
                    returnCurr.Next = new Node(curr2.Value);
                    curr2 = curr2.Next;
                    returnCurr = returnCurr.Next;
                }

                if (curr1 != null)
                {
                    returnCurr.Next = new Node(curr1.Value);
                    curr1 = curr1.Next;
                    returnCurr = returnCurr.Next;
                }
            }

            return returnList;
        }
    }
}
