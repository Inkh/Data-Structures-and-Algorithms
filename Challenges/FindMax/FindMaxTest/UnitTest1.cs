using System;
using Xunit;
using Tree.Classes;
using static FindMax.Program;

namespace FindMaxTest
{
    public class UnitTest1
    {
        BinaryTree myTree = new BinaryTree(new Node(1));
        [Fact]
        public void WillReturnCorrectNodeTest()
        {
            myTree.Root.Left = new Node(3);
            myTree.Root.Left.Left = new Node(10000);

            myTree.Root.Right = new Node(222);
            myTree.Root.Right.Left = new Node(32);

            Assert.Equal(10000, FindMaxValue(myTree));
        }
    }
}
