using System;
using LinkedList.Classes;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LList myList = new LList(new Node(10));
            myList.AddAfter(new Node(10), new Node(20));
            myList.AddAfter(new Node(20), new Node(30));
            myList.Print();
        }
    }
}
