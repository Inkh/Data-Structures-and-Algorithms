using System;
using LinkedList.Classes;

namespace ll_merge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First list : 1 --> 3 --> 5 --> NULL");
            LList first = new LList(new Node(1));
            first.Append(new Node(3));
            first.Append(new Node(5));

            Console.WriteLine("First list : 2 --> 4 --> 6 --> NULL");
            LList second = new LList(new Node(2));
            second.Append(new Node(4));
            second.Append(new Node(6));

            LList merged = MergeLists(first, second);

            Console.WriteLine("First method:");
            merged.Print();
            Console.WriteLine("=");

            LList mergeTwo = MergeTwo(first, second);

            Console.WriteLine("Second Method");
            mergeTwo.Print();
            Console.WriteLine("=");


            Console.WriteLine("Replacing one node");
            FindAndReplaceNode(first, new Node(3));
            Console.WriteLine("Updated list from method #2");
            mergeTwo.Print();
        }

        /// <summary>
        /// Takes two linked lists and zips them up with alternating nodes.
        /// Creates a new list with new nodes reflecting values.
        /// </summary>
        /// <param name="list1">First linked list</param>
        /// <param name="list2">Second linked list</param>
        /// <returns>Merged linked list</returns>
        public static LList MergeLists(LList list1, LList list2)
        {
            Node curr1 = list1.Head;
            Node curr2 = list2.Head;
            LList returnList = new LList(new Node(curr1.Value));

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

        /// <summary>
        /// Takes two linked lists and zips them up with alternating nodes.
        /// However, this method does not create an entire new list.
        /// </summary>
        /// <param name="list1">First linked list</param>
        /// <param name="list2">Second linked list</param>
        /// <returns>Merged linked list</returns>
        public static LList MergeTwo(LList list1, LList list2)
        {
            Node curr1 = list1.Head;
            Node curr2 = list2.Head;
            LList returnList = new LList(curr1);
            Node returnCurr = returnList.Head;
            curr1 = curr1.Next;

            while (curr1 != null || curr2 != null)
            {
                if (curr2 != null)
                {
                    returnCurr.Next = curr2;
                    curr2 = curr2.Next;
                    returnCurr = returnCurr.Next;
                }
                if (curr1 != null)
                {
                    returnCurr.Next = curr1;
                    curr1 = curr1.Next;
                    returnCurr = returnCurr.Next;
                }
            }
            return returnList;
        }

        /// <summary>
        /// Finds specific node that holds matching value and changes it to 100.
        /// This method is a helper for testing.
        /// </summary>
        /// <param name="list">Linked List</param>
        /// <param name="node">Node to match</param>
        public static void FindAndReplaceNode(LList list, Node node)
        {
            Node curr = list.Head;

            while (curr.Next != null)
            {
                if (curr.Value.ToString() == node.Value.ToString())
                {
                    curr.Value = 100;
                }
                curr = curr.Next;
            }
        }
    }

}
