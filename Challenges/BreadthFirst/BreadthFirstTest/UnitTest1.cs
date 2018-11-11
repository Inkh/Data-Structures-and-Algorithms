using System;
using Xunit;
using static BreadthFirst.Program;
using Tree.Classes;
using System.Collections.Generic;

namespace BreadthFirstTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void BFSWillPrintTest(int idx)
        {
            BinaryTree myTree = new BinaryTree(new Node(1));
            myTree.Root.Left = new Node(2);
            myTree.Root.Left.Left = new Node(4);
            myTree.Root.Left.Right = new Node(5);

            myTree.Root.Right = new Node(3);
            myTree.Root.Right.Right = new Node(7);
            myTree.Root.Right.Left = new Node(6);
            int[] myArr = BreadthFirstTraversal(myTree);

            Assert.Equal(idx + 1, myArr[idx]);
        }
    }
}
