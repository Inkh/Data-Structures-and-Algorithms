using System;
using Tree.Classes;

namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree myTree = new BinaryTree(new Node(1));
            myTree.Root.Left = new Node(3);
            myTree.Root.Left.Left = new Node(10000);

            myTree.Root.Right = new Node(222);
            myTree.Root.Right.Left = new Node(32);

            Console.WriteLine(FindMaxValue(myTree));
        }

        static int FindMaxValue(BinaryTree tree)
        {
            int max = (int)tree.Root.Value;
            return FindMaxValue(tree.Root, max);
        }

        static int FindMaxValue(Node node, int max)
        {
            if ((int)node.Value > max)
            {
                max = (int)node.Value;
            }

            if (node.Left != null)
            {
                max = FindMaxValue(node.Left, max);
            }

            if (node.Right != null)
            {
                max = FindMaxValue(node.Right, max);
            }

            return max;
        }
    }
}
