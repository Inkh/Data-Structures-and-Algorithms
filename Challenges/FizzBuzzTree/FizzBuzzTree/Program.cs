using System;
using Tree.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree myTree = new BinaryTree(new Node(5));

            myTree.Root.Left = new Node(4);
            myTree.Root.Left.Left = new Node(30);
            myTree.Root.Left.Right = new Node(1);
            myTree.Root.Right = new Node(3);
            myTree.Root.Right.Right = new Node(15);
            myTree.Root.Right.Left = new Node(10);

            FizzBuzz(myTree);
        }

        static void FizzBuzz(BinaryTree tree)
        {
            FizzBuzz(tree.Root);
        }

        static void FizzBuzz(Node node)
        {
            if ((int)node.Value % 15 == 0)
            {
                Console.WriteLine("Fizzbuzz");
            }
            else if ((int)node.Value % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if ((int)node.Value % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(node.Value);
            }

            if (node.Left != null)
            {
                FizzBuzz(node.Left);
            }
            if (node.Right != null)
            {
                FizzBuzz(node.Right);
            }
        }
    }
}
