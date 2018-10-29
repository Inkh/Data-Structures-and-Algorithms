using System;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree");
            BinaryTree myTree = new BinaryTree(new Node("A"));

            myTree.Root.Left = new Node("B");
            myTree.Root.Left.Left = new Node("D");
            myTree.Root.Left.Right = new Node("E");

            myTree.Root.Right = new Node("C");
            myTree.Root.Right.Left = new Node("F");

            Console.WriteLine("Pre Order");
            myTree.PreOrder();

            Console.WriteLine("In Order");
            myTree.InOrder();

            Console.WriteLine("Post Order");
            myTree.PostOrder();

            Console.WriteLine("Size");
            Console.WriteLine(myTree.Size(myTree.Root));

            Console.WriteLine("============================");
            Console.WriteLine("============================");

            BinarySearchTree myBST = new BinarySearchTree(new Node(10));
            myBST.Add(new Node(1));
            myBST.Add(new Node(11));
            myBST.Add(new Node(21));
            myBST.Add(new Node(18));
            Console.WriteLine(myBST.Root.Right.Value);
            Console.WriteLine(myBST.Root.Right.Right.Value);

            Console.WriteLine(myBST.Search(new Node(18)).Value);
            Console.WriteLine(myBST.Search(new Node(98)));
        }
    }
}
