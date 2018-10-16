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

        public void Append(Node node)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = node;
        }

        public void AddBefore(Node targetNode, Node inputNode)
        {
            Current = Head;
            if (Head.Value == targetNode.Value)
            {
                AddToStart(inputNode);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Value == targetNode.Value)
                {
                    inputNode.Next = targetNode;
                    Current.Next = inputNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        public bool Includes(Node node)
        {
            Current = Head;
            
            while (Current.Next != null)
            {
                if (Current.Value == node.Value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
