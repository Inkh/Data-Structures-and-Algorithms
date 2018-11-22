using System;
using Xunit;
using static QuickSorting.Program;

namespace QuickSortTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { -5, 1, 2, 3, 4, 8, 10 }, new int[] { 10, 3, -5, 1, 2, 8, 4 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 0, 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1, 0 })]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 1 }, new int[] { 0, 0, 0, 0, 1, 0 })]
        public void QuickSortTest(int[] expected, int[] input)
        {
            QuickSort(input, 0, input.Length - 1);
            Assert.Equal(expected, input);
        }
    }
}
