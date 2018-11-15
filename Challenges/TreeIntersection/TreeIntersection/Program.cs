using System;
using System.Collections.Generic;
using Tree.Classes;
using Hashtables.Classes;

namespace TreeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree treeOne = new BinaryTree(new Tree.Classes.Node(1));
            treeOne.Root.Left = new Tree.Classes.Node(2);
            treeOne.Root.Left.Left = new Tree.Classes.Node(3);
            treeOne.Root.Left.Right = new Tree.Classes.Node(9);

            treeOne.Root.Right = new Tree.Classes.Node(5);
            treeOne.Root.Right.Right = new Tree.Classes.Node(4);
            treeOne.Root.Right.Left = new Tree.Classes.Node(20);

            BinaryTree treeTwo = new BinaryTree(new Tree.Classes.Node(2));
            treeTwo.Root.Left = new Tree.Classes.Node(20);
            treeTwo.Root.Left.Left = new Tree.Classes.Node(1);
            treeTwo.Root.Left.Left = new Tree.Classes.Node(100);

            treeTwo.Root.Right = new Tree.Classes.Node(4);
            treeTwo.Root.Right.Left = new Tree.Classes.Node(3);

            Console.WriteLine(Intersection(treeOne, treeTwo));
        }

        public static List<int> Intersection(BinaryTree treeOne, BinaryTree treeTwo)
        {
            Hashtable myTable = new Hashtable();
            List<int> retList = new List<int>();
            List<Tree.Classes.Node> listOne = treeOne.PreOrder();
            List<Tree.Classes.Node> listTwo = treeTwo.PreOrder();

            foreach (var item in listOne)
            {
                myTable.Add(item.Value, "temp");
            }

            foreach (var item in listTwo)
            {
                if (myTable.Contains(item.Value.ToString()))
                {
                    retList.Add((int)item.Value);
                }
            }
            return retList;
        }
    }
}
