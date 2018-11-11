using System;
using Xunit;
using static BreadthFirst.Program;
using Tree.Classes;
using System.Collections.Generic;

namespace BreadthFirstTest
{
    public class UnitTest1
    {
        BinaryTree myTree = new BinaryTree(new Node(1));
        [Fact]
        public void BFSWillPrintTest()
        {
            myTree.Root.Left = new Node(2);
            myTree.Root.Left.Left = new Node(4);
            myTree.Root.Left.Right = new Node(5);

            myTree.Root.Right = new Node(3);
            myTree.Root.Right.Right = new Node(7);
            myTree.Root.Left = new Node(6);

            Assert.Equal(new List<int> {1,2,3,4,5,6,7}, BreadthFirstTraversal(myTree));
        }
    }
}
