using System;
using Xunit;
using static BinarySearch.Program;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, new int[] { 1, 3, 4, 6, 7} , 4)]
        [InlineData(0, new int[] { 1 }, 1)]
        [InlineData(4, new int[] { 2, 4, 6, 8, 10 }, 10)]
        public void WillReturnIndex(int expected, int[] inputArr, int inputVal)
        {
            Assert.Equal(expected, BinarySearchArray(inputArr, inputVal));
        }

        [Theory]
        [InlineData(-1, new int[] { }, 10)]
        [InlineData(-1, new int[] { 1, 5, 7, 8, 100}, 2)]
        public void WillReturnNegativeOne(int expected, int[] inputArr, int inputVal)
        {
            Assert.Equal(expected, BinarySearchArray(inputArr, inputVal));
        }
    }
}
