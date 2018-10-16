using System;
using System.Collections.Generic;
using System.Text;
using LinkedList.Classes;

namespace LinkedList.Classes
{
    public class LList
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

        /// <summary>
        /// Traverses the list and prints out individual nodes
        /// </summary>
        public bool Print()
        {
            bool hasHead = true;

            Current = Head;
            if (Current == null)
            {
                hasHead = false;
            }
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} ---> ");
                Current = Current.Next;
            }
            Console.Write($"{Current.Value} ---> NULL");

            return hasHead;
        }

        /// <summary>
        /// Appends to the tail of List
        /// </summary>
        /// <param name="node"></param>
        public void Append(Node node)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = node;
        }

        /// <summary>
        /// Adds node before target node.
        /// </summary>
        /// <param name="targetNode"></param>
        /// <param name="inputNode"></param>
        public void AddBefore(Node targetNode, Node inputNode)
        {
            Current = Head;
            if (Head.Value.ToString() == targetNode.Value.ToString())
            {
                AddToStart(inputNode);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Value.ToString() == targetNode.Value.ToString())
                {
                    inputNode.Next = targetNode;
                    Current.Next = inputNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Check if list includes specific node 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool Includes(Node node)
        {
            Current = Head;
            
            while (Current.Next != null)
            {
                if (Current.Value.ToString() == node.Value.ToString())
                {
                    return true;
                }
                Current = Current.Next;
            }

            if (Current.Value.ToString() == node.Value.ToString())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Adds node after target node
        /// </summary>
        /// <param name="targetNode">Target node</param>
        /// <param name="inputNode">Input node</param>
        public void AddAfter(Node targetNode, Node inputNode)
        {
            Current = Head;
            
            while (Current.Next != null)
            {
                if (Current.Value.ToString() == targetNode.Value.ToString())
                {
                    inputNode.Next = Current.Next;
                    Current.Next = inputNode;
                    return;
                }
                Current = Current.Next;
            }

            if (Current.Value.ToString() == targetNode.Value.ToString())
            {
                Current.Next = inputNode;
                return;
            }
        }
    }
}
