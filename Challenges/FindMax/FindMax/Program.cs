using System;
using Tree.Classes;

namespace FindMax
{
    public class Program
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

        /// <summary>
        /// FindMax method that takes in a tree. Calls overloaded method for actual logic.
        /// </summary>
        /// <param name="tree">Binary Tree</param>
        /// <returns>Max value</returns>
        public static int FindMaxValue(BinaryTree tree)
        {
            if (tree.Root == null)
            {
                return -1;
            }

            int max = (int)tree.Root.Value;
            return FindMaxValue(tree.Root, max);
        }

        /// <summary>
        /// Overloaded method that traverses through the tree recursively, then returns the max
        /// value of the tree.
        /// </summary>
        /// <param name="node">Root Node</param>
        /// <param name="max">Max value</param>
        /// <returns>Max value</returns>
        private static int FindMaxValue(Node node, int max)
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
