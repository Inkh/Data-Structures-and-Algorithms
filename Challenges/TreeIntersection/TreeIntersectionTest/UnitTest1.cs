using System;
using Xunit;
using Tree.Classes;
using Hashtables.Classes;
using static TreeIntersection.Program;
using System.Collections.Generic;

namespace TreeIntersectionTest
{
    public class UnitTest1
    {
        [Fact]
        public void IntersectionWillReturnCorrectListTest()
        {
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
            treeTwo.Root.Left.Right = new Tree.Classes.Node(100);

            treeTwo.Root.Right = new Tree.Classes.Node(4);
            treeTwo.Root.Right.Left = new Tree.Classes.Node(3);

            //Console.WriteLine(Intersection(treeOne, treeTwo));
            Assert.Equal(new List<int> { 2, 20, 1, 4, 3 }, Intersection(treeOne, treeTwo));
        }

        [Fact]
        public void EmptyTreeTest()
        {
            BinaryTree treeOne = new BinaryTree(null);
            BinaryTree treeTwo = new BinaryTree(null);

            Assert.Equal(new List<int>(), Intersection(treeOne, treeTwo));
        }

        [Fact]
        public void OneTreeEmptyTest()
        {
            BinaryTree treeOne = new BinaryTree(new Tree.Classes.Node(1));
            treeOne.Root.Left = new Tree.Classes.Node(2);
            treeOne.Root.Left.Left = new Tree.Classes.Node(3);
            treeOne.Root.Left.Right = new Tree.Classes.Node(9);

            treeOne.Root.Right = new Tree.Classes.Node(5);
            treeOne.Root.Right.Right = new Tree.Classes.Node(4);
            treeOne.Root.Right.Left = new Tree.Classes.Node(20);

            BinaryTree treeTwo = new BinaryTree(null);
            Assert.Equal(new List<int>(), Intersection(treeOne, treeTwo));
        }
    }
}
