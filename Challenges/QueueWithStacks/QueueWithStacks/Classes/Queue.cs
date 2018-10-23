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
    }
}
