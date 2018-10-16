using System;
using Xunit;
using static LinkedList.Program;
using LinkedList.Classes;

namespace LinkedListTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(true, 12)]
        [InlineData(true, 48)]
        [InlineData(true, 33)]
        public void WillFindNode(bool expected, int value)
        {
            Node myNode = new Node(value);
            LList newList = new LList(myNode);
            newList.Append(myNode);

            Assert.True(newList.Includes(myNode) == expected);
        }

        [Theory]
        [InlineData(true, 12)]
        [InlineData(true, 48)]
        [InlineData(true, 33)]
        public void WillAddBefore(bool expected, int value)
        {
            Node myNode = new Node(value);
            LList newList = new LList(myNode);
            Node insertNode = new Node("I'm a node");
            newList.Append(insertNode);

            newList.AddBefore(myNode, insertNode);
            Assert.True(newList.Includes(insertNode) == expected);
        }

        [Theory]
        [InlineData(true, 12)]
        [InlineData(true, 48)]
        [InlineData(true, 33)]
        public void WillAddAfter(bool expected, int value)
        {
            Node myNode = new Node(value);
            LList newList = new LList(myNode);

            Node insertNode = new Node(20);
            newList.AddAfter(myNode, insertNode);
            Assert.True(newList.Includes(insertNode) == expected);
        }

        [Theory]
        [InlineData(true, 12)]
        [InlineData(true, 48)]
        [InlineData(true, 33)]
        public void WillPrint(bool expected, int value)
        {
            Node myNode = new Node(value);
            LList newList = new LList(myNode);

            Assert.True(newList.Print() == expected);
        }
    }
}
