using System;
using System.Collections;
using System.Collections.Generic;
using Tree.Classes;

namespace BreadthFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree myTree = new BinaryTree(new Node(1));
            myTree.Root.Left = new Node(2);
            myTree.Root.Left.Left = new Node(4);
            myTree.Root.Left.Right = new Node(5);

            myTree.Root.Right = new Node(3);
            myTree.Root.Right.Right = new Node(7);
            myTree.Root.Right.Left = new Node(6);

            //myTree.PreOrder();
            BreadthFirstTraversal(myTree);
        }

        static void BreadthFirstTraversal(BinaryTree tree)
        {
            Queue<Node> myQ = new Queue<Node>();
            myQ.Enqueue(tree.Root);

            while (myQ.Peek() != null)
            {
                Node temp = myQ.Dequeue();
                if (temp.Left != null)
                {
                    myQ.Enqueue(temp.Left);
                }
                else if (temp.Right != null)
                {
                    myQ.Enqueue(temp.Right);
                }

                Console.WriteLine(temp.Value);
            }
        }
    }
}
