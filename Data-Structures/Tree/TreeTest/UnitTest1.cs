using System;
using Xunit;
using Tree.Classes;
using System.Collections.Generic;

namespace TreeTest
{
    public class UnitTest1
    {
        BinaryTree myTree = new BinaryTree(new Node("A"));
        BinarySearchTree myBST = new BinarySearchTree(new Node(0));

        /// <summary>
        /// Checks that PreOrder is correct
        /// </summary>
        [Fact]
        public void WillPreOrderTest()
        {
            myTree.Root.Left = new Node("B");
            myTree.Root.Left.Left = new Node("D");
            myTree.Root.Left.Right = new Node("E");

            myTree.Root.Right = new Node("C");
            myTree.Root.Right.Left = new Node("F");

            myTree.PreOrder();
            List<Node> checkList = new List<Node> { new Node("A"), new Node("B"), new Node("D"), new Node("E"), new Node("C"), new Node("F") };
            Assert.True(checkList[3].Value.Equals(myTree.List[3].Value));
        }

        /// <summary>
        /// Checks if InOrder is correct
        /// </summary>
        [Fact]
        public void WillInOrderTest()
        {
            myTree.Root.Left = new Node("B");
            myTree.Root.Left.Left = new Node("D");
            myTree.Root.Left.Right = new Node("E");

            myTree.Root.Right = new Node("C");
            myTree.Root.Right.Left = new Node("F");

            myTree.InOrder();
            List<Node> checkList = new List<Node> { new Node("D"), new Node("B"), new Node("E"), new Node("A"), new Node("F"), new Node("C") };
            Assert.True(checkList[5].Value.Equals(myTree.List[5].Value));
        }

        /// <summary>
        /// Checks if PostOrder is correct
        /// </summary>
        [Fact]
        public void WillPostOrderTest()
        {
            myTree.Root.Left = new Node("B");
            myTree.Root.Left.Left = new Node("D");
            myTree.Root.Left.Right = new Node("E");

            myTree.Root.Right = new Node("C");
            myTree.Root.Right.Left = new Node("F");

            myTree.PostOrder();
            List<Node> checkList = new List<Node> { new Node("D"), new Node("B"), new Node("E"), new Node("F"), new Node("C"), new Node("A") };
            Assert.True(checkList[5].Value.Equals(myTree.List[5].Value));
        }

        /// <summary>
        /// Checks if correct node will be added at the correct place
        /// </summary>
        [Fact]
        public void WillAddTest()
        {
            myBST.Add(new Node(1));
            myBST.Add(new Node(11));
            myBST.Add(new Node(21));
            myBST.Add(new Node(18));

            Assert.True((int)myBST.Root.Right.Right.Right.Value == 21);
        }

        /// <summary>
        /// Checks if Search returns correct result
        /// </summary>
        [Fact]
        public void WillSearchTest()
        {
            myBST.Add(new Node(1));
            myBST.Add(new Node(11));
            myBST.Add(new Node(21));
            myBST.Add(new Node(18));

            Assert.Equal(myBST.Search(new Node(18)).Value, new Node(18).Value);
        }
    }
}
