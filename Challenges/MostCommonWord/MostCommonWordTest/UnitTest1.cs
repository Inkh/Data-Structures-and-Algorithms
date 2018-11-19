using System;
using Xunit;
using static MostCommonWord.Program;
using Hashtables.Classes;

namespace MostCommonWordTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests that MostCommon method will produce the expected results
        /// </summary>
        [Theory]
        [InlineData("far", "In a galaxy far far away")]
        [InlineData("cat", "My cat kimchi is the best cat")]
        [InlineData("moon", "The cow jumped over the moon and next moon")]
        [InlineData("", "")]
        public void MostCommonWordTest(string expected, string input)
        {
            Assert.Equal(expected, MostCommon(input));
        }
    }
}
