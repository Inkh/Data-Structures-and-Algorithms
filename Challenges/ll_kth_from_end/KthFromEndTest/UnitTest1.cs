using System;
using Xunit;
using static ll_kth_from_end.Program;
using LinkedList.Classes;

namespace KthFromEndTest
{
    public class UnitTest1
    {

        /// <summary>
        /// Tests that correct values will be outputted according to input index.
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="idx"></param>
        [Theory]
        [InlineData(10, 4)]
        [InlineData(40, 1)]
        [InlineData(30, 2)]
        public void WillReturnCorrectValueTest(int expected, int idx)
        {
            LList myList = new LList(new Node(10));
            myList.Append(new Node(20));
            myList.Append(new Node(30));
            myList.Append(new Node(40));
            myList.Append(new Node(50));

            Assert.Equal(expected, ReturnKthFromEnd(myList, idx));
        }

        [Fact]
        public void WillRaiseExceptionTest()
        {
            LList myList = new LList(new Node(10));
            Action breakMethod = (() => ReturnKthFromEnd(myList, 1));
            Exception e = Record.Exception(breakMethod);
            Assert.IsType<IndexOutOfRangeException>(e);
        }

        [Fact]
        public void WillReturnNullIfHeadNullTest()
        {
            LList myList = new LList(null);
            Action breakMethod = (() => ReturnKthFromEnd(myList, 1));
            Exception e = Record.Exception(breakMethod);
            Assert.IsType<NullReferenceException>(e);

        }
    }
}
