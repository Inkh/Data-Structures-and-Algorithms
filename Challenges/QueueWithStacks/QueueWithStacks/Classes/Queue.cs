using System;
using System.Collections.Generic;
using System.Text;
using StackAndQueue.Classes;

namespace QueueWithStacks.Classes
{
    public class Queue
    {
        public Stack Front { get; set; }
        public Stack Rear { get; set; }

        public Queue(Stack front, Stack rear)
        {
            Front = front;
            Rear = rear;
        }

        public void Enqueue(Node node)
        {
            Rear.Push(node);
        }

        public Node Dequeue()
        {
            int counter = 0;

            while (counter < Rear.Size)
            {
                Front.Push(Rear.Pop());
                counter++;
            }
            Node returnNode = Front.Pop();
            counter = 0;

            while (counter < Front.Size)
            {
                Rear.Push(Front.Pop());
                counter++;
            }

            return returnNode;
        }
    }
}
