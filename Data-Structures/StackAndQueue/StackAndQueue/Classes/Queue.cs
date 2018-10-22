using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Returns the front node of the queue
        /// </summary>
        /// <returns>Front node</returns>
        public Node Peek()
        {
            return Front;
        }

        /// <summary>
        /// Adds a node to the rear end of queue
        /// </summary>
        /// <param name="node">Node to be added</param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Removes a node from the front of queue
        /// </summary>
        /// <returns>Removed node</returns>
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
    }
}
