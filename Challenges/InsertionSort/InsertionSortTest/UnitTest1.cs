using System;
using Xunit;
using static InsertionSort.Program;

namespace InsertionSortTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests that InsertionSort is properly sorting a given array.
        /// </summary>
        /// <param name="expected">Sorted array</param>
        /// <param name="input">Unsorted array</param>
        [Theory]
        [InlineData(new int[] {-5, 1, 2, 3, 4, 8, 10 }, new int[] { 10, 3, -5, 1, 2, 8, 4 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 0, 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1, 0 })]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 1}, new int[] { 0, 0, 0, 0, 1, 0 })]
        public void InsertionSortTest(int[] expected, int[] input)
        {
            InsertionSortMethod(input);
            Assert.Equal(expected, input);
        }
    }
}
