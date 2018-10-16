using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
        public Node Head { get; set; }

        public Node Current { get; set; }

        /// <summary>
        /// Constructor. Requires node.
        /// </summary>
        /// <param name="node"></param>
        public LList(Node node)
        {
            Head = node;
            Current = node;
        }

        /// <summary>
        /// Add to beginning of linked list.
        /// </summary>
        /// <param name="node"></param>
        public void AddToStart(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
        }

        public void Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} ---> ");
                Current = Current.Next;
            }
            Console.Write($"{Current.Value} ---> NULL");
        }
    }
}
