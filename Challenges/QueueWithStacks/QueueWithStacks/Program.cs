using System;
using StackAndQueue.Classes;
using QueueWithStacks.Classes;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueueWithStacks();
        }

        /// <summary>
        /// Demo of Queue. Queue will print backwards by default.
        /// </summary>
        static void QueueWithStacks()
        {
            Console.WriteLine("Printing Queue with 2 stacks in reverse");
            QueueWithTwoStacks myQueue = new QueueWithTwoStacks();
            myQueue.Enqueue(new Node(10));
            myQueue.Enqueue(new Node(20));
            myQueue.Enqueue(new Node(30));
            myQueue.Enqueue(new Node(40));
            myQueue.Enqueue(new Node(50));

            Node curr = myQueue.Rear.Top;
            while (curr != null)
            {
                Console.Write(curr.Value + " --> ");
                curr = curr.Next;
            }
            Console.WriteLine("NULL");

            Console.WriteLine("Dequeue...");
            Console.WriteLine(myQueue.Size);
            myQueue.Dequeue();

            curr = myQueue.Rear.Top;
            while (curr != null)
            {
                Console.Write(curr.Value + " --> ");
                curr = curr.Next;
            }
            Console.WriteLine("null");

        }
    }
}
