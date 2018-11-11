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
        [InlineData(1,1)]
        [InlineData(2,2)]
        [InlineData(3,3)]
        [InlineData(4,4)]
        public void BFSWillPrintTest(int expected, int count)
        {
            BinaryTree myTree = new BinaryTree(new Node(1));
            myTree.Root.Left = new Node(2);
            myTree.Root.Left.Left = new Node(4);
            myTree.Root.Left.Right = new Node(5);

            myTree.Root.Right = new Node(3);
            myTree.Root.Right.Right = new Node(7);
            myTree.Root.Left = new Node(6);

            int counter = 1;
            foreach (var item in BreadthFirstTraversal(myTree))
            {
                expected = item;
                if (count == counter)
                {
                    break;
                }
                counter++;
            }
            Assert.Equal(expected, count);
        }
    }
}
