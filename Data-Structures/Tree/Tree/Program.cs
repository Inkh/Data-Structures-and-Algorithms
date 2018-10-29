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

            Console.WriteLine("Binary Search Tree");
            BinarySearchTree myBST = new BinarySearchTree(new Node(10));
            myBST.Add(new Node(1));
            myBST.Add(new Node(11));
            myBST.Add(new Node(21));
            myBST.Add(new Node(18));
            Console.WriteLine("Adding a bunch of nodes... Root.Right should equal 11");
            Console.WriteLine(myBST.Root.Right.Value);

            Console.WriteLine("Root.Left should equal 1");
            Console.WriteLine(myBST.Root.Left.Value);

            Console.WriteLine("Searching for Node with value 18. Should return the node");
            Console.WriteLine(myBST.Search(new Node(18)).Value);

            Console.WriteLine("Searching for Node with value 98. Should return nothing/null");
            Console.WriteLine(myBST.Search(new Node(98)));
        }
    }
}
