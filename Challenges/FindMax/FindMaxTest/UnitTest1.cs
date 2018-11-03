using System;
using Xunit;
using Tree.Classes;
using static FindMax.Program;

namespace FindMaxTest
{
    public class UnitTest1
    {
        BinaryTree myTree = new BinaryTree(new Node(1));

        /// <summary>
        /// Tests that correct value is returned
        /// </summary>
        [Fact]
        public void WillReturnCorrectNodeTest()
        {
            myTree.Root.Left = new Node(3);
            myTree.Root.Left.Left = new Node(10000);

            myTree.Root.Right = new Node(222);
            myTree.Root.Right.Left = new Node(32);

            Assert.Equal(10000, FindMaxValue(myTree));
        }

        [Fact]
        public void WillReturnNegativeOneIfTreeIsEmptyTest()
        {
            BinaryTree myTree = new BinaryTree(null);

            Assert.Equal(-1, FindMaxValue(myTree));
        }

        [Fact]
        public void WillReturnCorrectValueIfSingleNodeTest()
        {
            Assert.Equal(1, FindMaxValue(myTree));
        }
    }
}
