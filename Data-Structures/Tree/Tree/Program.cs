using System;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree myTree = new BinaryTree(new Node(5));
            myTree.Root.Left = new Node(6);
            myTree.Root.Left.Left = new Node(1);
            myTree.Root.Right = new Node(7);

            myTree.PreOrder(myTree.Root);
        }
    }
}
