using System;
using StackAndQueue.Classes;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack flow");
            Stack myStack = new Stack(new Node(10));
            myStack.Push(new Node(20));
            myStack.Push(new Node(30));

            while (myStack.Top != null)
            {
                Console.Write(myStack.Peek().Value + "-->");
                myStack.Top = myStack.Top.Next;
            }
            Console.WriteLine("NULL");

            Console.WriteLine("Queue Flow");
            Queue myQueue = new Queue(new Node(10));
            myQueue.Enqueue(new Node(20));
            myQueue.Enqueue(new Node(30));

            while (myQueue.Front != null)
            {
                Console.Write(myQueue.Peek().Value + "-->");
                myQueue.Front = myQueue.Front.Next;
            }
            Console.WriteLine("NULL");
        }
    }
}
