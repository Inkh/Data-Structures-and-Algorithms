using System;
using System.Collections;
using System.Collections.Generic;
using Tree.Classes;

namespace BreadthFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sample Binary tree created.");
            Console.WriteLine("\n");
            BinaryTree myTree = new BinaryTree(new Node(1));
            myTree.Root.Left = new Node(2);
            myTree.Root.Left.Left = new Node(4);
            myTree.Root.Left.Right = new Node(5);

            myTree.Root.Right = new Node(3);
            myTree.Root.Right.Right = new Node(7);
            myTree.Root.Right.Left = new Node(6);

            Console.WriteLine("Breadth First Traversal Order:");
            Console.WriteLine("\n");
            BreadthFirstTraversal(myTree);
            Console.WriteLine(BreadthFirstTraversal(myTree));
        }

        /// <summary>
        /// Breadth First Traversal of a tree.
        /// </summary>
        /// <param name="tree">Tree</param>
        public static List<int> BreadthFirstTraversal(BinaryTree tree)
        {
            List<int> retList = new List<int>();
            Queue<Node> myQ = new Queue<Node>();
            myQ.Enqueue(tree.Root);
            while (myQ.Count != 0)
            {
                Node temp = myQ.Dequeue();
                if (temp.Left != null)
                {
                    myQ.Enqueue(temp.Left);
                }
                if (temp.Right != null)
                {
                    myQ.Enqueue(temp.Right);
                }

                retList.Add((int)temp.Value);
                Console.WriteLine(temp.Value);
            }
            return retList;
        }
    }
}
