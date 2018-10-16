using System;
using Xunit;
using static LinkedList.Program;
using LinkedList.Classes;

namespace LinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void WillFindNode()
        {
            Node myNode = new Node(10);
            LList newList = new LList(myNode);
            Assert.True(newList.Includes(myNode));
        }

        [Fact]
        public void WillAddBefore()
        {
            Node myNode = new Node(10);
            LList newList = new LList(myNode);
            Node insertNode = new Node("I'm a node");
            newList.AddBefore(myNode, insertNode);
            Assert.True(newList.Includes(insertNode));
        }

        [Fact]
        public void WillAddAfter()
        {
            Node myNode = new Node(10);
            LList newList = new LList(myNode);
            Node insertNode = new Node("I'm a node");
            newList.AddAfter(myNode, insertNode);
            Assert.True(newList.Includes(insertNode));
        }
    }
}
