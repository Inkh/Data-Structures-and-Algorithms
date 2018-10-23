using System;
using System.Collections.Generic;
using System.Text;
using StackAndQueue.Classes;

namespace QueueWithStacks.Classes
{
    public class QueueWithTwoStacks
    {
        public Stack Front { get; set; }
        public Stack Rear { get; set; }
        public int Size { get; set; } = 0;

        public QueueWithTwoStacks()
        {
            Front = new Stack(null);
            Rear = new Stack(null);
        }

        /// <summary>
        /// Simulates enqueue by pushing node on top of stack.
        /// </summary>
        /// <param name="node">Input node</param>
        public void Enqueue(Node node)
        {
            Rear.Push(node);
            Size++;
        }

        /// <summary>
        /// Simulates dequeue by popping all items from rear to front, then Popping the node on front stack.
        /// Then, pop everything from front to rear for reset.
        /// </summary>
        /// <returns>Node that has been removed</returns>
        public Node Dequeue()
        {
            int counter = 0;

            while (counter < Size)
            {
                Front.Push(Rear.Pop());
                counter++;
            }

            Node returnNode = Front.Pop();
            Size--;
            counter = 0;

            while (counter < Size)
            {
                Rear.Push(Front.Pop());
                counter++;
            }

            return returnNode;
        }
    }
}
