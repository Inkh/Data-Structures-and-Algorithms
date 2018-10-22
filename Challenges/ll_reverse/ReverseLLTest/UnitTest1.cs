using System;
using Xunit;
using LinkedList.Classes;
using static ll_reverse.Program;

namespace ReverseLLTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests that LL Head is reassigned to previous tail
        /// </summary>
        [Fact]
        public void WillBeReversedTest()
        {
            LList myList = new LList(new Node(10));
            myList.Append(new Node(20));
            myList.Append(new Node(30));
            myList.Append(new Node(40));
            myList.Append(new Node(50));

            ReverseLL(myList);

            Assert.Equal(50, myList.Head.Value);
        }

        /// <summary>
        /// Tests that LL is properly reversed where each node's pointer is pointing backwards.
        /// </summary>
        /// <param name="expected">Expected value of node</param>
        /// <param name="listPos">The position of node</param>
        [Theory]
        [InlineData(50,0)]
        [InlineData(40,1)]
        [InlineData(30,2)]
        [InlineData(20,3)]
        [InlineData(10,4)]
        public void NodePointersAreValidTest(int expected, int listPos)
        {
            LList myList = new LList(new Node(10));
            myList.Append(new Node(20));
            myList.Append(new Node(30));
            myList.Append(new Node(40));
            myList.Append(new Node(50));
            ReverseLL(myList);

            myList.Current = myList.Head;
            for (int i = 0; i < listPos; i++)
            {
                myList.Current = myList.Current.Next;
            }

            Assert.Equal(expected, myList.Current.Value);
        }
    }
}
