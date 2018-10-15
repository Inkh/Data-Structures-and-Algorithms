using System;
using Xunit;
using static Fibonacci.Program;

namespace FibonacciTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(13, 7)]
        [InlineData(5, 5)]
        [InlineData(0, 0)]
        public void WillReturnCorrectValue(int expected, int idx)
        {
            Assert.Equal(expected, FibonacciSequence(idx));
        }
    }
}
