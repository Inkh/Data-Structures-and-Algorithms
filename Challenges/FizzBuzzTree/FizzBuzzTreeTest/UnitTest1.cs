using System;
using Xunit;
using static FizzBuzzTree.Program;
using Tree.Classes;

namespace FizzBuzzTreeTest
{
    public class UnitTest1
    {
        BinaryTree myTree = new BinaryTree(new Node(5));

        /// <summary>
        /// Supposedly a test for ensuring the method is running as expected.
        /// However, currently untestable due to problem domain.
        /// </summary>
        [Fact]
        public void FizzBuzzWillPrintCorrectlyTest()
        {
            myTree.Root.Left = new Node(4);
            myTree.Root.Left.Left = new Node(30);
            myTree.Root.Left.Right = new Node(1);
            myTree.Root.Right = new Node(3);
            myTree.Root.Right.Right = new Node(15);
            myTree.Root.Right.Left = new Node(10);

            FizzBuzz(myTree);
        }
    }
}
