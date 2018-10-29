using System;
using Xunit;
using static EeneyMeeneyMineyMoe.Program;
using StackAndQueue.Classes;

namespace EeeneyMeeneyMineyMoeTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests that method will produce the expected result
        /// </summary>
        /// <param name="expected">Expected result</param>
        /// <param name="input">Input array of strings</param>
        /// <param name="n">The nth element to be continuously removed</param>
        [Theory]
        [InlineData("d", new string[] { "a", "b", "c", "d", "e"}, 3)]
        [InlineData("c", new string[] { "a", "b", "c", "d", "e"}, 2)]
        [InlineData("c", new string[] { "a", "b", "c"}, 1)]
        [InlineData("a", new string[] { "a" }, 1)]
        public void WillReturnCorrectItemTest(string expected, string[] input, int n)
        {
            Assert.True(expected == EeneyMeeneyMineyMoeMethod(input, n));
        }
    }
}
