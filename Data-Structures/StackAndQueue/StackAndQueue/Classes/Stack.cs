using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// 'Peeks' at the current node in stack.
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            return Top;
        }

        /// <summary>
        /// Removes the first node on the stack.
        /// </summary>
        /// <returns>Removed node</returns>
        public Node Pop()
        {
            Node temp = Peek();
            Top = Top.Next;
            temp.Next = null;

            return temp;
        }

        /// <summary>
        /// Inserts input node onto the stack.
        /// </summary>
        /// <param name="node">Node to be added</param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }
    }
}
