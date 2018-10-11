using System;
using Xunit;
using static BinarySearch.Program;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        [Theory]
        public void WillReturnIndex(int expected, int[] inputArr, int inputVal)
        {
            Assert.Equal(expected, BinarySearchArray(inputArr, inputVal));
        }
    }
}
