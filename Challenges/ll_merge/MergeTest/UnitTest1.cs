using System;
using Xunit;
using static ll_merge.Program;
using LinkedList.Classes;

namespace MergeTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests that two equal length lists will zip properly
        /// </summary>
        [Fact]
        public void WillMergeOnEqualTest()
        {
            LList first = new LList(new Node(1));
            first.Append(new Node(3));
            first.Append(new Node(5));

            LList second = new LList(new Node(2));
            second.Append(new Node(4));
            second.Append(new Node(6));

            LList mergeTester = new LList(new Node(1));
            mergeTester.Append(new Node(2));
            mergeTester.Append(new Node(3));
            mergeTester.Append(new Node(4));
            mergeTester.Append(new Node(5));
            mergeTester.Append(new Node(6));

            LList actualMergedList = MergeLists(first, second);

            Node testCurr = mergeTester.Head;
            Node actualCurr = actualMergedList.Head;
            bool isEqual = true;
            while (testCurr.Next != null)
            {
                if (testCurr.Value.ToString() != actualCurr.Value.ToString())
                {
                    isEqual = false;
                }
                testCurr = testCurr.Next;
                actualCurr = actualCurr.Next;
            }

            Assert.True(isEqual);
        }

        /// <summary>
        /// Tests lists will merge properly when first list is shorter
        /// </summary>
        [Fact]
        public void WillMergeWhenFirstListIsShorterTest()
        {
            LList first = new LList(new Node(1));
            first.Append(new Node(3));

            LList second = new LList(new Node(2));
            second.Append(new Node(4));
            second.Append(new Node(6));

            LList mergeTester = new LList(new Node(1));
            mergeTester.Append(new Node(2));
            mergeTester.Append(new Node(3));
            mergeTester.Append(new Node(4));
            mergeTester.Append(new Node(6));

            LList actualMergedList = MergeLists(first, second);

            Node testCurr = mergeTester.Head;
            Node actualCurr = actualMergedList.Head;
            bool isEqual = true;
            while (testCurr != null)
            {
                if (testCurr.Value.ToString() != actualCurr.Value.ToString())
                {
                    isEqual = false;
                }
                testCurr = testCurr.Next;
                actualCurr = actualCurr.Next;
            }

            Assert.True(isEqual);
        }

        /// <summary>
        /// Tests that lists will merge properly when second input list is shorter
        /// </summary>
        [Fact]
        public void WillMergeWhenSecondListIsShorterTest()
        {
            LList first = new LList(new Node(1));
            first.Append(new Node(3));
            first.Append(new Node(5));

            LList second = new LList(new Node(2));
            second.Append(new Node(6));

            LList mergeTester = new LList(new Node(1));
            mergeTester.Append(new Node(2));
            mergeTester.Append(new Node(3));
            mergeTester.Append(new Node(6));
            mergeTester.Append(new Node(5));

            LList actualMergedList = MergeLists(first, second);

            Node testCurr = mergeTester.Head;
            Node actualCurr = actualMergedList.Head;
            bool isEqual = true;
            while (testCurr != null)
            {
                if (testCurr.Value.ToString() != actualCurr.Value.ToString())
                {
                    isEqual = false;
                }
                testCurr = testCurr.Next;
                actualCurr = actualCurr.Next;
            }

            Assert.True(isEqual);
        }
    }
}
