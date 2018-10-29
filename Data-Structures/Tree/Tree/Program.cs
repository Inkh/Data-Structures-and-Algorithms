using System;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree myTree = new BinaryTree(new Node("A"));

            myTree.Root.Left = new Node("B");
            myTree.Root.Left.Left = new Node("D");
            myTree.Root.Left.Right = new Node("E");

            myTree.Root.Right = new Node("C");
            myTree.Root.Right.Left = new Node("F");

            Console.WriteLine("Pre Order");
            myTree.PreOrder();

            Console.WriteLine("In Order");
            myTree.InOrder(myTree.Root);

            Console.WriteLine("Post Order");
            myTree.PostOrder(myTree.Root);

            Console.WriteLine("Size");
            Console.WriteLine(myTree.Size(myTree.Root));
            myTree.Size(myTree.Root);
        }
    }
}
